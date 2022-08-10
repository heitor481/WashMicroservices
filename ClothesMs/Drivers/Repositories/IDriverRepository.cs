using Drivers.Domain.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drivers.Repositories
{
	public interface IDriverRepository
	{
		Task<List<Driver>> GetAllDrivers();

	}
}
