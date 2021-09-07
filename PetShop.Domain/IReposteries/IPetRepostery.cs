using System.Collections.Generic;
using PetShop.Core.Models;


namespace PetShop.Domain.IReposteries
{
    public interface IPetRepostery
    {
        Pet Add(Pet pet);

        List<Pet> FindAll();
    }
}