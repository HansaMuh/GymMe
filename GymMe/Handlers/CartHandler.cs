using GymMe.Factories;
using GymMe.Models;
using GymMe.Modules;
using GymMe.Repositories;
using System;
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
            Cart cart = CartFactory.Create(GenerateID(), userId, supplementId, quantity);

            return new Response<Cart>()
            {
                Success = true,
                Message = "Successfully created the cart.",
                Payload = cart
            };
        }
        #endregion

        #region Methods: Utility
        private static int GenerateID()
        {
            return CartRepository.GetAll().Count + 1;
        }
        #endregion

    }

}