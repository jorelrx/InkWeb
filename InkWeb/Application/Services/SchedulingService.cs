using Application.DTOs;
using Application.Services.Interfaces;

namespace Application.Services
{
    public class SchedulingService : ISchedulingService
    {
        public Task<ResultServices<SchedulingDTO>> CreateAsync(SchedulingDTO schedulingDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ResultServices> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultServices<ICollection<SchedulingDTO>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResultServices<SchedulingDTO>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultServices> UpdateAsynt(SchedulingDTO schedulingDTO)
        {
            throw new NotImplementedException();
        }
    }
}
