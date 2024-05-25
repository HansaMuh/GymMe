﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.Views
{
    public partial class GymMeSite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["username"] != null)
            {
                HttpCookie GymMecookie = new HttpCookie("username");
                GymMecookie.Expires = DateTime.Now.AddDays(1d);
                Response.Cookies.Add(GymMecookie);
            }

            if (Request.Cookies["password"] != null)
            {
                HttpCookie GymMeCookie = new HttpCookie("password");
                GymMeCookie.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(GymMeCookie);
            }

            Response.Redirect("LoginPages.aspx");
        }
    }
}