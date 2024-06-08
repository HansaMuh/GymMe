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
            Response<List<TransactionHeader>> TransactionH = TransactionHeaderController.GetAll();
            HistoryViewTable.DataSource = TransactionH.Payload;
            HistoryViewTable.DataBind();
        }

        protected void HistoryTableRow(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Button detail = (Button)e.Row.FindControl("Detail");
                TransactionHeader transaction = (TransactionHeader)e.Row.DataItem;
                detail.PostBackUrl = $"AdminHistoryDetailView.aspx?TransactionID={transaction.TransactionID}";
            }
        }

        protected void HistoryViewTable_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Response.Redirect("AdminHistoryDetailView.aspx");
        }
    }
}

