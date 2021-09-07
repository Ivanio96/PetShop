using PetShop.Core.Models;
using PetShop.DataAccessLayer;

namespace PetShop.BusinessLogic
{
    public class PetTypeManager
    {
        private readonly IFakeDB _fakeDb;

        public PetTypeManager()
        {
            _fakeDb = new FakeDB();
        }

        public PetType Create(PetType petType)
        {
            return _fakeDb.AddPetType(petType);
        }
    }
}