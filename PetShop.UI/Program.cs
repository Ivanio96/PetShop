using PetShop.Core.IServices;
using PetShop.Domain.IReposteries;
using PetShop.Domain.Services;
using PetShop.Infrastructure.DataAccess.Reposteries;

namespace PetShop.UI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IPetRepostery repo = new PetReposteryInMemory();
            IPetService service = new PetService(repo);

            var menu = new Menu(service);
            menu.Start();
        }
    }
}