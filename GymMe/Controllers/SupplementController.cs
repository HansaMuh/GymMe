using GymMe.Handlers;
using GymMe.Models;
using GymMe.Modules;
using System;
using System.Collections.Generic;

namespace GymMe.Controllers
{

    public class SupplementController
    {

        #region Methods: Interface
        public static Response<List<Supplement>> GetAll()
        {
            return SupplementHandler.GetAll();
        }

        public static Response<Supplement> Get(int id)
        {
            return SupplementHandler.Get(id);
        }

        public static Response<Supplement> Order(int userId, int supplementId, int quantity)
        {
            string errorMessage = ValidateOrder(quantity);

            if (errorMessage.Length > 0)
            {
                return new Response<Supplement>()
                {
                    Success = false,
                    Message = errorMessage,
                    Payload = null
                };
            }
            else
            {
                return SupplementHandler.AddToCart(userId, supplementId, quantity);
            }
        }

        public static Response<Supplement> Insert(string name, DateTime expiryDate, int price, int typeId)
        {
            string errorMessage = ValidateSupplementData(name, expiryDate, price, typeId);

            if (errorMessage.Length > 0)
            {
                return new Response<Supplement>()
                {
                    Success = false,
                    Message = errorMessage,
                    Payload = null
                };
            }
            else
            {
                return SupplementHandler.Insert(name, expiryDate, price, typeId);
            }
        }

        public static Response<Supplement> Update(int id, string name, DateTime expiryDate, int price, int typeId)
        {
            string errorMessage = ValidateSupplementData(name, expiryDate, price, typeId);

            if (errorMessage.Length > 0)
            {
                return new Response<Supplement>()
                {
                    Success = false,
                    Message = errorMessage,
                    Payload = null
                };
            }
            else
            {
                return SupplementHandler.Update(id, name, expiryDate, price, typeId);
            }
        }

        public static Response<Supplement> Delete(int id)
        {
            return SupplementHandler.Delete(id);
        }
        #endregion

        #region Methods: Validation
        private static string ValidateOrder(int quantity)
        {
            string errorMessage = string.Empty;
            if (quantity <= 0)
            {
                errorMessage += "- Invalid quantity.\r\n";
            }

            return errorMessage;
        }

        private static string ValidateSupplementData(string name, DateTime expiryDate, int price, int typeId)
        {
            string errorMessage = string.Empty;
            if (!name.Contains("Supplement") || string.IsNullOrEmpty(name))
            {
                errorMessage += "- Name must contain \'Supplement\' and cannot be empty.\r\n";
            }
            if (expiryDate <= DateTime.Now || expiryDate == null)
            {
                errorMessage += "- Expiry date must be greater than today's date and cannot be empty.\r\n";
            }
            if (price <= 0 || price < 3000)
            {
                errorMessage += "- Price must be at least 3000 and cannot be empty.\r\n";
            }
            if (typeId <= 0)
            {
                errorMessage += "- Type ID cannot be empty.\r\n";
            }

            return errorMessage;
        }
        #endregion

    }

}