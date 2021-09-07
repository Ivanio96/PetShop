using System.Collections.Generic;
using PetShop.Core.Models;
using PetShop.Domain.IReposteries;

namespace PetShop.Infrastructure.DataAccess.Reposteries
{
    public class PetReposteryInMemory : IPetRepostery
    {
        private static List<Pet> _petTable = new List<Pet>();
        private static int _id = 1;

        public Pet Add(Pet pet)
        {
            pet.Id = _id++;
            _petTable.Add(pet);
            return pet;
        }

        public List<Pet> FindAll()
        {
            return _petTable;
        }









    }
}