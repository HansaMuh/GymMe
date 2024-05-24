using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Input_Click(object sender, EventArgs e)
        {
            String name = InputName.Text;
            String email = InputEmail.Text;
            String gender = InputGender.Text;
        }
    }

    

}