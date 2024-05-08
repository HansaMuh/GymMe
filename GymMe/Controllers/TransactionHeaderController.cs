using GymMe.Handlers;
using GymMe.Models;
using GymMe.Modules;
using System.Collections.Generic;

namespace GymMe.Controllers
{

    public class TransactionHeaderController
    {

        #region Methods: Interface
        public static Response<List<TransactionHeader>> GetAll()
        {
            return TransactionHeaderHandler.GetAll();
        }

        public static Response<List<TransactionHeader>> GetAllUnhandled()
        {
            return TransactionHeaderHandler.GetAllUnhandled();
        }

        public static Response<List<TransactionHeader>> GetAllHandled()
        {
            return TransactionHeaderHandler.GetAllHandled();
        }

        public static Response<TransactionHeader> Get(int id)
        {
            return TransactionHeaderHandler.Get(id);
        }

        public static Response<TransactionHeader> HandleTransaction(int id, string status)
        {
            return TransactionHeaderHandler.UpdateStatus(id, status);
        }

        public static Response<TransactionHeader> Checkout(int userId)
        {
            return TransactionHeaderHandler.Checkout(userId);
        }
        #endregion

    }

}