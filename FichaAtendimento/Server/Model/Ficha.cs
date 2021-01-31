using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public DateTime DataAtendimento { get; set; }

        public string AbordagemProxSessao { get; set; }

        [Required]
        public bool ReciboEntregue { get; set; }
    }
}
