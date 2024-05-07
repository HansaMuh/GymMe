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

        public static Cart Get(int id)
        {
            return Database.Carts.FirstOrDefault(c => c.CartID == id);
        }

        public static void Insert(Cart cart)
        {
            Database.Carts.Add(cart);
            Database.SaveChanges();
        }

    }

}