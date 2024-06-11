using GymMe.Controllers;
using GymMe.Models;
using GymMe.Modules;
using GymMe.Utility;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.Views
{

    public partial class CustomerHistoryPage : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            User user = SessionManager.GetCurrentUser();
            Response<List<TransactionHeader>> transactionH = TransactionHeaderController.GetAll(user.UserID);
            HistoryCustomerTable.DataSource = transactionH.Payload;
            HistoryCustomerTable.DataBind();
        }

        protected void HistoryTableRow(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Button detail = (Button)e.Row.FindControl("Detail");
                TransactionHeader transaction = (TransactionHeader)e.Row.DataItem;
                detail.PostBackUrl = $"TransactionDetailCustomer.aspx?TransactionID={transaction.TransactionID}";
            }
        }

        protected void HistoryCustomerTable_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Response.Redirect("TransactionDetailCustomer.aspx");
        }

    }

}