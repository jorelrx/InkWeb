using Domain.Entities;

namespace Domain.Repositories
{
    public interface ISchedulingRepository
    {
        Task<Scheduling> GetSchedulingByIdAsync(string id);
        Task<ICollection<Scheduling>> GetAllSchedulingsAsync();
        Task<Scheduling> CreateAsync(Scheduling scheduling);
        Task UpdateAsync(Scheduling scheduling);
        Task DeleteAsync(string id);
    }
}
