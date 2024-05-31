using GymMe.Controllers;
using GymMe.Models;
using GymMe.Modules;
using System.Web;

namespace GymMe.Utility
{

    public class SessionManager
    {

        public static User GetCurrentUser()
        {
            var userId = HttpContext.Current.Session["UserId"];

            if (userId != null)
            {
                Response<User> response = UserController.Get((int)userId);
                if (response.Success) 
                {
                    return response.Payload;
                }
            }

            return null;
        }

        public static void SaveCurrentUser(User user)
        {
            HttpContext.Current.Session["UserId"] = user.UserID;
        }

    }

}