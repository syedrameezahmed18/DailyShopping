﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DailyShopping
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminInfo"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {                
                Models.Admin ad = new Models.Admin();
                string em = Session["AdminInfo"].ToString();
                string returned_name = ad.GetAdminName(em);
                Label1.Text = returned_name;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        
    }
}