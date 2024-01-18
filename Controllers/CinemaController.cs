using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.DTOs.cinema;
using Microsoft.AspNetCore.Mvc;

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

    public IEnumerable<ReadCinemaDTO> RecuperarCinemas()
    {

    }
}