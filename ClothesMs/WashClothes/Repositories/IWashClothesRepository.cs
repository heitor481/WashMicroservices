using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WashClothes.Domain;

namespace WashClothes.Repositories
{
	public interface IWashClothesRepository
	{
		Task<List<Clothes>> GetAllClothesAvailables();

		Task<List<Clothes>> GetClothesByUser(int userId);
	}
}
