using GymMe.Models;
using System;
using System.Collections.Generic;
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

        public static User Get(int id)
        {
            return Database.Users.FirstOrDefault(u => u.UserID == id);
        }

        public static User Get(string email)
        {
            return Database.Users.FirstOrDefault(u => u.UserEmail.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public static void Insert(User user)
        {
            Database.Users.Add(user);
            Database.SaveChanges();
        }

        public static User Update(int id, string name, string email, DateTime dob, string gender, string role)
        {
            User user = Get(id);

            if (user != null)
            {
                user.UserName = name;
                user.UserEmail = email;
                user.UserDOB = dob;
                user.UserGender = gender;
                user.UserRole = role;
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