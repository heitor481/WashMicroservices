using Microsoft.AspNetCore.Mvc;
using Providers.Repositories.HttpRequest;
using Providers.Repositories.HttpRequest.Dto;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Providers.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DriverIntegrationController : ControllerBase
	{
		private readonly IDriverHttpClient _driverHttpClient;

		public DriverIntegrationController(IDriverHttpClient driverHttpClient)
		{
			_driverHttpClient = driverHttpClient;
		}

		// GET: api/<DriverIntegrationController>
		[HttpGet]
		public async Task<Driver> Get()
		{
			var drivers = await _driverHttpClient.GetDriver();

			if (drivers == null || drivers.Count <= 0)
			{
				return null;
			}

			return drivers.FirstOrDefault();
		}

		// GET api/<DriverIntegrationController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}
	}
}
