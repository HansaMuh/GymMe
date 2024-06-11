using GymMe.Factories;
using GymMe.Models;
using GymMe.Modules;
using GymMe.Repositories;
using System;
using System.Collections.Generic;

namespace GymMe.Handlers
{

    public class UserHandler
    {

        #region Methods: CRUD
        public static Response<List<User>> GetAll()
        {
            List<User> users = UserRepository.GetAll();
            bool isEmpty = users.Count == 0;

            return new Response<List<User>>()
            {
                Success = !isEmpty,
                Message = isEmpty ? "No users found" : "Users found",
                Payload = users
            };
        }

        public static Response<List<User>> GetAllCustomers()
        {
            List<User> users = UserRepository.GetAllCustomers();
            bool isEmpty = users.Count == 0;

            return new Response<List<User>>()
            {
                Success = !isEmpty,
                Message = isEmpty ? "No customers found" : "Customers found",
                Payload = users
            };
        }

        public static Response<List<User>> GetRole(string role)
        {
            List<User> users = UserRepository.GetRole(role);
            bool isEmpty = users.Count == 0;

            return new Response<List<User>>()
            {
                Success = !isEmpty,
                Message = isEmpty ? "There is no Users" : "",
                Payload = users
            };
        }

        public static Response<User> Get(int id)
        {
            User user = UserRepository.Get(id);
            bool isNull = user is null;

            return new Response<User>()
            {
                Success = !isNull,
                Message = isNull ? "Invalid ID" : "User found",
                Payload = user
            };
        }

        public static Response<User> Get(string name)
        {
            User user = UserRepository.Get(name);
            bool isNull = user is null;

            return new Response<User>()
            {
                Success = !isNull,
                Message = isNull ? "Invalid name" : "User found",
                Payload = user
            };
        }

        public static Response<User> Get(string name, string pass)
        {
            User user = UserRepository.Get(name, pass);
            bool isNull = user is null;

            return new Response<User>()
            {
                Success = !isNull,
                Message = isNull ? "Invalid name or password" : "User found",
                Payload = user
            };
        }

        public static Response<User> Create(string name, string pass, string email, DateTime dob, string gender, string role)
        {
            User user = UserFactory.Create(name, pass, email, dob, gender, role);

            return new Response<User>()
            {
                Success = true,
                Message = "Successfully created the user.",
                Payload = user
            };
        }

        public static Response<User> Insert(string name, string pass, string email, DateTime dob, string gender, string role)
        {
            if (UserRepository.Get(name) != null)
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = "User already exists",
                    Payload = null
                };
            }

            User user = UserFactory.Create(name, pass, email, dob, gender, role);
            UserRepository.Insert(user);

            return new Response<User>()
            {
                Success = true,
                Message = "Successfully inserted the user.",
                Payload = user
            };
        }

        public static Response<User> Update(int id, string name, string email, DateTime dob, string gender)
        {
            User user = UserRepository.Update(id, name, email, dob, gender);
            bool isNull = user is null;

            return new Response<User>()
            {
                Success = !isNull,
                Message = isNull ? "User not found" : "Successfully updated the user.",
                Payload = !isNull ? user : null
            };
        }

        public static Response<User> UpdatePassword(int id, string pass)
        {
            User user = UserRepository.UpdatePassword(id, pass);
            bool isNull = user is null;

            return new Response<User>()
            {
                Success = !isNull,
                Message = isNull ? "User not found" : "Successfully updated the user's password.",
                Payload = !isNull ? user : null
            };
        }
        #endregion

    }

}