using System.Collections.Generic;
using System.Threading.Tasks;
using WashClothes.Repositories.HttpRequest.Dto;

namespace WashClothes.Repositories.HttpRequest
{
	public interface IProvidersHttpClient
	{
		Task<List<Provider>> GetAllProvidersAvailables();

		Task<OrderClotheDto> GenerateOrder(int providerId);
	}
}
