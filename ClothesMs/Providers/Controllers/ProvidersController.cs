using Microsoft.AspNetCore.Mvc;
using Providers.Domain;
using Providers.Repositories;
using Providers.Repositories.HttpRequest;
using Providers.Repositories.HttpRequest.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Providers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvidersController : ControllerBase
    {
        private readonly IProvidersRepository _providersRepository;

        public ProvidersController(IProvidersRepository providersRepository)
        {
            _providersRepository = providersRepository;
        }

        // GET: api/<ProvidersController>
        [HttpGet]
        public async Task<IEnumerable<Provider>> GetAllProviders()
        {
            return await _providersRepository.GetAllProvidersAvailable();
        }

        // GET api/<ProvidersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProvidersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
