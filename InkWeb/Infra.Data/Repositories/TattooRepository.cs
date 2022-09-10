using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class TattooRepository : ITattooRepository
    {
        private readonly InkWebDbContext _db;

        public TattooRepository(InkWebDbContext db)
        {
            _db = db;
        }

        public async Task<Tattoo> CreateAsync(Tattoo tattoo)
        {
            _db.Tattoos.Add(tattoo);
            await _db.SaveChangesAsync();
            return tattoo;
        }

        public async Task DeleteAsync(string id)
        {
            _db.Remove(id);
            await _db.SaveChangesAsync();
        }

        public async Task<ICollection<Tattoo>> GetAllTattoosAsync()
        {
            return await _db.Tattoos.ToListAsync();
        }

        public async Task<Tattoo> GetTattooByIdAsync(string id)
        {
            return await _db.Tattoos.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task UpdateAsync(Tattoo tattoo)
        {
            _db.Update(tattoo);
            await _db.SaveChangesAsync();
        }
    }
}
