using GymMe.Controllers;
using GymMe.Models;
using GymMe.Modules;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace GymMe.Views
{

    public partial class AdminHistoryDetailView : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            String TransId = Request.QueryString["TransactionID"];

            if (!IsPostBack && TransId != null)
            {
                if (int.TryParse(TransId, out int id))
                {
                    Response<List<TransactionDetail>> TransactionD = TransactionDetailController.GetAll(id);
                    GridViewDetail.DataSource = TransactionD.Payload;
                    GridViewDetail.DataBind();
                }
            }
        }

    }

}