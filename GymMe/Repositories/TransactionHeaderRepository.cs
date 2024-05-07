using GymMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GymMe.Repositories
{

    public class TransactionHeaderRepository
    {

        private static DatabaseEntities Database
        {
            get => DatabaseSingleton.Instance;
        }

        public static List<TransactionHeader> GetAll()
        {
            return Database.TransactionHeaders.ToList();
        }

        public static TransactionHeader Get(int id)
        {
            return Database.TransactionHeaders.FirstOrDefault(th => th.TransactionID == id);
        }

        public static void Insert(TransactionHeader transactionHeader)
        {
            Database.TransactionHeaders.Add(transactionHeader);
            Database.SaveChanges();
        }

        public static TransactionHeader Update(int id, int userId, DateTime transactionDate, string status)
        {
            TransactionHeader transactionHeader = Get(id);

            if (transactionHeader != null)
            {
                transactionHeader.UserID = userId;
                transactionHeader.TransactionDate = transactionDate;
                transactionHeader.Status = status;
                Database.SaveChanges();

                return transactionHeader;
            }
            else
            {
                return null;
            }
        }

    }

}