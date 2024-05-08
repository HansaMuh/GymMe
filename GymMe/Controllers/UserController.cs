using GymMe.Enumerations;
using GymMe.Handlers;
using GymMe.Models;
using GymMe.Modules;
using GymMe.Repositories;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GymMe.Controllers
{

    public class UserController
    {

        #region Methods: Interface
        public static Response<List<User>> GetAll()
        {
            return UserHandler.GetAll();
        }

        public static Response<User> Get(int id)
        {
            return UserHandler.Get(id);
        }

        public static Response<User> Authenticate(string name, string pass)
        {
            string errorMessage = ValidateAuthentication(name, pass);

            if (errorMessage.Length > 0)
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = errorMessage,
                    Payload = null
                };
            }
            else
            {
                return UserHandler.Get(name, pass);
            }
        }

        public static Response<User> Register(string name, string email, string gender, string pass, string confirmPass, DateTime dob)
        {
            string errorMessage = ValidateRegistration(name, email, gender, pass, confirmPass, dob);

            if (errorMessage.Length > 0)
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = errorMessage,
                    Payload = null
                };
            }
            else
            {
                return UserHandler.Insert(name, pass, email, dob, gender, UserRoleType.Customer.ToString());
            }
        }

        public static Response<User> UpdateProfile(int id, string name, string email, string gender, DateTime dob)
        {
            string errorMessage = ValidateProfile(id, name, email, gender, dob);

            if (errorMessage.Length > 0)
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = errorMessage,
                    Payload = null
                };
            }
            else
            {
                return UserHandler.Update(id, name, email, dob, gender);
            }
        }

        public static Response<User> UpdatePassword(int id, string pass, string newPass)
        {
            string errorMessage = ValidatePassword(id, pass, newPass);

            if (errorMessage.Length > 0)
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = errorMessage,
                    Payload = null
                };
            }
            else
            {
                return UserHandler.UpdatePassword(id, newPass);
            }
        }
        #endregion

        #region Methods: Validation
        private static string ValidateAuthentication(string name, string pass)
        {
            string errorMessage = string.Empty;
            if (string.IsNullOrEmpty(name))
            {
                errorMessage += "- Invalid username.\r\n";
            }
            if (string.IsNullOrEmpty(pass))
            {
                errorMessage += "- Invalid password.\r\n";
            }

            return errorMessage;
        }

        private static string ValidateRegistration(string name, string email, string gender, string pass, string confirmPass, DateTime dob)
        {
            string errorMessage = string.Empty;
            if (!Regex.IsMatch(name, "^[a-zA-Z ]{5,15}$"))
            {
                errorMessage += "- Username's length must be between 5 and 15 characters, containing only alphabets and spaces.\r\n";
            }
            if (!email.EndsWith(".com") || string.IsNullOrEmpty(email))
            {
                errorMessage += "- Email must end with \'.com\' and cannot be empty.\r\n";
            }
            if (string.IsNullOrEmpty(gender))
            {
                errorMessage += "- Gender must be chosen and cannot be empty.\r\n";
            }
            if (!Regex.IsMatch(pass, "^(?=.*[a-zA-Z])(?=.*[0-9])[a-zA-Z0-9]{1,}$") || string.IsNullOrEmpty(pass))
            {
                errorMessage += "- Password must be alphanumeric and cannot be empty.\r\n";
            }
            if (string.IsNullOrEmpty(confirmPass))
            {
                errorMessage += "- Confirm password cannot be empty.\r\n";
            }
            if (!pass.Equals(confirmPass))
            {
                errorMessage += "- Passwords do not match.\r\n";
            }
            if (dob == null)
            {
                errorMessage += "- Date of birth cannot be empty.\r\n";
            }

            return errorMessage;
        }

        private static string ValidateProfile(int id, string name, string email, string gender, DateTime dob)
        {
            string errorMessage = string.Empty;
            if (!Regex.IsMatch(name, "^[a-zA-Z ]{5,15}$"))
            {
                errorMessage += "- Username's length must be between 5 and 15 characters, containing only alphabets and spaces.\r\n";
            }
            if (!email.EndsWith(".com") || string.IsNullOrEmpty(email))
            {
                errorMessage += "- Email must end with \'.com\' and cannot be empty.\r\n";
            }
            if (string.IsNullOrEmpty(gender))
            {
                errorMessage += "- Gender must be chosen and cannot be empty.\r\n";
            }
            if (dob == null)
            {
                errorMessage += "- Date of birth cannot be empty.\r\n";
            }

            return errorMessage;
        }

        private static string ValidatePassword(int id, string pass, string newPass)
        {
            User user = UserHandler.Get(id).Payload;

            string errorMessage = string.Empty;
            if (!user.UserPass.Equals(pass) || string.IsNullOrEmpty(pass))
            {
                errorMessage += "- Old password must be the same as the current one and cannot be empty.\r\n";
            }
            if (!Regex.IsMatch(newPass, "^(?=.*[a-zA-Z])(?=.*[0-9])[a-zA-Z0-9]{1,}$") || string.IsNullOrEmpty(newPass))
            {
                errorMessage += "- New password must be alphanumeric and cannot be empty.\r\n";
            }

            return errorMessage;
        }
        #endregion

    }

}