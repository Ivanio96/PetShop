using System.Collections.Generic;
using PetShop.Core.Models;


namespace PetShop.Core.IServices
{
    public interface IPetTypeService
    {
        PetType Create(PetType petType);

        List<PetType> ReadAll();
    }
}