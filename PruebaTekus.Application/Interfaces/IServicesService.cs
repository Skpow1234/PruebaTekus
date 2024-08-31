

using PruebaTekus.Application.Dtos;

namespace PruebaTekus.Application.Interfaces
{
    public interface IServicesService
    {
        Task<IEnumerable<ServiceDto>> GetAllServicesAsync();

        Task<ServiceDto> CreateServiceAsync(ServiceDto serviceDto);
        Task<IDictionary<string, int>> GetServiceCountByCountryAsync();
        Task<ServiceDto> UpdateServiceAsync(ServiceDto serviceDto);
    }
}
