using filmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace filmesApi.Controllers;

[ApiController]
[Route("/filmes")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public void Create([FromBody]Filme filme)
    {
        filmes.Add(filme);
    }

    [HttpGet]
    public List<Filme> List()
    {
        return filmes;
    }
}
