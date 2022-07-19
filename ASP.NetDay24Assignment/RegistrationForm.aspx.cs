using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ASP.NetDay24Assignment
{
    public partial class RegistrationForm : System.Web.UI.Page
    {

        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void ClearText()
        {
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            TxtEmailId.Text = "";
            TxtFirstName.Focus();
            TxtPassword.Text = "";

        }

        protected void BtnSignIn1_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HR"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_AddDetails", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", TxtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", TxtLastName.Text);
                    cmd.Parameters.AddWithValue("@EmailId", TxtEmailId.Text);
                    cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);


                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }


                    cmd.ExecuteNonQuery();
                    Session["FirstName"] = TxtFirstName.Text;
                    Response.Redirect("LoginForm.aspx");
                }
            }
        }

        protected void BtnReset_Click(object sender, EventArgs e)
        {
            this.ClearText();
        }
    }
}