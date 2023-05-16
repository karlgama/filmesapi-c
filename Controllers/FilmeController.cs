using filmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace filmesApi.Controllers;

[ApiController]
[Route("/filmes")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public ActionResult Create([FromBody]Filme filme)
    {
        filmes.Add(filme);
        return CreatedAtAction(nameof(GetById), new {id=filme.Id},filme);
    }

    [HttpGet]
    public IEnumerable<Filme> List([FromQuery]int skip=0,[FromQuery] int take=50)
    {
        return filmes.Skip(skip).Take(take);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetById([FromQuery]int id) {
        var filme =  filmes.FirstOrDefault(filme=>filme.Id==id);
        if (filme == null) return NotFound();
        return Ok(filme);
    }
}
