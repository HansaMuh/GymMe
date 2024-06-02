using CrystalDecisions.CrystalReports.Engine;
using GymMe.Datasets;
using GymMe.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace GymMe.Utility
{

    public class TransactionDataGenerator
    {

        #region Methods: Generator
        public static TransactionDataset CreateDataset(List<TransactionHeader> transactionHeaders)
        {
            TransactionDataset dataset = new TransactionDataset();

            TransactionDataset.TransactionHeadersDataTable header = dataset.TransactionHeaders;
            TransactionDataset.TransactionDetailsDataTable details = dataset.TransactionDetails;

            decimal grandTotalIncome = 0;

            foreach (TransactionHeader th in transactionHeaders)
            {
                decimal subtotalIncome = 0;

                foreach (TransactionDetail td in th.TransactionDetails)
                {
                    DataRow detailRow = GetDetailRow(details, td);
                    details.Rows.Add(detailRow);

                    subtotalIncome += td.Quantity * td.Supplement.SupplementPrice;
                }

                DataRow headerRow = GetHeaderRow(header, th, subtotalIncome);
                header.Rows.Add(headerRow);

                grandTotalIncome += subtotalIncome;

                DataRow totalIncomeRow = GetTotalIncomeRow(header, grandTotalIncome);
                header.Rows.Add(totalIncomeRow);
            }

            return dataset;
        }

        // Temporary function to generate a report
        //public static ReportDocument GenerateReport(List<TransactionHeader> transactionHeaders)
        //{
        //    // Create a new report document
        //    ReportDocument report = new ReportDocument();

        //    // Load the report template
        //    report.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "SalesReportTemplate.rpt"));

        //    // Set the dataset for the report
        //    TransactionDataset dataset = CreateDataset(transactionHeaders);
        //    report.SetDataSource(dataset);

        //    // Set the report parameters
        //    report.SetParameterValue("GrandTotalIncome", CalculateGrandTotalIncome(transactionHeaders));
        
        //    return report;
        //}
        #endregion

        #region Methods: Utility
        private static DataRow GetHeaderRow(TransactionDataset.TransactionHeadersDataTable table, TransactionHeader th, decimal subtotalIncome)
        {
            DataRow headerRow = table.NewRow();

            headerRow["TransactionID"] = th.TransactionID;
            headerRow["UserID"] = th.UserID;
            headerRow["TransactionDate"] = th.TransactionDate;
            headerRow["Status"] = th.Status;
            headerRow["SubtotalIncome"] = subtotalIncome;

            headerRow["GrandTotalIncome"] = null;

            return headerRow;
        }

        private static DataRow GetDetailRow(TransactionDataset.TransactionDetailsDataTable table, TransactionDetail td)
        {
            DataRow detailRow = table.NewRow();

            detailRow["TransactionID"] = td.TransactionID;
            detailRow["SupplementID"] = td.SupplementID;
            detailRow["Quantity"] = td.Quantity;

            return detailRow;
        }

        private static DataRow GetTotalIncomeRow(TransactionDataset.TransactionHeadersDataTable table, decimal grandTotalIncome)
        {
            DataRow totalIncomeRow = table.NewRow();

            totalIncomeRow["TransactionID"] = null;
            totalIncomeRow["UserID"] = null;
            totalIncomeRow["TransactionDate"] = null;
            totalIncomeRow["Status"] = null;
            totalIncomeRow["SubtotalIncome"] = null;

            totalIncomeRow["GrandTotalIncome"] = grandTotalIncome;

            return totalIncomeRow;
        }

        // Temporary function to calculate grand total income
        //private static decimal CalculateGrandTotalIncome(List<TransactionHeader> transactionHeaders)
        //{
        //    decimal grandTotalIncome = 0;

        //    foreach (TransactionHeader th in transactionHeaders)
        //    {
        //        decimal transactionSubTotal = 0;

        //        foreach (TransactionDetail td in th.TransactionDetails)
        //        {
        //            decimal subTotalValue = td.Quantity * td.Supplement.SupplementPrice;
        //            transactionSubTotal += subTotalValue;
        //        }

        //        grandTotalIncome += transactionSubTotal;
        //    }

        //    return grandTotalIncome;
        //}
        #endregion

    }

}