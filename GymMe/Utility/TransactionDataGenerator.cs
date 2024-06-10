using GymMe.Datasets;
using GymMe.Models;
using System.Collections.Generic;
using System.Data;

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

            foreach (TransactionHeader th in transactionHeaders)
            {
                foreach (TransactionDetail td in th.TransactionDetails)
                {
                    DataRow detailRow = GetDetailRow(details, td, td.Supplement);
                    details.Rows.Add(detailRow);
                }

                DataRow headerRow = GetHeaderRow(header, th);
                header.Rows.Add(headerRow);
            }

            return dataset;
        }
        #endregion

        #region Methods: Utility
        private static DataRow GetHeaderRow(TransactionDataset.TransactionHeadersDataTable table, TransactionHeader th)
        {
            DataRow headerRow = table.NewRow();

            headerRow["TransactionID"] = th.TransactionID;
            headerRow["UserID"] = th.UserID;
            headerRow["TransactionDate"] = th.TransactionDate;
            headerRow["Status"] = th.Status;

            return headerRow;
        }

        private static DataRow GetDetailRow(TransactionDataset.TransactionDetailsDataTable table, TransactionDetail td, Supplement supplement)
        {
            DataRow detailRow = table.NewRow();

            detailRow["TransactionID"] = td.TransactionID;
            detailRow["SupplementID"] = td.SupplementID;
            detailRow["Quantity"] = td.Quantity;
            detailRow["Income"] = supplement.SupplementPrice * td.Quantity;

            return detailRow;
        }
        #endregion

    }

}