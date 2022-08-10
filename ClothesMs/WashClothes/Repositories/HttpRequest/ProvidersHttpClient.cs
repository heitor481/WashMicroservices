using System.Net.Http;
using System.Threading.Tasks;

namespace WashClothes.Repositories.HttpRequest
{
	public class ProvidersHttpClient : IProvidersHttpClient
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public ProvidersHttpClient(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public Task GetAllProvidersAvailables()
		{
			throw new System.NotImplementedException();
		}
	}
}
