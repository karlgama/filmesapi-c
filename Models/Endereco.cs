using System.ComponentModel.DataAnnotations;

namespace filmesApi.Models;

public class Endereco
{
    [Key]
    [Required]
    public int Id { get; set; }
}