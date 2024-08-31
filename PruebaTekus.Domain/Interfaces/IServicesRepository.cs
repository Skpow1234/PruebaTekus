using PruebaTekus.Domain.Entities;

namespace PruebaTekus.Domain.Interfaces
{
    public interface IServicesRepository
    {
        Task AddAsync(Services service);
        Task<IEnumerable<Services>> GetAllAsync();
        Task<Services> GetByIdAsync(int id);
        Task UpdateAsync(Services service);


    }

}
