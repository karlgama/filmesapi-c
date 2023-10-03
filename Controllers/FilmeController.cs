using filmesApi.Models;
using FilmesApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace filmesApi.Controllers;

[ApiController]
[Route("/filmes")]
public class FilmeController : ControllerBase
{
    private FilmeContext _context;

    public FilmeController(FilmeContext context)
    {
        _context = context;
    }

    [HttpPost]
    public ActionResult Create([FromBody] Filme filme)
    {
        _context.Filmes.Add(filme);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetById), new { id = filme.Id }, filme);
    }

    [HttpGet]
    public IEnumerable<Filme> List([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _context.Filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult GetById([FromQuery] int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        return Ok(filme);
    }
}
