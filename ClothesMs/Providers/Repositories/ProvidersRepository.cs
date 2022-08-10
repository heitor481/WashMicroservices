using Providers.Domain;
using Providers.Infra;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Providers.Repositories
{
    public class ProvidersRepository : IProvidersRepository
    {
        private readonly ProvidersDBContext _providersDBContext;

        public ProvidersRepository(ProvidersDBContext providersDBContext)
        {
            _providersDBContext = providersDBContext;
        }

        public async Task<List<Provider>> GetAllProvidersAvailable()
        {
            return await _providersDBContext.Providers.ToListAsync();
        }
    }
}
