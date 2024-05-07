using GymMe.Models;
using System;

namespace GymMe.Factories
{

    public class SupplementFactory
    {

        public static Supplement Create(int id, string name, DateTime expiryDate, int price, int typeId)
        {
            return new Supplement()
            {
                SupplementID = id,
                SupplementName = name,
                SupplementExpiryDate = expiryDate,
                SupplementPrice = price,
                SupplementTypeID = typeId
            };
        }

    }

}