using Refit;
using System.Threading.Tasks;

namespace CepRefitSample
{
    public interface ICepService
    {
        [Get("/cep/{cep}.json")]
        public Task<CepResponse> GetAsync(string cep);
    }
}
