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

    public partial class CustomerOrderSupplement : Page
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
            }

            RefreshData();
        }

        protected void btnClearCart_Click(object sender, EventArgs e)
        {
            User user = SessionManager.GetCurrentUser();
            if (user != null)
            {
                Response<List<Cart>> response = CartController.Clear(user.UserID);
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
            }

            RefreshData();
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            User user = SessionManager.GetCurrentUser();
            if (user != null)
            {
                Response<TransactionHeader> response = TransactionHeaderController.Checkout(user.UserID);
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
            }

            RefreshData();
        }

        protected void RefreshData()
        {
            Response<List<Supplement>> supplements = SupplementController.GetAll();
            SupplementGrid.DataSource = supplements.Payload;
            SupplementGrid.DataBind();

            Response<List<Cart>> carts = CartController.GetAll();
            GridViewCart.DataSource = carts.Payload;
            GridViewCart.DataBind();
        }
    }
}