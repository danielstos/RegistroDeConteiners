using System;
using System.ComponentModel.DataAnnotations;

namespace RegistroDeConteiners.Models
{
   
    public class Movimentacoes
    {
        public int ID { get; set; }
        [Required]
        public string Navio { get; set; }

        [Display(Name = "Tipo de Movimentação")]
        public string TipodeMv { get; set; }

        [Display(Name = "Data e Hora do Início")]
        public DateTime DtInicio { get; set; }

        [Display(Name = "Data e Hora do Fim")]
        public DateTime DtFim { get; set; }
        public Conteiner Conteiner { get; set; }
        public int ConteinerID { get; set; }

    }
}