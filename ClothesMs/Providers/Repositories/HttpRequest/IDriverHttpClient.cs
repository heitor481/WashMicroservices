using Providers.Repositories.HttpRequest.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Providers.Repositories.HttpRequest
{
	public interface IDriverHttpClient
	{
		Task<List<Driver>> GetDriver();
	}
}
