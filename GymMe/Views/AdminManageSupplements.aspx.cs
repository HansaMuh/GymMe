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
    public partial class AdminManageSupplements : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response < List < Supplement >>supplement= SupplementController.GetAll();
            GridSupplement.DataSource = supplement.Payload;
            GridSupplement.DataBind();

        }

        protected void GridViewSupplement_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int Id = Convert.ToInt32(GridSupplement.DataKeys[e.NewEditIndex].Value);
            Response.Redirect("AdminUpdateSupplement.aspx?SupplementID=" + Id);
        }

        protected void GridViewSupplement_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Id = Convert.ToInt32(GridSupplement.DataKeys[e.RowIndex].Value);

            var response = SupplementController.Delete(Id);

            if (response.Success)
            {
                GridSupplement.DataSource = SupplementController.GetAll().Payload;
                GridSupplement.DataBind();
            }
        }
        protected void GridSupplement_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminInsertSupplement.aspx");
        }
    }
}