using GymMe.Controllers;
using GymMe.Models;
using GymMe.Modules;
using System;
using System.Collections.Generic;

namespace GymMe.Views
{
    public partial class TransactionDetailCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int transactionId = int.Parse(Request["TransactionID"]);

            if (!IsPostBack)
            {
                Response<List<TransactionDetail>> transactionDetails = TransactionDetailController.GetAll(transactionId);
                GridTransactionDetail.DataSource = transactionDetails.Payload;
                GridTransactionDetail.DataBind();
            }
        }
    }
}