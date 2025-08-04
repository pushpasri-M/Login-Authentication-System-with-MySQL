using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace Registration.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Account()
        {

            return View();
        }
        public ActionResult Data()
        {
            return View();
        }
        public ActionResult SignIn()
        {
            return View();
        }
        public ActionResult Collect()
        {
            string username = Request.Form["Username"];
            string email = Request.Form["Email"];
            string password = Request.Form["Password"];
            SqlConnection con = new SqlConnection("Data Source=GET-ME-OUT\\SQLEXPRESS;Database=Furn;Integrated Security=True");
            con.Open();
            string query = "INSERT INTO SignIn(username, email, password) VALUES(@username, @email, @password)";
            SqlCommand com = new SqlCommand(query,con);
            com.Parameters.AddWithValue("@username", username);
            com.Parameters.AddWithValue("@email", email);
            com.Parameters.AddWithValue("@password", password);
            // Step 5: Execute the command
            com.ExecuteNonQuery();
            con.Close();
            return RedirectToAction("Index");
        }
    }
}