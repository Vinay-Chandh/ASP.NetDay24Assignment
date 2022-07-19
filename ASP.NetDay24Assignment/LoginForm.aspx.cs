using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace ASP.NetDay24Assignment
{
    public partial class LoginForm : System.Web.UI.Page
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HR"].ConnectionString))
            {

                string email, password;
                email = TxtEmailId.Text;
                password = TxtPassword.Text;
                cmd = new SqlCommand("select * from registration where Email_Id = '" + email + "' and password = '" + password + "'  ", con);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    LblMessage.Text = "Login Successful";
                }
                else
                {
                    LblMessage.Text = "Invalid EMAIL or PASSWORD";
                }

                Server.Transfer("HomePage.aspx", true);

            }

        }
    }
}