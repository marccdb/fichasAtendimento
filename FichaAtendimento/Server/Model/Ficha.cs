using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FichaAtendimento.Server.Model
{
    public class Ficha
    {
        [Key]
        public int ID { get; set; }

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
        public DateTime DataAtendimento { get; set; }

        public string AbordagemProxSessao { get; set; }

        [Required]
        public bool ReciboEntregue { get; set; }

    }
}
