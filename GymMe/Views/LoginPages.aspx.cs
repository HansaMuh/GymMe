﻿using GymMe.Controllers;
using GymMe.Models;
using GymMe.Modules;
using GymMe.Utility;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.Views
{

    public partial class LoginPages : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }

            if (Request.Cookies["username"] != null && Request.Cookies["password"] != null)
            {
                inputusername.Text = Request.Cookies["username"].Value;
                inputpassword.Text = Request.Cookies["password"].Value;
                CheckBox.Checked = true;
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            String name = inputusername.Text;
            String pass = inputpassword.Text;

            Response<User> response = UserController.Authenticate(name, pass);

            if (response.Success)
            {
                SessionManager.SaveCurrentUser(response.Payload);
                LblErrorMsg.Visible = false;

                if (CheckBox.Checked)
                {
                    Response.Cookies["username"].Value = name;
                    Response.Cookies["password"].Value = pass;
                    Response.Cookies["username"].Expires = DateTime.Now.AddDays(10);
                    Response.Cookies["password"].Expires = DateTime.Now.AddDays(10);
                }
                else
                {
                    Response.Cookies["username"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["password"].Expires = DateTime.Now.AddDays(-1);
                }

                if (response.Payload.UserRole.Equals("Customer"))
                {
                    Response.Redirect("HomePageCustomer.aspx");
                }
                else if (response.Payload.UserRole.Equals("Admin"))
                {
                    Response.Redirect("AdminHomePage.aspx");
                }
            }
            else
            {
                LblErrorMsg.Visible = true;
                LblErrorMsg.Text = "Error:<br/>" + response.Message;
            }
        }

        protected void BtnRegis_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }

    }

}