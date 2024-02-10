using AutoMapper;
using filmesApi.Data.DTOs;
using filmesApi.Models;

namespace FilmesApi.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDTO, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>()
                     .ForMember(dto => dto.Sessoes,
                opt => opt.MapFrom(filme => filme.Sessoes));
    }

}