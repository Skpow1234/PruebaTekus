using Microsoft.EntityFrameworkCore;
using PruebaTekus.Domain.Entities;
using PruebaTekus.Domain.Interfaces;
using PruebaTekus.Infrastructure.Data;

namespace PruebaTekus.Infrastructure.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly DataContext _context;

        public CountryRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Country> GetByIdAsync(int id)
        {
            return await _context.Countries
                .Include(p => p.ProvidersServices)
                    .ThenInclude(ps => ps.Services)
                .FirstOrDefaultAsync(p => p.idcountry == id);
        }
    }
}
