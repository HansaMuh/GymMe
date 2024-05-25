﻿using GymMe.Controllers;
using GymMe.Models;
using GymMe.Modules;
using GymMe.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.Views
{
    public partial class CustomerProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        protected void RefreshData()
        {
            if (!IsPostBack)
            {
                User user = SessionManager.GetCurrentUser();

                InputName.Text = user.UserName;
                InputEmail.Text = user.UserEmail;
                InputGenderMale.Checked = user.UserGender == "Male";
                InputGenderFemale.Checked = user.UserGender == "Female";
                InputCalender.SelectedDate = user.UserDOB;
                InputCalender.VisibleDate = user.UserDOB;
            }
        }

        protected void ButtonUpdateData_Click(object sender, EventArgs e)
        {
            User user = SessionManager.GetCurrentUser();
            
            if (user != null)
            {
                String name = InputName.Text;
                String email = InputEmail.Text;
                String gender = InputGenderMale.Checked ? "Male" : "Female";
                DateTime dob = InputCalender.SelectedDate;

                Response<User> response = UserController.UpdateProfile(user.UserID, name, email, gender, dob);

                RefreshData();
            }
        }

        protected void ButtonUpdatePassword_Click(object sender, EventArgs e)
        {
            User user = SessionManager.GetCurrentUser();

            if (user != null)
            {
                String New = InputNew.Text;
                String Old = InputOld.Text;

                Response<User> response = UserController.UpdatePassword (user.UserID, New, Old);
                if (response.Success)
                {
                    Response.Write("<script>alert(Profile has been Updated);</script>");
                }
                else
                {
                    Response.Write("<script>alert(Profile can not been updated);</script>");
                }

            }
        }
    }
}