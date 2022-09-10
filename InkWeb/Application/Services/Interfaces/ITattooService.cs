using Application.DTOs;

namespace Application.Services.Interfaces
{
    public interface ITattooService
    {
        Task<ResultServices<TattooDTO>> CreateAsync(TattooDTO tattooDTO);
        Task<ResultServices<TattooDTO>> GetByIdAsync(int id);
        Task<ResultServices<ICollection<TattooDTO>>> GetAllAsync();
        Task<ResultServices> UpdateAsynt(TattooDTO tattooDTO);
        Task<ResultServices> DeleteAsync(string id);
    }
}
