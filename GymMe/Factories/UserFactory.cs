using GymMe.Models;
using System;

namespace GymMe.Factories
{

    public class UserFactory
    {

        public static User Create(string name, string pass, string email, DateTime dob, string gender, string role)
        {
            return new User()
            {
                UserName = name,
                UserPass = pass,
                UserEmail = email,
                UserDOB = dob,
                UserGender = gender,
                UserRole = role
            };
        }

    }

}