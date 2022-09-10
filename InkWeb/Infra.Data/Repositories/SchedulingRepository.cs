using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class SchedulingRepository : ISchedulingRepository
    {
        private readonly InkWebDbContext _db;

        public SchedulingRepository(InkWebDbContext db)
        {
            _db = db;
        }

        public async Task<Scheduling> CreateAsync(Scheduling scheduling)
        {
            _db.Schedulings.Add(scheduling);
            await _db.SaveChangesAsync();
            return scheduling;
        }

        public async Task DeleteAsync(string id)
        {
            _db.Remove(id);
            await _db.SaveChangesAsync();
        }

        public async Task<ICollection<Scheduling>> GetAllSchedulingsAsync()
        {
            return await _db.Schedulings.ToListAsync();
        }

        public async Task<Scheduling> GetSchedulingByIdAsync(string id)
        {
            return await _db.Schedulings.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task UpdateAsync(Scheduling scheduling)
        {
            _db.Update(scheduling);
            await _db.SaveChangesAsync();
        }
    }
}
