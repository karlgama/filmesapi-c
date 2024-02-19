using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.DTOs.cinema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace filmesApi.Controllers;
[ApiController]
[Route("/cinemas")]
public class CinemaController : ControllerBase
{
    private FilmeContext _context;
    private IMapper _mapper;

    public CinemaController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<ReadCinemaDTO> RecuperarCinemas([FromQuery] int? enderecoId = null)
    {
        if (enderecoId == null)
        {
            return _mapper.Map<List<ReadCinemaDTO>>(_context.Cinemas.ToList());
        }
        return _mapper.Map<List<ReadCinemaDTO>>(_context.Cinemas
                .FromSqlRaw($"SELECT Id,Nome,EnderecoId FROM cinemas WHERE cinemas.EnderecoId = {enderecoId}")
                .ToList());
    }
}