using System.ComponentModel.DataAnnotations;

namespace filmesApi.Data.DTOs;
public class CreateFilmeDTO
{
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O título do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "tamanho invalido")]
    public string Genero { get; set; }

    [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}