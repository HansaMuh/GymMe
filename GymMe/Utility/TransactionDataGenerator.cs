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
            TransactionDataset.SupplementsDataTable supplements = dataset.Supplements;

            foreach (TransactionHeader th in transactionHeaders)
            {
                foreach (TransactionDetail td in th.TransactionDetails)
                {
                    DataRow detailRow = GetDetailRow(details, td);
                    details.Rows.Add(detailRow);

                    DataRow supplementRow = GetSupplementRow(supplements, td.Supplement);
                    supplements.Rows.Add(supplementRow);
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

        private static DataRow GetDetailRow(TransactionDataset.TransactionDetailsDataTable table, TransactionDetail td)
        {
            DataRow detailRow = table.NewRow();

            detailRow["TransactionID"] = td.TransactionID;
            detailRow["SupplementID"] = td.SupplementID;
            detailRow["Quantity"] = td.Quantity;

            return detailRow;
        }

        private static DataRow GetSupplementRow(TransactionDataset.SupplementsDataTable table, Supplement td)
        {
            DataRow supplementRow = table.NewRow();

            supplementRow["SupplementID"] = td.SupplementID;
            supplementRow["SupplementName"] = td.SupplementName;
            supplementRow["SupplementExpiryDate"] = td.SupplementExpiryDate;
            supplementRow["SupplementPrice"] = td.SupplementPrice;
            supplementRow["SupplementTypeID"] = td.SupplementTypeID;

            return supplementRow;
        }
        #endregion

    }

}