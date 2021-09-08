using System.Collections.Generic;
using PetShop.Core.Models;


namespace PetShop.Domain.IReposteries
{
    public interface IPetRepostery
    {
        Pet Create(Pet pet);
        List<Pet> ReadAll();
        Pet Update(Pet pet);
        bool Delete(string s);
        Pet GetById(int id);
    }
}