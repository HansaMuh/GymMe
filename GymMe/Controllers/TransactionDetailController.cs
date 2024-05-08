using GymMe.Handlers;
using GymMe.Models;
using GymMe.Modules;
using System.Collections.Generic;

namespace GymMe.Controllers
{

    public class TransactionDetailController
    {

        #region Methods: Interface
        public static Response<List<TransactionDetail>> GetAll()
        {
            return TransactionDetailHandler.GetAll();
        }

        public static Response<List<TransactionDetail>> GetAll(int id)
        {
            return TransactionDetailHandler.GetAll(id);
        }

        public static Response<TransactionHeader> Get(int id)
        {
            return TransactionHeaderHandler.Get(id);
        }
        #endregion

    }

}