using Application.DTOs;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services
{
    public class TattooService : ITattooService
    {
        private readonly ITattooRepository _tattooRepository;
        private readonly IMapper _mapper;

        public TattooService(ITattooRepository tattooRepository, IMapper mapper)
        {
            _tattooRepository = tattooRepository;
            _mapper = mapper;
        }

        public async Task<ResultServices<TattooDTO>> CreateAsync(TattooDTO tattooDTO)
        {
            if (tattooDTO == null)
                return ResultServices.Fail<TattooDTO>("Objeto deve ser informado!");

            var tattoo = _mapper.Map<Tattoo>(tattooDTO);
            var data = await _tattooRepository.CreateAsync(tattoo);
            return ResultServices.Ok<TattooDTO>(_mapper.Map<TattooDTO>(data));
        }

        public async Task<ResultServices> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultServices<ICollection<TattooDTO>>> GetAllAsync()
        {
            var tattoo = await _tattooRepository.GetAllTattoosAsync();
            return ResultServices.Ok<ICollection<TattooDTO>>(_mapper.Map<ICollection<TattooDTO>>(tattoo));
        }

        public async Task<ResultServices<TattooDTO>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultServices> UpdateAsynt(TattooDTO tattooDTO)
        {
            throw new NotImplementedException();
        }
    }
}
