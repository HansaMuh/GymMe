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
    public partial class AdminInsertSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void ButtonInsert_Click(object sender, EventArgs e)
        {
            String nama = InputName.Text;
            DateTime exp = InputCalender.SelectedDate;
            int price = Convert.ToInt32(InputPrice.Text.ToString());
            int typeid = Convert.ToInt32(InputId.Text.ToString());

            Response<Supplement> response = SupplementController.Insert(nama, exp, price, typeid);
            if (response.Success)
            {
                LblErrorMsgUpdate.Visible = false;
            }
            else
            {
                LblErrorMsgUpdate.Visible = true;
                LblErrorMsgUpdate.Text = "Error:<br/>" + response.Message;
            }
        }
    }
}