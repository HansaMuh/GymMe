using GymMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GymMe.Repositories
{

    public class SupplementTypeRepository
    {

        private static DatabaseEntities Database
        {
            get => DatabaseSingleton.Instance;
        }

        public static List<SupplementType> GetAll()
        {
            return Database.SupplementTypes.ToList();
        }

        public static SupplementType Get(int id)
        {
            return Database.SupplementTypes.FirstOrDefault(s => s.SupplementTypeID == id);
        }

        public static SupplementType Get(string name)
        {
            return Database.SupplementTypes.FirstOrDefault(s => s.SupplementTypeName.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public static void Insert(SupplementType supplementType)
        {
            Database.SupplementTypes.Add(supplementType);
            Database.SaveChanges();
        }

    }

}