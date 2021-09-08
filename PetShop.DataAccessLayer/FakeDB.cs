using System;
using System.Collections.Generic;
using PetShop.Core.Models;

namespace PetShop.DataAccessLayer
{
    public class FakeDB : IFakeDB
    {
        public static List<Pet> _fakeDbPets = new List<Pet>();
        private static List<PetType> _fakeDbPetTypes = new List<PetType>();
        private static int _id = 1;

        public static void InitData()
        {
            var typeDog = new PetType {Id = 1, Name = "Dog"};
            var typeCat = new PetType {Id = 2, Name = "Cat"};
            var typeGoat = new PetType {Id = 3, Name = "Goat"};
            
            _fakeDbPetTypes.Add(typeDog);
            _fakeDbPetTypes.Add(typeCat);
            _fakeDbPetTypes.Add(typeGoat);

            var pet1 = new Pet
            {
                Id = 1, Name = "Jeppe", BirthDate = new DateTime(2020, 7, 10), Color = "Black", Type = typeDog,
                Price = 250
            };
            var pet2 = new Pet
            {
                Id = 2, Name = "Petter", BirthDate = new DateTime(2019, 5, 18), Color = "Brown", Type = typeDog,
                Price = 500
            };
            var pet3 = new Pet
            {
                Id = 3, Name = "Garfield", BirthDate = new DateTime(2018, 10, 25), Color = "Orange", Type = typeCat,
                Price = 1000
            };
            var pet4 = new Pet
            {
                Id = 4, Name = "Messi", BirthDate = new DateTime(2019, 4, 20), Color = "Brown", Type = typeGoat,
                Price = 1500
            };
            _fakeDbPets.Add(pet1);
            _fakeDbPets.Add(pet2);
            _fakeDbPets.Add(pet3);
            _fakeDbPets.Add(pet4);
        }


        

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