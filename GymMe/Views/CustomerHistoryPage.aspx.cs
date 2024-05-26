using GymMe.Controllers;
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
    public partial class CustomerHistoryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = SessionManager.GetCurrentUser();
            Response<List<TransactionHeader>> transactionH = TransactionHeaderController.GetAll(user.UserID);
            HistoryCustomerTable.DataSource = transactionH.Payload;
            HistoryCustomerTable.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("TransactionDetailCustomer.aspx");
        }
    }
}