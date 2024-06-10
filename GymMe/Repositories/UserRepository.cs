using GymMe.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GymMe.Repositories
{

    public class UserRepository
    {

        private static DatabaseEntities Database
        {
            get => DatabaseSingleton.Instance;
        }

        public static List<User> GetAll()
        {
            return Database.Users.ToList();
        }

        public static List<User> GetAllCustomers()
        {
            return Database.Users.Where(u => u.UserRole.Equals("Customer")).ToList();
        }

        public static User Get(int id)
        {
            return Database.Users.FirstOrDefault(u => u.UserID == id);
        }

        public static User Get(string name)
        {
            return Database.Users.FirstOrDefault(u => u.UserName.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public static User Get(string name, string pass)
        {
            return Database.Users.FirstOrDefault(u => u.UserName.Equals(name, StringComparison.OrdinalIgnoreCase) && u.UserPass.Equals(pass));
        }

        public static void Insert(User user)
        {
            Database.Users.Add(user);
            Database.SaveChanges();
        }

        public static User Update(int id, string name, string email, DateTime dob, string gender)
        {
            User user = Get(id);

            if (user != null)
            {
                user.UserName = name;
                user.UserEmail = email;
                user.UserDOB = dob;
                user.UserGender = gender;

                Database.Entry(user).State = EntityState.Modified;
                Database.SaveChanges();
                
                return user;
            }
            else
            {
                return null;
            }
        }

        public static User UpdatePassword(int id, string pass)
        {
            User user = Get(id);

            if (user != null)
            {
                user.UserPass = pass;
                Database.SaveChanges();

                return user;
            }
            else
            {
                return null;
            }
        }

    }

}