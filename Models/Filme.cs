using FilmesApi.Models;
using System.ComponentModel.DataAnnotations;

namespace filmesApi.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage ="O título do filme é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Genero { get; set; }
    [Range(70,600,ErrorMessage ="A duração deve ser entre 70 e 600 minutos")]
    public int Duracao{ get; set; }

    public virtual ICollection<Sessao> Sessoes { get; set; }
}
