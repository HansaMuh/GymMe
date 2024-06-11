using GymMe.Controllers;
using GymMe.Models;
using GymMe.Modules;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace GymMe.Views
{

    public partial class AdminHomePage : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Response<List<User>> response = UserController.GetAllCustomers();
            CustomerViewTable.DataSource = response.Payload;
            CustomerViewTable.DataBind();
        }

    }

}

