using GymMe.Models;
using System;

namespace GymMe.Factories
{

    public class SupplementFactory
    {

        public static Supplement Create(string name, DateTime expiryDate, int price, int typeId)
        {
            return new Supplement()
            {
                SupplementName = name,
                SupplementExpiryDate = expiryDate,
                SupplementPrice = price,
                SupplementTypeID = typeId
            };
        }

    }

}