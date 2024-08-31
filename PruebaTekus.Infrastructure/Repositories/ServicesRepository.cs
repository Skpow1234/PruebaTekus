using Microsoft.EntityFrameworkCore;
using PruebaTekus.Domain.Entities;
using PruebaTekus.Domain.Interfaces;
using PruebaTekus.Infrastructure.Data;

namespace PruebaTekus.Infrastructure.Repositories
{
    public class ServicesRepository : IServicesRepository
    {

        private readonly DataContext _context;

        public ServicesRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Services>> GetAllAsync()
        {
            return await _context.Services
                .Include(s => s.ProvidersServices)
                    .ThenInclude(ps => ps.Provider)
                .Include(s => s.ProvidersServices)
                    .ThenInclude(ps => ps.Country)
                .ToListAsync();
        }

        public async Task AddAsync(Services service)
        {
            _context.Services.Add(service);
            await _context.SaveChangesAsync();
        }

        public async Task<Services> GetByIdAsync(int id)
        {
            return await _context.Services
                .Include(s => s.ProvidersServices)
                .ThenInclude(ps => ps.Provider)
                .Include(s => s.ProvidersServices)
                .ThenInclude(ps => ps.Country)
                .FirstOrDefaultAsync(s => s.idservice == id);
        }

        public async Task UpdateAsync(Services service)
        {
            _context.Entry(service).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
