using Drivers.Domain.Drivers;
using Drivers.Infra;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Drivers.Repositories
{
	public class DriverRepository : IDriverRepository
	{
		private readonly DriversDBContext _driverDbContext;

		public DriverRepository(DriversDBContext driverDbContext)
		{
			_driverDbContext = driverDbContext;
		}

		public async Task<List<Driver>> GetAllDrivers()
		{
			return await _driverDbContext.Drivers.ToListAsync();
		}
	}
}
