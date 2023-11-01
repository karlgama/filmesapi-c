using AutoMapper;
using filmesApi.Data.DTOs;
using filmesApi.Models;
using FilmesApi.Data;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace filmesApi.Controllers;

[ApiController]
[Route("/filmes")]
public class FilmeController : ControllerBase
{
    private FilmeContext _context;
    private IMapper _mapper;

    public FilmeController(FilmeContext context, IMapper mapper)
    {
        _mapper = mapper;
        _context = context;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public ActionResult Create([FromBody] CreateFilmeDTO request)
    {
        var filme = _mapper.Map<Filme>(request);
        _context.Filmes.Add(filme);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetById), new { id = filme.Id }, filme);
    }

    [HttpGet]
    public IEnumerable<ReadFilmeDto> List([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadFilmeDto>>(_context.Filmes.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public IActionResult GetById([FromQuery] int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        var filmeDto = _mapper.Map<ReadFilmeDto>(filme);
        if (filme == null) return NotFound();
        return Ok(filmeDto);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] CreateFilmeDTO request)
    {
        var filme = _context.Filmes.FirstOrDefault(
            filme => filme.Id == id
        );
        if (filme == null) return NotFound();
        _mapper.Map(request, filme);
        _context.SaveChanges();
        return NoContent();

    }

    [HttpPatch("{id}")]
    public IActionResult UpdatePartial(int id,
    JsonPatchDocument<UpdateFilmeDto> request)
    {
        var filme = _context.Filmes.FirstOrDefault(
            filme => filme.Id == id
        );
        if (filme == null) return NotFound();

        var toUpdate = _mapper.Map<UpdateFilmeDto>(filme);

        request.ApplyTo(toUpdate, ModelState);

        if (!TryValidateModel(toUpdate))
            return ValidationProblem(ModelState);

        _mapper.Map(request, filme);
        _context.SaveChanges();
        return NoContent();

    }


    [HttpDelete("{id}")]
    public IActionResult Delete(int id,
    JsonPatchDocument<UpdateFilmeDto> request)
    {
        var filme = _context.Filmes.FirstOrDefault(
            filme => filme.Id == id
        );
        if (filme == null) return NotFound();
        _context.Remove(filme);
        _context.SaveChanges();
        return NoContent();

    }
}
