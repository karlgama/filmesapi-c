using System.ComponentModel.DataAnnotations;
using System.Numerics;
using filmesApi.Models;

namespace FilmesApi.Models;

public class Cinema
{
    [Key]
    [Required]
    public int id { get; set; }

    [Required]
    public string Nome { get; set; }

    public int EnderecoId { get; set; }

    public virtual Endereco Endereco { get; set; }
}