using GymMe.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public static List<Cart> GetAllBySupplement(int supplementId)
        {
            return Database.Carts.Where(c => c.SupplementID == supplementId).ToList();
        }

        public static Cart Get(int id)
        {
            return Database.Carts.FirstOrDefault(c => c.CartID == id);
        }

        public static Cart Get(int userId, int supplementId)
        {
            return Database.Carts.FirstOrDefault(c => c.UserID == userId && c.SupplementID == supplementId);
        }

        public static void Insert(Cart cart)
        {
            Database.Carts.Add(cart);
            Database.SaveChanges();
        }

        public static Cart Update(int id, int userId, int supplementId, int quantity)
        {
            Cart cart = Get(id);

            if (cart != null)
            {
                cart.UserID = userId;
                cart.SupplementID = supplementId;
                cart.Quantity = quantity;

                Database.Entry(cart).State = EntityState.Modified;
                Database.SaveChanges();

                return cart;
            }
            else
            {
                return null;
            }
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

        public static bool ClearBySupplement(int supplementId)
        {
            List<Cart> carts = GetAllBySupplement(supplementId);

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