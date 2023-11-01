using AutoMapper;
using filmesApi.Data.DTOs.cinema;
using FilmesApi.Data.DTOs.cinema;
using FilmesApi.Models;

namespace filmesApi.profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDTO, Cinema>();
        CreateMap<UpdateCinemaDTO, Cinema>();
        CreateMap<Cinema, ReadCinemaDTO>();
    }
}