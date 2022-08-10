using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WashClothes.Domain;
using WashClothes.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WashClothes.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WashController : ControllerBase
	{
		private readonly IWashClothesRepository _washClothesRepository;

		public WashController(IWashClothesRepository washClothesRepository)
		{
			_washClothesRepository = washClothesRepository;
		}

		// GET: api/<WashController>
		[HttpGet]
		public async Task<IEnumerable<Clothes>> Get()
		{
			return await _washClothesRepository.GetAllClothesAvailables();
		}

		// GET api/<WashController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<WashController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}
	}
}
