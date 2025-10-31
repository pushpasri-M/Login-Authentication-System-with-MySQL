# 🔐 Login Authentication System with MySQL

![Made with ASP.NET](https://img.shields.io/badge/Made%20with-ASP.NET-512BD4?logo=dotnet&logoColor=white&style=flat-square)
![C#](https://img.shields.io/badge/Language-C%23-178600?logo=csharp&logoColor=white&style=flat-square)
![MySQL](https://img.shields.io/badge/Database-MySQL-4479A1?logo=mysql&logoColor=white&style=flat-square)
![Visual Studio](https://img.shields.io/badge/IDE-Visual%20Studio-5C2D91?logo=visualstudio&logoColor=white&style=flat-square)

---

## 📘 Overview

This project is a **web-based login authentication system** built using **ASP.NET** and **C#**, integrated with a **MySQL database**.  
It demonstrates secure user authentication — allowing users to log in with valid credentials stored in the database.

The system follows clean coding practices, separating business logic, database connection handling, and user interface for maintainability.

---

## 🎯 Features

- 🔑 **User Login** — Authenticate users using email/username and password  
- 🧾 **MySQL Integration** — Credentials are stored and verified securely in a MySQL database  
- 🧍 **Session Management** — Maintains logged-in user sessions until logout  
- 🛡️ **Error Handling** — Handles invalid login attempts and missing data gracefully  
- ⚙️ **Modular Structure** — Uses separate classes for database connection and query handling

---

## 🧩 Project Structure

| File / Folder | Description |
|----------------|-------------|
| `Login.aspx` | User interface for login page |
| `Login.aspx.cs` | Backend logic for validating credentials |
| `DBConnection.cs` | Handles MySQL connection setup and closing |
| `web.config` | Contains connection string and configuration settings |

---

## 🛠️ Tools & Technologies

| Tool / Framework | Purpose |
|------------------|----------|
| **ASP.NET Web Forms** | Web application framework |
| **C# (.NET Framework 4.8)** | Backend programming language |
| **MySQL** | Database for storing user credentials |
| **Visual Studio** | Development environment |
| **ADO.NET** | Database connectivity for C# and MySQL |

---

## 🧠 Concepts Demonstrated

- Connecting ASP.NET to **MySQL** using ADO.NET  
- Secure **login validation** and error handling  
- Session management using ASP.NET `Session` object  
- Use of `web.config` for secure database connection strings  
- Separation of frontend and backend logic in Web Forms  

---

## ⚙️ Setup Instructions

1. **Clone the repository**
   ```bash
   git clone https://github.com/pushpasri-M/Login-Authentication-System-with-MySQL.git
2. **Open the project in Visual Studio**

3. **Configure Database**
   - Create a MySQL database named `user_auth`.
   - Run the following SQL query:
     ```sql
     CREATE TABLE users (
         id INT AUTO_INCREMENT PRIMARY KEY,
         username VARCHAR(100),
         password VARCHAR(100)
     );
     ```
   - Insert sample credentials:
     ```sql
     INSERT INTO users (username, password) VALUES ('admin', 'admin123');
     ```

4. **Update `web.config`**
   ```xml
   <connectionStrings>
       <add name="MySqlConnection"
            connectionString="server=localhost;user id=root;password=yourpassword;database=user_auth;"
            providerName="MySql.Data.MySqlClient" />
   </connectionStrings>
## 🚀 Future Enhancements

🔐 Implement password hashing using SHA256 or bcrypt

📧 Add email verification for new user registration

🔄 Include Forgot Password functionality

👥 Add user roles (Admin, User)
