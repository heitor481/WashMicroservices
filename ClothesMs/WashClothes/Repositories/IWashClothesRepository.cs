using System.Collections.Generic;
using System.Threading.Tasks;
using WashClothes.Domain;

namespace WashClothes.Repositories
{
    public interface IWashClothesRepository
	{
		Task<List<Clothes>> GetAllClothesAvailables();

		Task<List<Clothes>> GetClothesByUser(int userId);

		Task<User> GetUser(int userId);

		Task<Clothes> GetClotheById(int clotheId);
	}
}
