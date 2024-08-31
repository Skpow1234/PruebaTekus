using Microsoft.EntityFrameworkCore;
using PruebaTekus.Domain.Entities;
using PruebaTekus.Domain.Interfaces;
using PruebaTekus.Infrastructure.Data;

namespace PruebaTekus.Infrastructure.Repositories
{
    public class ProviderRepository : IProviderRepository
    {
        private readonly DataContext _context;

        public ProviderRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Provider>> GetAllAsync()
        {
            return await _context.Providers.ToListAsync();
        }

        public async Task<Provider> GetByIdAsync(int id)
        {
            return await _context.Providers
                .FirstOrDefaultAsync(p => p.idprovider == id);
        }

        public async Task<IDictionary<string, int>> GetProviderCountByCountryAsync()
        {
            return await _context.Providers_Services
                .GroupBy(ps => ps.Country.country)
                .Select(g => new { Country = g.Key, Count = g.Select(ps => ps.Providers_idprovider).Distinct().Count() })
                .ToDictionaryAsync(x => x.Country, x => x.Count);
        }

    }
}
