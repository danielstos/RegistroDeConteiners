using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroDeConteiners.Models
{
    public class Conteiner
    {

        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Cliente { get; set; }
       
        [StringLength(11, MinimumLength = 4)]
        [Required]
        [Display(Name = "Numero de Contêiner")]
        public string Numerodecntr { get; set; }
 
        public int Tipo { get; set; }
        public string Status { get; set; }
        public string Categoria { get; set; }
    }
}