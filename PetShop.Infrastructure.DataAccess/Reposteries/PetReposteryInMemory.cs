using System.Collections.Generic;
using System.Linq;
using PetShop.Core.Models;
using PetShop.DataAccessLayer;
using PetShop.Domain.IReposteries;

namespace PetShop.Infrastructure.DataAccess.Reposteries
{
    public class PetReposteryInMemory : IPetRepostery
    {
        private int _id = FakeDB._fakeDbPets.Count;
        
        public Pet Create(Pet pet)
        {
            pet.Id = ++_id;
            FakeDB._fakeDbPets.Add(pet);
            return pet;
        }

        public List<Pet> ReadAll()
        {
            return FakeDB._fakeDbPets;
        }

        public Pet Update(Pet pet)
        {
            var updatePet = FakeDB._fakeDbPets.Find(p => p.Id == pet.Id);
            if (updatePet != null)
            {
                updatePet.Name = pet.Name;
                updatePet.BirthDate = pet.BirthDate;
                updatePet.Color = pet.Color;
                updatePet.Price = pet.Price;
                updatePet.Type = pet.Type;
                updatePet.SoldTime = pet.SoldTime;
            }

            return updatePet;
        }

        public bool Delete(string s)
        {
            Pet pet;
            pet = int.TryParse(s, out var id)
                ? FakeDB._fakeDbPets.Find(p => p.Id == id)
                : FakeDB._fakeDbPets.Find(p => p.Name.ToLower() == s.ToLower());
            
            return FakeDB._fakeDbPets.Remove(pet);
        }

        public Pet GetById(int id)
        {
            return FakeDB._fakeDbPets.Find(p => p.Id == id);
        }
    }
}