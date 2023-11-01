using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTOs.cinema;

public class CreateCinemaDTO
{
    [Required] public string Nome { get; set; }
}