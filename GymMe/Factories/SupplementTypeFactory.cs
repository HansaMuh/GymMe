using GymMe.Models;

namespace GymMe.Factories
{

    public class SupplementTypeFactory
    {

        public static SupplementType Create(string name)
        {
            return new SupplementType()
            {
                SupplementTypeName = name
            };
        }

    }

}