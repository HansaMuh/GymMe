using GymMe.Controllers;
using GymMe.Models;
using GymMe.Modules;
using GymMe.Utility;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.Views
{
    public partial class AdminUpdateSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        protected void RefreshData()
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["SupplementID"] != null)
                {
                    int id = int.Parse(Request.QueryString["SupplementID"]);
                    var supplement = SupplementController.Get(id);
                    if ((supplement.Success))
                    {
                        InputName.Text = supplement.Payload.SupplementName;
                        InputCalender.SelectedDate = supplement.Payload.SupplementExpiryDate;
                        InputCalender.VisibleDate = supplement.Payload.SupplementExpiryDate;
                        InputPrice.Text = supplement.Payload.SupplementPrice.ToString();
                        InputId.Text = supplement.Payload.SupplementTypeID.ToString();

                    }
                }

            }
        }
        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["SupplementID"]);
            String nama = InputName.Text;
            DateTime exp = InputCalender.SelectedDate;
            int price = Convert.ToInt32(InputPrice.Text.ToString());
            int typeid = Convert.ToInt32(InputId.Text.ToString());

            Response<Supplement> response = SupplementController.Update(id, nama, exp, price, typeid);
            if (response.Success)
            {
                LblErrorMsgUpdate.Visible = false;
            }
            else
            {
                LblErrorMsgUpdate.Visible = true;
                LblErrorMsgUpdate.Text = "Error:<br/>" + response.Message;
            }
            RefreshData();


        }
    }
}