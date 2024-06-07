using GymMe.Controllers;
using GymMe.Datasets;
using GymMe.Models;
using GymMe.Modules;
using GymMe.Reports;
using GymMe.Utility;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace GymMe.Views
{

    public partial class AdminReportPage : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Response<List<TransactionHeader>> response = TransactionHeaderController.GetAll();
            List<TransactionHeader> list = response.Payload;

            TransactionDataset dataset = TransactionDataGenerator.CreateDataset(list);
            TransactionReport report = new TransactionReport();
            report.SetDataSource(dataset);
            
            CrystalReportViewer.ReportSource = report;
        }

    }

}