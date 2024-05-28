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

        public static Response<TransactionDetail> Get(int id)
        {
            return TransactionDetailHandler.Get(id);
        }

        public static Response<List<TransactionDetail>> ClearBySupplement(int supplementId)
        {
            return TransactionDetailHandler.ClearBySupplement(supplementId);
        }
        #endregion

    }

}