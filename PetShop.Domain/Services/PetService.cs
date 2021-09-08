using System.Collections.Generic;
using System.Linq;
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
            return _repo.Create(pet);
        }

        public List<Pet> ReadAll()
        {
            return _repo.ReadAll();
        }

        public Pet Update(Pet pet)
        {
            return _repo.Update(pet);
        }

        public bool Delete(string s)
        {
            return _repo.Delete(s);
        }

        public List<Pet> SearchByType(PetType type)
        {
            return _repo.ReadAll().FindAll(p => p.Type == type);
        }

        public List<Pet> SortByPrice()
        {
            var list = _repo.ReadAll().OrderBy(p => p.Price).ToList();
            return list;
        }

        public List<Pet> GetCheapest()
        {
            var cheapest = new List<Pet>();
            for (var i = 0; SortByPrice().Count >= 5 ? i < 5: i < SortByPrice().Count; i++)
            {
                cheapest.Add(SortByPrice()[i]);
            }

            return cheapest;
        }

        public Pet GetById(int id)
        {
            return _repo.GetById(id);
        }

    }
}