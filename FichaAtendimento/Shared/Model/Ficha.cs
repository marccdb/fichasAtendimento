using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FichaAtendimento.Shared.Model
{
    public class Ficha
    {
        [Key]
        public int idPaciente { get; set; }

        [Required]
        public string NomePaciente { get; set; }

        public string ResumoAtendimento { get; set; }

        [Required]
        public bool SessaoPaga { get; set; }

        public string CondutaClinica { get; set; }

        public string ProxTarefa { get; set; }

        public string CID10_DSM { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataAtendimento
        {
            get { return DateTime.Now; }
            set { }
        }

        public string AbordagemProxSessao { get; set; }

        [Required]
        public bool ReciboEntregue { get; set; }

    }
}
