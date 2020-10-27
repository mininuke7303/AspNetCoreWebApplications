using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using User_Reg_Without_EF.Models;

namespace User_Reg_Without_EF.Controllers {
    public class UserRegistrationController : Controller {
        public IActionResult Index() {
            return View();
        }



        public IActionResult Create() {
            return View();
        }



        [HttpPost]
        public IActionResult Create(UserRegClass ur) {
            string connection = "Data Source=dbserver;Initial Catalog=Employee;User ID=sa;Password=!7mlgtaw3";

            using (SqlConnection sqlconn = new SqlConnection(connection)) {
                string sqlquery = $"insert into NewEmployee (Username, Uemail, Pwd, MartialStatus, Gender) values ('{ur.Username}', '{ur.Uemail}', '{ur.Pwd}', '{ur.MartialStatus}', '{ur.Gender}')";
                using (SqlCommand sqlcomm = new SqlCommand(sqlquery,sqlconn)) {
                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    ViewData["Message"] = $"The New Employee '{ur.Username}' is Saved Successfully !!";
                    
                }
            }
            return View(ur);
        }
    }
}
