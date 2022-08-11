using Microsoft.AspNetCore.Mvc;
using Providers.Domain;
using Providers.Repositories;
using Providers.Repositories.HttpRequest;
using Providers.Repositories.HttpRequest.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Providers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvidersController : ControllerBase
    {
        private readonly IProvidersRepository _providersRepository;
        private readonly IDriverHttpClient _driverHttpClient;

        public ProvidersController(IProvidersRepository providersRepository, IDriverHttpClient driverHttpClient)
        {
            _providersRepository = providersRepository;
            _driverHttpClient = driverHttpClient;
        }

        // GET: api/<ProvidersController>
        [HttpGet]
        public async Task<IEnumerable<Provider>> GetAllProviders()
        {
            return await _providersRepository.GetAllProvidersAvailable();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<Driver> Drivers()
        {
            var drivers = await _driverHttpClient.GetDriver();

            if (drivers == null || drivers.Count <= 0)
            {
                return null;
            }

            return drivers.FirstOrDefault();
        }

        // GET api/<ProvidersController>/5
        [HttpGet("{id}")]
        public async Task<OrderClothe> Get(int id)
        {
            var provider = await _providersRepository.GetProviderById(id);

            if (provider == null) 
            {
                return null;
            }

            var driver = await _driverHttpClient.GetDriver();

            if (driver == null) 
            {
                return null;
            }

            var orderClothe = new OrderClothe
            {
                DriverName = driver.FirstOrDefault().Name,
                DriverSurname = driver.FirstOrDefault().Surname,
                ProviderName = provider.Name,
                Price = provider.Price
            };

            return orderClothe;
        }

        // POST api/<ProvidersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
