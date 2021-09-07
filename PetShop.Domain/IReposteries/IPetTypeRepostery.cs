using System.Collections.Generic;
using PetShop.Core.Models;

namespace PetShop.Domain.IReposteries
{
    public interface IPetTypeRepostery
    {
        PetType Add(PetType petType);

        List<PetType> FindAll();
    }
}