using Application.DTOs;

namespace Application.Services.Interfaces
{
    public interface ISchedulingService
    {
        Task<ResultServices<SchedulingDTO>> CreateAsync(SchedulingDTO schedulingDTO);
        Task<ResultServices<SchedulingDTO>> GetByIdAsync(int id);
        Task<ResultServices<ICollection<SchedulingDTO>>> GetAllAsync();
        Task<ResultServices> UpdateAsynt(SchedulingDTO schedulingDTO);
        Task<ResultServices> DeleteAsync(string id);
    }
}
