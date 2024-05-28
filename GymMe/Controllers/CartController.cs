using GymMe.Handlers;
using GymMe.Models;
using GymMe.Modules;
using System.Collections.Generic;

namespace GymMe.Controllers
{

    public class CartController
    {

        #region Methods: Interface
        public static Response<List<Cart>> GetAll()
        {
            return CartHandler.GetAll();
        }

        public static Response<List<Cart>> GetAll(int userId)
        {
            return CartHandler.GetAll(userId);
        }

        public static Response<List<Cart>> Clear(int userId)
        {
            return CartHandler.Clear(userId);
        }

        public static Response<List<Cart>> ClearBySupplement(int supplementId)
        {
            return CartHandler.ClearBySupplement(supplementId);
        }
        #endregion

    }

}