using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CheckboxFor.Models
{
    public class db
    {
        public SqlConnection con = new SqlConnection("data source=JAYSON\\SQLEXPRESS; database=Product; integrated security=SSPI; MultipleActiveResultSets=True");

        public List<Users> GetUsers()
        {

            SqlCommand cmd = new SqlCommand("select * from Users ");
            var model = new List<Users>();
            cmd.Connection = con;
            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {

                var users = new Users();
                users.Id += (int)sdr["Id"];
                users.Editing += sdr["Editing"];
                users.Detail += sdr["Detail"];
                users.Deleting += sdr["Deleting"];


                model.Add(users);





            }
            con.Close();

            return model;

        }


        public List<roles> GetRoles()
        {

            SqlCommand cmd = new SqlCommand("select * from Roles ");
            var model = new List<roles>();
            cmd.Connection = con;
            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {

                var roles = new roles();
                roles.ID += (int)sdr["ID"];
                roles.roles_name += sdr["Roles_name"];
                


                model.Add(roles);





            }
            con.Close();

            return model;

        }


    }
}