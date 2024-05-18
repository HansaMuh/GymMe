using GymMe.Enumerations;
using GymMe.Factories;
using GymMe.Models;
using GymMe.Modules;
using GymMe.Repositories;
using System;
using System.Collections.Generic;

namespace GymMe.Handlers
{

    public class TransactionHeaderHandler
    {

        #region Methods: CRUD
        public static Response<List<TransactionHeader>> GetAll()
        {
            List<TransactionHeader> transactionHeaders = TransactionHeaderRepository.GetAll();
            bool isEmpty = transactionHeaders.Count == 0;

            return new Response<List<TransactionHeader>>()
            {
                Success = !isEmpty,
                Message = isEmpty ? "No transaction headers found" : "Transaction headers found",
                Payload = transactionHeaders
            };
        }

        public static Response<List<TransactionHeader>> GetAllUnhandled()
        {
            List<TransactionHeader> transactionHeaders = TransactionHeaderRepository.GetAllUnhandled();
            bool isEmpty = transactionHeaders.Count == 0;

            return new Response<List<TransactionHeader>>()
            {
                Success = !isEmpty,
                Message = isEmpty ? "No unhandled transaction headers found" : "Unhandled transaction headers found",
                Payload = transactionHeaders
            };
        }

        public static Response<List<TransactionHeader>> GetAllHandled()
        {
            List<TransactionHeader> transactionHeaders = TransactionHeaderRepository.GetAllHandled();
            bool isEmpty = transactionHeaders.Count == 0;

            return new Response<List<TransactionHeader>>()
            {
                Success = !isEmpty,
                Message = isEmpty ? "No handled transaction headers found" : "Handled transaction headers found",
                Payload = transactionHeaders
            };
        }

        public static Response<TransactionHeader> Get(int id)
        {
            TransactionHeader transactionHeader = TransactionHeaderRepository.Get(id);
            bool isNull = transactionHeader is null;

            return new Response<TransactionHeader>()
            {
                Success = !isNull,
                Message = isNull ? "Transaction header not found" : "Transaction header found",
                Payload = transactionHeader
            };
        }

        public static Response<TransactionHeader> Create(int userId, DateTime transactionDate, string status)
        {
            TransactionHeader transactionHeader = TransactionHeaderFactory.Create(userId, transactionDate, status);

            return new Response<TransactionHeader>()
            {
                Success = true,
                Message = "Successfully created the transaction header.",
                Payload = transactionHeader
            };
        }

        public static Response<TransactionHeader> Update(int id, int userId, DateTime transactionDate)
        {
            TransactionHeader transactionHeader = TransactionHeaderRepository.Update(id, userId, transactionDate);
            bool isNull = transactionHeader is null;

            return new Response<TransactionHeader>()
            {
                Success = !isNull,
                Message = isNull ? "Transaction header not found" : "Successfully updated the transaction header.",
                Payload = !isNull ? transactionHeader : null
            };
        }

        public static Response<TransactionHeader> UpdateStatus(int id, string status)
        {
            TransactionHeader transactionHeader = TransactionHeaderRepository.UpdateStatus(id, status);
            bool isNull = transactionHeader is null;

            return new Response<TransactionHeader>()
            {
                Success = !isNull,
                Message = isNull ? "Transaction header not found" : "Successfully updated the transaction header's status.",
                Payload = !isNull ? transactionHeader : null
            };
        }

        public static Response<TransactionHeader> Checkout(int userId)
        {
            User user = UserRepository.Get(userId);
            List<Cart> carts = CartRepository.GetAll(userId);
            bool isNull = user is null || carts.Count <= 0;

            if (isNull)
            {
                return new Response<TransactionHeader>()
                {
                    Success = false,
                    Message = "User or cart not found",
                    Payload = null
                };
            }

            TransactionHeader transactionHeader = TransactionHeaderFactory.Create(userId, DateTime.Now, OrderStatusType.Unhandled.ToString());
            TransactionHeaderRepository.Insert(transactionHeader);

            foreach (Cart cart in carts)
            {
                TransactionDetail transactionDetail = TransactionDetailFactory.Create(transactionHeader.TransactionID, cart.SupplementID, cart.Quantity);
                TransactionDetailRepository.Insert(transactionDetail);

                CartRepository.Delete(cart.CartID);
            }

            return new Response<TransactionHeader>()
            {
                Success = true,
                Message = "Successfully checked out for the transaction header.",
                Payload = transactionHeader
            };
        }
        #endregion

    }

}