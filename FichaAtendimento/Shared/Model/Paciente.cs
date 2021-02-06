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
        public DateTime DataNascimento
        {
            get { return DateTime.Now; }
            set { }
        }

        public string Nacionalidade { get; set; }

        [Required]
        public string Endereco { get; set; }

        public string Profissao { get; set; }

        [Required]
        public string Telefone { get; set; }

        public string Email { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        public string RG { get; set; }

        public string Escolaridade { get; set; }

        public string Religiao { get; set; }

        public string NomePai { get; set; }

        public int IdadePai { get; set; }

        public string NomeMae { get; set; }

        public int IdadeMae { get; set; }

        public string ReciboPara { get; set; }
    }
}
