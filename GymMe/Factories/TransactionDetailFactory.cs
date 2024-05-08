using GymMe.Models;

namespace GymMe.Factories
{

    public class TransactionDetailFactory
    {

        public static TransactionDetail Create(int transactionId, int supplementId, int quantity)
        {
            return new TransactionDetail()
            {
                TransactionID = transactionId,
                SupplementID = supplementId,
                Quantity = quantity
            };
        }

    }

}