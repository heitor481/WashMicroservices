using Microsoft.AspNetCore.Mvc;
using Providers.Domain;
using Providers.Repositories;
using System.Collections.Generic;

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
        public IEnumerable<Provider> Get()
        {
            return new List<Provider>() 
            {
                new Provider() 
                {
                    Name = "Lavabo",
                    Location = "Marco Bruto 1306",
                    Price = 14,
                    Id = 1
                },

                new Provider()
                {
                    Name = "Lavabo 2",
                    Location = "Marco Bruto 1306",
                    Price = 15,
                    Id = 2
                },

                new Provider()
                {
                    Name = "Lavabo 3",
                    Location = "Marco Bruto 1306",
                    Price = 16,
                    Id = 3
                },

                new Provider()
                {
                    Name = "Lavabo 4",
                    Location = "Marco Bruto 1306",
                    Price = 17,
                    Id = 4
                },
            };
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
