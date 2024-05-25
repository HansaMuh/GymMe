using GymMe.Controllers;
using GymMe.Models;
using GymMe.Modules;
using System;

namespace GymMe.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
               
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string name = InputName.Text;
            string email = InputEmail.Text;
            string gender = InputGenderMale.Checked ? InputGenderMale.Text : InputGenderFemale.Checked ? InputGenderFemale.Text : string.Empty;
            string password = InputPassword.Text;
            string confirmPassword = InputConfirm.Text;
            DateTime dob = InputCalender.SelectedDate;

            Response<User> response = UserController.Register(name, email, gender, password, confirmPassword, dob);
            if (response.Success)
            {
                LblErrorMsg.Visible = false;
                Response.Redirect("LoginPages.aspx");
            }
            else
            {
                LblErrorMsg.Visible = true;
                LblErrorMsg.Text = "Error:<br/>" + response.Message;
            }
        }
    }

}