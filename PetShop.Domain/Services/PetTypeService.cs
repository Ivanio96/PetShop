using System.Collections.Generic;
using PetShop.Core.Models;
using PetShop.Domain.IReposteries;

namespace PetShop.Domain.Services
{
    public class PetTypeService : IPetTypeRepostery
    {
        private IPetTypeRepostery _repo;

        public PetTypeService(IPetTypeRepostery repo)
        {
            _repo = repo;
        }

        public PetType Add(PetType petType)
        {
            return _repo.Add(petType);
        }

        public List<PetType> FindAll()
        {
            return _repo.FindAll();
        }


    }
}