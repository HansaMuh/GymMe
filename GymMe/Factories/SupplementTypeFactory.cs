using GymMe.Models;

namespace GymMe.Factories
{

    public class SupplementTypeFactory
    {

        public static SupplementType Create(int id, string name)
        {
            return new SupplementType()
            {
                SupplementTypeID = id,
                SupplementTypeName = name
            };
        }

    }

}