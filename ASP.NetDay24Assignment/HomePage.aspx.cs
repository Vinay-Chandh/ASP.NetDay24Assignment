﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NetDay24Assignment
{
    public partial class HomePage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BtnSignOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginForm.aspx");
        }
    }
}