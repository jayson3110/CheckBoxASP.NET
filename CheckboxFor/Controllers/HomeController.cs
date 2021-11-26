using CheckboxFor.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckboxFor.Controllers
{
   
    public class HomeController : Controller
    {
        SqlConnection con = new db().con;

        public ActionResult Index()
        {


            /* db data = new db();
             dynamic mymodel = new ExpandoObject();
             mymodel.Users = data.GetUsers();
             mymodel.Roles = data.GetRoles(); */
            List<Users> model = new db().GetUsers();
            


            return View(model);

        }


        public ActionResult Edit(int id)
        {
            List<Users> userList = new db().GetUsers();
            var getId = userList.Single(m => m.Id == id);

            return View(getId);
        }

        [HttpPost]
        public ActionResult Edit(Users user, int id)
        {
            SqlCommand cmd = new SqlCommand();
            List<Users> users = new db().GetUsers();
            List<roles> roles = new db().GetRoles();


            var getId = users.Single(m => m.Id == id);
            var getRoles = roles.Single(m => m.ID == 1);

            con.Open();

            switch (user.IsCheck1)
            {
                case  true:
                    cmd.CommandText = "update Users set Editing ='Test' where Id=" + getId.Id + "  ";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();

                   
                    break;
                case false:
                    cmd.CommandText = "update Users set Editing = Null where Id=" + getId.Id + "  ";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();


                    break;
              
            }
            switch (user.IsCheck2)
            {
                case true:
                    cmd.CommandText = "update Users set Detail = 'Test2' Where Id =" + getId.Id + "";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    break;
                case false:
                    cmd.CommandText = "update Users set Detail = Null where Id=" + getId.Id + "  ";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    break;

            }
            switch (user.IsCheck3)
            {
                case true:
                    cmd.CommandText = "update Users set Deleting = 'Test3' Where Id =" + getId.Id + "";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    break;
                case false:
                      cmd.CommandText = "update Users set Deleting = Null Where Id =" + getId.Id + "";
                      cmd.Connection = con;
                      cmd.ExecuteNonQuery();
                    break;

            }
            





            return View();

        }


    }




    
}