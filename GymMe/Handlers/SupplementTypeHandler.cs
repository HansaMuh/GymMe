using GymMe.Factories;
using GymMe.Models;
using GymMe.Modules;
using GymMe.Repositories;
using System.Collections.Generic;

namespace GymMe.Handlers
{

    public class SupplementTypeHandler
    {

        #region Methods: CRUD
        public static Response<List<SupplementType>> GetAll()
        {
            List<SupplementType> supplementTypes = SupplementTypeRepository.GetAll();
            bool isEmpty = supplementTypes.Count == 0;

            return new Response<List<SupplementType>>()
            {
                Success = !isEmpty,
                Message = isEmpty ? "No supplement types found" : "Supplement types found",
                Payload = supplementTypes
            };
        }

        public static Response<SupplementType> Get(int id)
        {
            SupplementType supplementType = SupplementTypeRepository.Get(id);
            bool isNull = supplementType is null;

            return new Response<SupplementType>()
            {
                Success = !isNull,
                Message = isNull ? "Supplement type not found" : "Supplement type found",
                Payload = supplementType
            };
        }

        public static Response<SupplementType> Create(string name)
        {
            SupplementType supplementType = SupplementTypeFactory.Create(GenerateID(), name);

            return new Response<SupplementType>()
            {
                Success = true,
                Message = "Successfully created the supplement type.",
                Payload = supplementType
            };
        }
        #endregion

        #region Methods: Utility
        private static int GenerateID()
        {
            return SupplementTypeRepository.GetAll().Count + 1;
        }
        #endregion

    }

}