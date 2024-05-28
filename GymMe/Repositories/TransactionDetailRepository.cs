using GymMe.Models;
using System.Collections.Generic;
using System.Linq;

namespace GymMe.Repositories
{

    public class TransactionDetailRepository
    {

        private static DatabaseEntities Database
        {
            get => DatabaseSingleton.Instance;
        }

        public static List<TransactionDetail> GetAll()
        {
            return Database.TransactionDetails.ToList();
        }

        public static List<TransactionDetail> GetAll(int id)
        {
            return Database.TransactionDetails.Where(td => td.TransactionID == id).ToList();
        }

        public static List<TransactionDetail> GetAllBySupplement(int supplementId)
        {
            return Database.TransactionDetails.Where(td => td.SupplementID == supplementId).ToList();
        }

        public static TransactionDetail Get(int id)
        {
            return Database.TransactionDetails.FirstOrDefault(td => td.TransactionID == id);
        }

        public static void Insert(TransactionDetail transactionDetail)
        {
            Database.TransactionDetails.Add(transactionDetail);
            Database.SaveChanges();
        }

        public static bool ClearBySupplement(int supplementId)
        {
            List<TransactionDetail> transactionDetails = GetAllBySupplement(supplementId);

            if (transactionDetails.Count > 0)
            {
                Database.TransactionDetails.RemoveRange(transactionDetails);
                Database.SaveChanges();

                return true;
            }

            return false;
        }

    }

}