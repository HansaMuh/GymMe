using GymMe.Factories;
using GymMe.Models;
using GymMe.Modules;
using GymMe.Repositories;
using System.Collections.Generic;

namespace GymMe.Handlers
{

    public class TransactionDetailHandler
    {

        #region Methods: CRUD
        public static Response<List<TransactionDetail>> GetAll()
        {
            List<TransactionDetail> transactionDetails = TransactionDetailRepository.GetAll();
            bool isEmpty = transactionDetails.Count == 0;

            return new Response<List<TransactionDetail>>()
            {
                Success = !isEmpty,
                Message = isEmpty ? "No transaction details found" : "Transaction details found",
                Payload = transactionDetails
            };
        }

        public static Response<List<TransactionDetail>> GetAll(int id)
        {
            List<TransactionDetail> transactionDetails = TransactionDetailRepository.GetAll(id);
            bool isEmpty = transactionDetails.Count == 0;

            return new Response<List<TransactionDetail>>()
            {
                Success = !isEmpty,
                Message = isEmpty ? "No transaction details found" : "Transaction details found for the selected header",
                Payload = transactionDetails
            };
        }

        public static Response<TransactionDetail> Get(int id)
        {
            TransactionDetail transactionDetail = TransactionDetailRepository.Get(id);
            bool isNull = transactionDetail is null;

            return new Response<TransactionDetail>()
            {
                Success = !isNull,
                Message = isNull ? "Transaction detail not found" : "Transaction detail found",
                Payload = transactionDetail
            };
        }

        public static Response<TransactionDetail> Create(int transactionId, int supplementId, int quantity)
        {
            TransactionDetail transactionDetail = TransactionDetailFactory.Create(transactionId, supplementId, quantity);

            return new Response<TransactionDetail>()
            {
                Success = true,
                Message = "Successfully created the transaction detail.",
                Payload = transactionDetail
            };
        }
        #endregion

    }

}