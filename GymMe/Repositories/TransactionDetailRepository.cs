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

        public static TransactionDetail Get(int id)
        {
            return Database.TransactionDetails.FirstOrDefault(td => td.TransactionID == id);
        }

        public static void Insert(TransactionDetail transactionDetail)
        {
            Database.TransactionDetails.Add(transactionDetail);
            Database.SaveChanges();
        }

    }

}