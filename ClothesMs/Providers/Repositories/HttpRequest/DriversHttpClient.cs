using Providers.Repositories.HttpRequest.Dto;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Providers.Repositories.HttpRequest
{
	public class DriversHttpClient : IDriverHttpClient
	{
		private readonly IHttpClientFactory _httpClientFactory;
		private readonly JsonSerializerOptions _options;
		private const string  DriverApiConst = "http://localhost:25345/api/drivers";

		public DriversHttpClient(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
			_options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
		}

		public async Task<List<Driver>> GetDriver()
		{
			var client = _httpClientFactory.CreateClient();
			using var response = await client.GetAsync(DriverApiConst);
			response.EnsureSuccessStatusCode();
			var stream = await response.Content.ReadAsStreamAsync();
			var drivers = await JsonSerializer.DeserializeAsync<List<Driver>>(stream, _options);
			return drivers;
		}
	}
}
