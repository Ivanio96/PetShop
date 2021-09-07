using PetShop.Core.Models;
using PetShop.DataAccessLayer;

namespace PetShop.BusinessLogic
{
    public class PetManager
    {

        private readonly IFakeDB _fakeDb;

        public PetManager()
        {
            _fakeDb = new FakeDB();
        }

        public Pet Create(Pet pet)
        {
            return _fakeDb.AddPet(pet);
        }
        
        
    }
}