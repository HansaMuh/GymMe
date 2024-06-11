using GymMe.Controllers;
using GymMe.Models;
using GymMe.Modules;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace GymMe.Views
{

    public partial class TransactionDetailCustomer : Page
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