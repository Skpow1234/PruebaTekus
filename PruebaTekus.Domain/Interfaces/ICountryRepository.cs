using PruebaTekus.Domain.Entities;

namespace PruebaTekus.Domain.Interfaces
{
    public interface ICountryRepository
    {
        Task<Country> GetByIdAsync(int id);
    }
}
