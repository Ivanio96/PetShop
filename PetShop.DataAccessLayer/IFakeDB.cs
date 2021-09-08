using PetShop.Core.Models;

namespace PetShop.DataAccessLayer
{
    public interface IFakeDB
    {
        public Pet AddPet(Pet pet);

        public int DeletePet(int id);

        public PetType AddPetType(PetType petType);

        public int DeletePetType(int id);
    }
}