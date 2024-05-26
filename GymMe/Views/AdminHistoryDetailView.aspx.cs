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
    public partial class AdminHistoryDetailView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String TransId = Request.QueryString["TransactionID"];

            if(!IsPostBack && TransId != null )
            {
                int id;
                if (int.TryParse(TransId, out id))
                {
                    Response<List<TransactionDetail>> TransactionD = TransactionDetailController.GetAll(id);
                    GridViewDetail.DataSource = TransactionD.Payload;
                    GridViewDetail.DataBind();
                }
            }
        }
    }
}