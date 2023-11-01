using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace FilmesApi.Models;

public class Cinema
{
    [Key]
    [Required]
    public int id { get; set; }

    [Required]
    public string Nome { get; set; }
}