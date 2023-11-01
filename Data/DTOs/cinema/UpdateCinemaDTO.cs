using System.ComponentModel.DataAnnotations;

namespace filmesApi.Data.DTOs.cinema;


public class UpdateCinemaDTO
{
    [Required]
    public string Nome { get; set; }

}