using System;
using System.Collections.Generic;
using PetShop.Core.Models;

namespace PetShop.DataAccessLayer
{
    public class FakeDB : IFakeDB
    {
        private static List<Pet> _fakeDbPets = new List<Pet>();
        private static List<PetType> _fakeDbPetTypes = new List<PetType>();
        private static int _id = 1;

        public Pet AddPet(Pet pet)
        {
            pet.Id = _id++;
            return pet;
        }

        public int DeletePet(int id)
        {
            throw new System.NotImplementedException();
        }

        public PetType AddPetType(PetType petType)
        {
            petType.Id = _id++;
            return petType;
        }

        public int DeletePetType(int id)
        {
            throw new System.NotImplementedException();
        }

    }
}