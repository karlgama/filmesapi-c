using FilmesApi.Data.DTOs.sessao;

namespace filmesApi.Data.DTOs;

public class ReadFilmeDto
{
    public int id { get; set; }
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Duracao { get; set; }

    public DateTime HoraDaConsulta { get; set; } = DateTime.Now;

    public ICollection<ReadSessaoDTO> Sessoes { get; set; }
}