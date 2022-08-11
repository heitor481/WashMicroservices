using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WashClothes.Domain;
using WashClothes.Infra;
using System.Linq;

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

        public async Task<Clothes> GetClotheById(int clotheId)
        {
			return await _cothesDBContext.Clothes.FirstOrDefaultAsync(x => x.Id == clotheId);
        }

        public async Task<List<Clothes>> GetClothesByUser(int userId)
        {
			return await _cothesDBContext.Clothes
				.Where(c => c.UserId == userId).ToListAsync();
        }

		
    }
}
