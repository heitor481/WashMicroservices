using Drivers.Domain.Drivers;
using Drivers.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Drivers.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DriversController : ControllerBase
	{
		private readonly IDriverRepository _driverRepository;

		public DriversController(IDriverRepository driverRepository)
		{
			_driverRepository = driverRepository;
		}

		// GET: api/<DriversController>
		[HttpGet]
		public async Task<IEnumerable<Driver>> Get()
		{
			return await _driverRepository.GetAllDrivers();
		}

		// GET api/<DriversController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}
	}
}
