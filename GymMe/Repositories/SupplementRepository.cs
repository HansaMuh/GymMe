using GymMe.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GymMe.Repositories
{

    public class SupplementRepository
    {

        private static DatabaseEntities Database
        {
            get => DatabaseSingleton.Instance;
        }

        public static List<Supplement> GetAll()
        {
            return Database.Supplements.ToList();
        }

        public static Supplement Get(int id)
        {
            return Database.Supplements.FirstOrDefault(s => s.SupplementID == id);
        }

        public static Supplement Get(string name)
        {
            return Database.Supplements.FirstOrDefault(s => s.SupplementName.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public static void Insert(Supplement supplement)
        {
            Database.Supplements.Add(supplement);
            Database.SaveChanges();
        }

        public static Supplement Update(int id, string name, DateTime expiryDate, int price, int typeId)
        {
            Supplement supplement = Get(id);

            if (supplement != null)
            {
                supplement.SupplementName = name;
                supplement.SupplementExpiryDate = expiryDate;
                supplement.SupplementPrice = price;
                supplement.SupplementTypeID = typeId;

                Database.Entry(supplement).State = EntityState.Modified;
                Database.SaveChanges();

                return supplement;
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int id)
        {
            Supplement supplement = Get(id);

            if (supplement != null)
            {
                Database.Supplements.Remove(supplement);
                Database.SaveChanges();

                return true;
            }

            return false;
        }

    }

}