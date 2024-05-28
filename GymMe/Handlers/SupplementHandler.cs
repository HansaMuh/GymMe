using GymMe.Factories;
using GymMe.Models;
using GymMe.Modules;
using GymMe.Repositories;
using System;
using System.Collections.Generic;

namespace GymMe.Handlers
{

    public class SupplementHandler
    {

        #region Methods: CRUD
        public static Response<List<Supplement>> GetAll()
        {
            List<Supplement> supplements = SupplementRepository.GetAll();
            bool isEmpty = supplements.Count == 0;

            return new Response<List<Supplement>>()
            {
                Success = !isEmpty,
                Message = isEmpty ? "No supplements found" : "Supplements found",
                Payload = supplements
            };
        }

        public static Response<Supplement> Get(int id)
        {
            Supplement supplement = SupplementRepository.Get(id);
            bool isNull = supplement is null;

            return new Response<Supplement>()
            {
                Success = !isNull,
                Message = isNull ? "Supplement not found" : "Supplement found",
                Payload = supplement
            };
        }

        public static Response<Supplement> Create(string name, DateTime expiryDate, int price, int typeId)
        {
            Supplement supplement = SupplementFactory.Create(name, expiryDate, price, typeId);

            return new Response<Supplement>()
            {
                Success = true,
                Message = "Successfully created the supplement.",
                Payload = supplement
            };
        }

        public static Response<Supplement> Insert(string name, DateTime expiryDate, int price, int typeId)
        {
            Supplement supplement = SupplementFactory.Create(name, expiryDate, price, typeId);
            SupplementRepository.Insert(supplement);

            return new Response<Supplement>()
            {
                Success = true,
                Message = "Successfully inserted the supplement.",
                Payload = supplement
            };
        }

        public static Response<Supplement> Update(int id, string name, DateTime expiryDate, int price, int typeId)
        {
            Supplement supplement = SupplementRepository.Update(id, name, expiryDate, price, typeId);
            bool isNull = supplement is null;

            return new Response<Supplement>()
            {
                Success = !isNull,
                Message = isNull ? "Supplement not found" : "Successfully updated the supplement.",
                Payload = !isNull ? supplement : null
            };
        }

        public static Response<Supplement> Delete(int id)
        {
            CartRepository.ClearBySupplement(id);
            TransactionDetailRepository.ClearBySupplement(id);

            bool success = SupplementRepository.Delete(id);

            return new Response<Supplement>()
            {
                Success = success,
                Message = success ? "Successfully deleted the supplement." : "Supplement not found",
                Payload = null
            };
        }

        public static Response<Supplement> AddToCart(int userId, int supplementId, int quantity)
        {
            User user = UserRepository.Get(userId);
            Supplement supplement = SupplementRepository.Get(supplementId);
            bool isNull = user is null || supplement is null;

            if (isNull)
            {
                return new Response<Supplement>()
                {
                    Success = false,
                    Message = "User or supplement not found",
                    Payload = null
                };
            }

            Cart cart = CartFactory.Create(userId, supplementId, quantity);
            CartRepository.Insert(cart);

            return new Response<Supplement>()
            {
                Success = true,
                Message = "Successfully added the supplement to the user's cart.",
                Payload = supplement
            };
        }
        #endregion

    }

}