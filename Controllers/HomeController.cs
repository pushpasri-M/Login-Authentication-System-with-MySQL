using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace Registration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            
            return View();
        }
        public ActionResult FormData()
        {
            string name = Request.Form["name"];
            string email = Request.Form["email"];
            string message = Request.Form["message"];
            SqlConnection cont = new SqlConnection("Data source=GET-ME-OUT\\SQLEXPRESS;Database=MessageCS;Integrated Security=true");
            cont.Open();
            string query = "insert into MessageIF(username, email, messageUS) VALUES (@username, @email, @messageUS)";
            SqlCommand comd = new SqlCommand(query, cont);
            comd.Parameters.AddWithValue("@username", name);
            comd.Parameters.AddWithValue("@email", email);
            comd.Parameters.AddWithValue("@messageUS", message);
            comd.ExecuteNonQuery();
            cont.Close();
             return RedirectToAction("Contact");
        }
    }
}