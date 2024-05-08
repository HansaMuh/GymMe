using GymMe.Models;

namespace GymMe.Factories
{

    public class CartFactory
    {

        public static Cart Create(int id, int userId, int supplementId, int quantity)
        {
            return new Cart()
            {
                CartID = id,
                UserID = userId,
                SupplementID = supplementId,
                Quantity = quantity
            };
        }

    }

}