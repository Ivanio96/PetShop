using System.Collections.Generic;
using PetShop.Core.IServices;
using PetShop.Core.Models;
using PetShop.Domain.IReposteries;

namespace PetShop.Domain.Services
{
    public class PetService : IPetService
    {
        private IPetRepostery _repo;

        public PetService(IPetRepostery repo)
        {
            _repo = repo;
        }

        public Pet Create(Pet pet)
        {
            return _repo.Add(pet);
        }

        public List<Pet> ReadAll()
        {
            return _repo.FindAll();
        }
    }
}