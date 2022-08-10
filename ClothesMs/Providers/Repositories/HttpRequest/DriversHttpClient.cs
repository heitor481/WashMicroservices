using System.Net.Http;
using System.Threading.Tasks;

namespace Providers.Repositories.HttpRequest
{
	public class DriversHttpClient : IDriverHttpClient
	{
		private readonly IHttpClientFactory _httpClientFactory;
		private const string  DriverApiConst = "http://localhost:25345/";

		public DriversHttpClient(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task GetDriver()
		{
			var client = _httpClientFactory.CreateClient();

			using (var response = await client.GetAsync(DriverApiConst))
			{
				response.EnsureSuccessStatusCode();

				var stream = await response.Content.ReadAsStreamAsync();
			}
		}
	}
}
