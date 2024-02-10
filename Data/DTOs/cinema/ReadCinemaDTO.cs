using filmesApi.Data.DTOs.endereco;
using FilmesApi.Data.DTOs.sessao;

namespace FilmesApi.Data.DTOs.cinema;

public class ReadCinemaDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public ReadEnderecoDTO ReadEnderecoDto { get; set; }

    public ICollection<ReadSessaoDTO> Sessoes { get; set; }
}