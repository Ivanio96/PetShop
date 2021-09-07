using System.Collections.Generic;
using PetShop.Core.Models;

namespace PetShop.Core.IServices
{
    public interface IPetService
    {
        Pet Create(Pet pet);

        List<Pet> ReadAll();
    }
}