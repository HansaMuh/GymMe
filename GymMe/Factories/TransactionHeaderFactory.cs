using GymMe.Models;
using System;

namespace GymMe.Factories
{

    public class TransactionHeaderFactory
    {

        public static TransactionHeader Create(int userId, DateTime transactionDate, string status)
        {
            return new TransactionHeader()
            {
                UserID = userId,
                TransactionDate = transactionDate,
                Status = status
            };
        }

    }

}