using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WashClothes.Domain;
using WashClothes.Infra;

namespace WashClothes.Repositories
{
	public class WashClothesRepository : IWashClothesRepository
	{
		private readonly CothesDBContext _cothesDBContext;

		public WashClothesRepository(CothesDBContext cothesDBContext)
		{
			_cothesDBContext = cothesDBContext;
		}

		public async Task<List<Clothes>> GetAllClothesAvailables()
		{
			return await _cothesDBContext.Clothes.ToListAsync();
		}
	}
}
