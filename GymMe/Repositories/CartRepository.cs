using GymMe.Models;
using System.Collections.Generic;
using System.Linq;

namespace GymMe.Repositories
{

    public class CartRepository
    {

        private static DatabaseEntities Database
        {
            get => DatabaseSingleton.Instance;
        }

        public static List<Cart> GetAll()
        {
            return Database.Carts.ToList();
        }

        public static List<Cart> GetAll(int userId)
        {
            return Database.Carts.Where(c => c.UserID == userId).ToList();
        }

        public static Cart Get(int id)
        {
            return Database.Carts.FirstOrDefault(c => c.CartID == id);
        }

        public static void Insert(Cart cart)
        {
            Database.Carts.Add(cart);
            Database.SaveChanges();
        }

        public static bool Delete(int id)
        {
            Cart cart = Get(id);

            if (cart != null)
            {
                Database.Carts.Remove(cart);
                Database.SaveChanges();

                return true;
            }

            return false;
        }

        public static bool Clear(int userId)
        {
            List<Cart> carts = GetAll(userId);

            if (carts.Count > 0)
            {
                Database.Carts.RemoveRange(carts);
                Database.SaveChanges();

                return true;
            }

            return false;
        }

    }

}