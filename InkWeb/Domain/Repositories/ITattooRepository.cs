using Domain.Entities;

namespace Domain.Repositories
{
    public interface ITattooRepository
    {
        Task<Tattoo> GetTattooByIdAsync(string id);
        Task<ICollection<Tattoo>> GetAllTattoosAsync();
        Task<Tattoo> CreateAsync(Tattoo tattoo);
        Task UpdateAsync(Tattoo tattoo);
        Task DeleteAsync(string id);
    }
}
