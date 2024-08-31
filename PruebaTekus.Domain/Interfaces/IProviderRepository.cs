using PruebaTekus.Domain.Entities;

namespace PruebaTekus.Domain.Interfaces
{
    public interface IProviderRepository
    {
        Task<IEnumerable<Provider>> GetAllAsync();
        Task<Provider> GetByIdAsync(int id);
        Task<IDictionary<string, int>> GetProviderCountByCountryAsync();
    }
}
