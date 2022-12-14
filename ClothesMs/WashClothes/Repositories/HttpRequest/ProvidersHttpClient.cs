using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WashClothes.Repositories.HttpRequest.Dto;

namespace WashClothes.Repositories.HttpRequest
{
	public class ProvidersHttpClient : IProvidersHttpClient
	{
		private readonly IHttpClientFactory _httpClientFactory;
		private readonly JsonSerializerOptions _options;

		private const string ProvidersApi = "http://localhost:31288/api/providers";

		public ProvidersHttpClient(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
			_options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
		}

		public async Task<List<Provider>> GetAllProvidersAvailables()
		{
			try
			{
				var httpClient = _httpClientFactory.CreateClient();
				using var response = await httpClient.GetAsync(ProvidersApi, HttpCompletionOption.ResponseHeadersRead);
				response.EnsureSuccessStatusCode();
				var stream = await response.Content.ReadAsStreamAsync();
				var providers = await JsonSerializer.DeserializeAsync<List<Provider>>(stream, _options);
				return providers;
			}
			catch
			{
				throw;
			}
		}

        public async Task<OrderClotheDto> GenerateOrder(int providerId)
        {
			try
			{
				var httpClient = _httpClientFactory.CreateClient();
				var route = ProvidersApi + "/" + providerId;
				using var response = await httpClient.GetAsync(route, HttpCompletionOption.ResponseHeadersRead);
				response.EnsureSuccessStatusCode();
				var stream = await response.Content.ReadAsStreamAsync();
				var providers = await JsonSerializer.DeserializeAsync<OrderClotheDto>(stream, _options);
				return providers;
			}
			catch
			{
				throw;
			}
			
		}
    }
}
