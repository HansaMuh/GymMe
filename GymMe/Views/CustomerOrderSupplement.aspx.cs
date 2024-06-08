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
    public partial class CustomerOrderSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RefreshData();
            }
        }


        protected void SupplementGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = SupplementGrid.SelectedRow;
            int supplementId = int.Parse(row.Cells[0].Text);
            int quantity = int.Parse((row.FindControl("Quantity") as TextBox).Text);

            User user = SessionManager.GetCurrentUser();
            if (user != null)
            {
                Response<Supplement> response = SupplementController.Order(user.UserID, supplementId, quantity);
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
            User user = SessionManager.GetCurrentUser();
            if (user != null)
            {
                Response<List<Cart>> response = CartController.Clear(user.UserID);
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

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            User user = SessionManager.GetCurrentUser();
            if (user != null)
            {
                Response<TransactionHeader> response = TransactionHeaderController.Checkout(user.UserID);
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

        protected void RefreshData()
        {
            Response<List<Supplement>> supplement = SupplementController.GetAll();
            SupplementGrid.DataSource = supplement.Payload;
            SupplementGrid.DataBind();

            Response<List<Cart>> cart = CartController.GetAll();
            GridViewCart.DataSource = cart.Payload;
            GridViewCart.DataBind();
        }

        protected void GridViewCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}