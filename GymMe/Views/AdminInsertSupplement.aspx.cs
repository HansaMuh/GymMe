using GymMe.Controllers;
using GymMe.Models;
using GymMe.Modules;
using System;
using System.Web.UI;

namespace GymMe.Views
{

    public partial class AdminInsertSupplement : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
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
                LblSuccessionMsg.Visible = true;
                LblSuccessionMsg.Text = response.Message;

                LblErrorMsgUpdate.Visible = false;
            }
            else
            {
                LblSuccessionMsg.Visible = false;

                LblErrorMsgUpdate.Visible = true;
                LblErrorMsgUpdate.Text = "Error:<br/>" + response.Message;
            }
        }

    }

}