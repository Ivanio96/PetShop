using System.Collections.Generic;
using PetShop.Core.Models;

namespace PetShop.Core.IServices
{
    public interface IPetService
    {
        Pet Create(Pet pet);
        List<Pet> ReadAll();
        Pet Update(Pet pet);
        bool Delete(string s);
        List<Pet> SearchByType(PetType type);
        List<Pet> SortByPrice();
        List<Pet> GetCheapest();
        Pet GetById(int id);


    }
}