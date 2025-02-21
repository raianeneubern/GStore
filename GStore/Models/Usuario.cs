using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GStore.Models;

public class Usuario: IdentityUser
{
    [Required(ErrorMessage ="Por favor, informe o Nome")]
    public string Nome { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento")]
    public DateTime DataNascimento { get; set; }

    [StringLength(200)]
    public string Foto { get; set; }
}


