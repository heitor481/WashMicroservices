using System.Threading.Tasks;

namespace WashClothes.Repositories.HttpRequest
{
	public interface IProvidersHttpClient
	{
		Task GetAllProvidersAvailables(); 
	}
}
