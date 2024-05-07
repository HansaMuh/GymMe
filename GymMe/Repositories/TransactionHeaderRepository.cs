using GymMe.Models;
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

    }

}