using GymMe.Factories;
using GymMe.Models;
using GymMe.Modules;
using GymMe.Repositories;
using System.Collections.Generic;

namespace GymMe.Handlers
{

    public class CartHandler
    {

        #region Methods: CRUD
        public static Response<List<Cart>> GetAll()
        {
            List<Cart> carts = CartRepository.GetAll();
            bool isEmpty = carts.Count == 0;

            return new Response<List<Cart>>()
            {
                Success = !isEmpty,
                Message = isEmpty ? "No carts found" : "Carts found",
                Payload = carts
            };
        }

        public static Response<List<Cart>> GetAll(int userId)
        {
            List<Cart> carts = CartRepository.GetAll(userId);
            bool isEmpty = carts.Count == 0;

            return new Response<List<Cart>>()
            {
                Success = !isEmpty,
                Message = isEmpty ? "No carts found" : "Carts found for the user",
                Payload = carts
            };
        }

        public static Response<Cart> Get(int id)
        {
            Cart cart = CartRepository.Get(id);
            bool isNull = cart is null;

            return new Response<Cart>()
            {
                Success = !isNull,
                Message = isNull ? "Cart not found" : "Cart found",
                Payload = cart
            };
        }

        public static Response<Cart> Create(int userId, int supplementId, int quantity)
        {
            Cart cart = CartFactory.Create(userId, supplementId, quantity);

            return new Response<Cart>()
            {
                Success = true,
                Message = "Successfully created the cart.",
                Payload = cart
            };
        }

        public static Response<Cart> Delete(int id)
        {
            bool success = CartRepository.Delete(id);

            return new Response<Cart>()
            {
                Success = success,
                Message = success ? "Successfully deleted the cart." : "No cart found",
                Payload = null
            };
        }

        public static Response<List<Cart>> Clear(int userId)
        {
            bool success = CartRepository.Clear(userId);

            return new Response<List<Cart>>()
            {
                Success = success,
                Message = success ? "Successfully cleared the carts for the user." : "No carts found",
                Payload = null
            };
        }

        public static Response<List<Cart>> ClearBySupplement(int supplementId)
        {
            bool success = CartRepository.ClearBySupplement(supplementId);

            return new Response<List<Cart>>()
            {
                Success = success,
                Message = success ? "Successfully cleared the carts for the supplement." : "No carts found",
                Payload = null
            };
        }
        #endregion

    }

}