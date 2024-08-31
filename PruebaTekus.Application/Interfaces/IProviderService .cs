using PruebaTekus.Application.Dtos;

namespace PruebaTekus.Application.Interfaces
{
    public interface IProviderService
    {
        Task<IEnumerable<ProviderDto>> ListAsyncProviders();
        Task<ProviderDto> GetProviderByIdAsync(int id);
        Task<IDictionary<string, int>> GetProviderCountByCountryAsync();

    }
}
