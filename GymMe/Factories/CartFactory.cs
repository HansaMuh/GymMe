using GymMe.Models;

namespace GymMe.Factories
{

    public class CartFactory
    {

        public static Cart Create(int userId, int supplementId, int quantity)
        {
            return new Cart()
            {
                UserID = userId,
                SupplementID = supplementId,
                Quantity = quantity
            };
        }

    }

}