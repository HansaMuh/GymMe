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
            TransactionHeader user = TransactionHeaderFactory.Create(GenerateID(), userId, transactionDate, status);

            return new Response<TransactionHeader>()
            {
                Success = true,
                Message = "Successfully created the transaction header.",
                Payload = user
            };
        }

        public static Response<TransactionHeader> Update(int id, int userId, DateTime transactionDate, string status)
        {
            TransactionHeader transactionHeader = TransactionHeaderRepository.Update(id, userId, transactionDate, status);
            bool isNull = transactionHeader is null;

            return new Response<TransactionHeader>()
            {
                Success = !isNull,
                Message = isNull ? "Transaction header not found" : "Successfully updated the transaction header.",
                Payload = !isNull ? transactionHeader : null
            };
        }
        #endregion

        #region Methods: Utility
        private static int GenerateID()
        {
            return TransactionHeaderRepository.GetAll().Count + 1;
        }
        #endregion

    }

}