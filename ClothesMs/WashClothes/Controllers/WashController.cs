using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WashClothes.Domain;
using WashClothes.Repositories;
using WashClothes.Repositories.HttpRequest;
using WashClothes.Repositories.HttpRequest.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WashClothes.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WashController : ControllerBase
	{
		private readonly IWashClothesRepository _washClothesRepository;
		private readonly IProvidersHttpClient _providersHttpClient;

		public WashController(IWashClothesRepository washClothesRepository, IProvidersHttpClient providersHttpClient)
		{
			_washClothesRepository = washClothesRepository;
			_providersHttpClient = providersHttpClient;
		}

		// GET: api/<WashController>
		[HttpGet]
		public async Task<IEnumerable<Clothes>> Get()
		{
			return await _washClothesRepository.GetAllClothesAvailables();
		}

		[HttpGet]
		[Route("[action]")]
		public async Task<List<Provider>> Providers()
		{
			var providersAvailables = await _providersHttpClient.GetAllProvidersAvailables();

			if (providersAvailables != null)
			{
				return providersAvailables;
			}

			return null;
		}

		[HttpGet]
		[Route("{clotheId}/providers/{providerId}")]
		public async Task<OrderClotheDto> CompleteOrder(int clotheId, int providerId)
		{
			var clothe = await _washClothesRepository.GetClotheById(clotheId);

			if (clothe == null) 
			{
				return null;
			}

			var user = await _washClothesRepository.GetUser(clothe.UserId);

			if (user == null) 
			{
				return null;
			}

			var provider = await _providersHttpClient.GenerateOrder(providerId);

			if (provider == null) 
			{
				return null;
			}

			var objToRetur = new OrderClotheDto
			{
				DriverName = provider.DriverName,
				DriverSurname = provider.DriverSurname,
				ProviderName = provider.ProviderName,
				Price = provider.Price,
				Username = user.FullName,
			};

			return objToRetur;
		}

		// GET api/<WashController>/5
		[HttpGet("{id}")]
		public async Task<IEnumerable<Clothes>> Get(int id)
		{
			var usrClothes = await _washClothesRepository.GetClothesByUser(id);
			return usrClothes;
		}

		// POST api/<WashController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}
	}
}
