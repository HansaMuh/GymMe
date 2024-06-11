using GymMe.Controllers;
using GymMe.Models;
using GymMe.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.Views
{
    public partial class AdminHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String role = "Customer";
            Response<List<User>> response = UserController.GetRole(role);
            CustomerViewTable.DataSource = response.Payload;
            CustomerViewTable.DataBind();
        }

    }
}

