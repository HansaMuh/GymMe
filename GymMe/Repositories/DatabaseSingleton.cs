using GymMe.Models;

namespace GymMe.Repositories
{

    public class DatabaseSingleton
    {

        protected internal static DatabaseEntities Instance
        {
            get;
            set;
        } = new DatabaseEntities();

    }

}