using Providers.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Providers.Repositories
{
    public interface IProvidersRepository
    {
        Task<List<Provider>> GetAllProvidersAvailable();

        Task<Provider> GetProviderById(int id);
    }
}
