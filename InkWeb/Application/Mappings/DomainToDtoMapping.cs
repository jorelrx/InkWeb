using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class DomainToDtoMapping : Profile
    {
        public DomainToDtoMapping()
        {
            CreateMap<Tattoo, TattooDTO>();
            CreateMap<Scheduling, SchedulingDTO>();
        }
    }
}
