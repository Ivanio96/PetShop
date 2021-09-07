using PetShop.Core.Models;

namespace PetShop.DataAccessLayer
{
    public interface IFakeDB
    {
        Pet AddPet(Pet pet);

        int DeletePet(int id);

        PetType AddPetType(PetType petType);

        int DeletePetType(int id);
    }
}