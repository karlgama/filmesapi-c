using AutoMapper;
using FilmesApi.Data.DTOs.sessao;
using FilmesApi.Models;

namespace FilmesApi.Profiles;

public class SessaoProfile : Profile
{
    public SessaoProfile()
    {
        CreateMap<CreateSessaoDTO, Sessao>();
        CreateMap<Sessao, ReadSessaoDTO>();
    }
}