using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FichaAtendimento.Shared.Model
{
    public class Paciente
    {
        [Key]
        public int idPaciente { get; set; }

        [Required]
        public string NomePaciente { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataNascimento { get; set; }

        [Required]
        public string Endereco { get; set; }

        [Required]
        public string Telefone { get; set; }

        public string Email { get; set; }




    }
}
