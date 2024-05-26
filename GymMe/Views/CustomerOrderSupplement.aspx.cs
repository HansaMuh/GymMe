using GymMe.Controllers;
using GymMe.Models;
using GymMe.Modules;
using GymMe.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymMe.Views
{
    public partial class CustomerOrderSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response<List<Supplement>> supplement = SupplementController.GetAll();
            SupplementGried.DataSource = supplement.Payload;
            SupplementGried.DataBind();
        }

        protected void SupplementGried_SelectedIndexChanged(object sender, EventArgs e)
        {
            User curentUser = SessionManager.GetCurrentUser();
            GridViewRow row = SupplementGried.Rows[SupplementGried.SelectedIndex];
            int userId = curentUser.UserID;
            int supplementId = int.Parse(row.Cells[0].Text);
            int quantity = int.Parse(((TextBox)row.FindControl("Quantity")).Text);

            if (curentUser != null)
            {
                var response = SupplementController.Order(userId, supplementId, quantity);
                if (response.Success)
                {
                    LblErrorMsg.Visible = false;
                }
                else
                {
                    LblErrorMsg.Visible = true;
                    LblErrorMsg.Text = "Error:<br/>" + response.Message;
                }
            }


        }


        protected void btnClearCart_Click(object sender, EventArgs e)
        {

        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {

        }
    }
}