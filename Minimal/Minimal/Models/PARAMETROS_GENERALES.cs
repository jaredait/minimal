using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.Models
{
    public class PARAMETROS_GENERALES
    {
        [Key]
        [Required]
        [Display(Name = "Nombre")]
        [MinLength(1, ErrorMessage = "Mínimo 1 caracteres")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string PAR_NOMBRE { get; set; }
        

        [Display(Name = "Valor")]
        [MinLength(1, ErrorMessage = "Mínimo 1 caracteres")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string PAR_VALOR { get; set; }
    }
}
