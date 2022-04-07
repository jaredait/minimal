using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.Models
{
    public class TIPO_PAGO
    {
        [Key]
        [Required]
        [MinLength(1, ErrorMessage = "Mínimo 1 caracter")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres")]
        [Display(Name = "ID")]
        public string TIP_ID { get; set; }


        [MinLength(1, ErrorMessage = "Mínimo 1 caracteres")]
        [MaxLength(250, ErrorMessage = "Máximo 250 caracteres")]
        [Display(Name = "Descripción")]
        public string TIP_DESC { get; set; }
    }
}
