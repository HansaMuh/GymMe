using GymMe.Controllers;
using GymMe.Models;
using GymMe.Modules;
using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.Views
{

    public partial class AdminQuequePage : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RefreshData();
            }
        }

        protected void ClickHandle(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            GridViewRow row = (GridViewRow)button.NamingContainer;

            int id = Convert.ToInt32(UnhandledSituation.DataKeys[row.RowIndex].Value);
            string status = "Handled";

            Response<TransactionHeader> response = TransactionHeaderController.HandleTransaction(id, status);

            if (response.Success)
            {
                LblSuccessionMsg.Visible = true;
                LblSuccessionMsg.Text = response.Message;

                LblErrorMsg.Visible = false;
            }
            else
            {
                LblSuccessionMsg.Visible = false;

                LblErrorMsg.Visible = true;
                LblErrorMsg.Text = "Error:<br/>" + response.Message;
            }

            RefreshData();
        }

        private void RefreshData()
        {
            Response<List<TransactionHeader>> unhandle = TransactionHeaderController.GetAllUnhandled();
            UnhandledSituation.DataSource = unhandle.Payload;
            UnhandledSituation.DataBind();

            Response<List<TransactionHeader>> handle = TransactionHeaderController.GetAllHandled();
            HandledSituation.DataSource = handle.Payload;
            HandledSituation.DataBind();
        }

    }

}