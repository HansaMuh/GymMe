﻿using GymMe.Factories;
using GymMe.Models;
using GymMe.Modules;
using GymMe.Repositories;
using System;
using System.Collections.Generic;

namespace GymMe.Handlers
{

    public class SupplementHandler
    {

        #region Methods: CRUD
        public static Response<List<Supplement>> GetAll()
        {
            List<Supplement> supplements = SupplementRepository.GetAll();
            bool isEmpty = supplements.Count == 0;

            return new Response<List<Supplement>>()
            {
                Success = !isEmpty,
                Message = isEmpty ? "No supplements found" : "Supplements found",
                Payload = supplements
            };
        }

        public static Response<Supplement> Get(int id)
        {
            Supplement supplement = SupplementRepository.Get(id);
            bool isNull = supplement is null;

            return new Response<Supplement>()
            {
                Success = !isNull,
                Message = isNull ? "Supplement not found" : "Supplement found",
                Payload = supplement
            };
        }

        public static Response<Supplement> Create(string name, DateTime expiryDate, int price, int typeId)
        {
            Supplement supplement = SupplementFactory.Create(GenerateID(), name, expiryDate, price, typeId);

            return new Response<Supplement>()
            {
                Success = true,
                Message = "Successfully created the supplement.",
                Payload = supplement
            };
        }

        public static Response<Supplement> Update(int id, string name, DateTime expiryDate, int price, int typeId)
        {
            Supplement supplement = SupplementRepository.Update(id, name, expiryDate, price, typeId);
            bool isNull = supplement is null;

            return new Response<Supplement>()
            {
                Success = !isNull,
                Message = isNull ? "Supplement not found" : "Successfully updated the supplement.",
                Payload = !isNull ? supplement : null
            };
        }

        public static Response<Supplement> Delete(int id)
        {
            bool success = SupplementRepository.Delete(id);

            return new Response<Supplement>()
            {
                Success = success,
                Message = success ? "Successfully deleted the supplement." : "Supplement not found",
                Payload = null
            };
        }
        #endregion

        #region Methods: Utility
        private static int GenerateID()
        {
            return SupplementRepository.GetAll().Count + 1;
        }
        #endregion

    }

}