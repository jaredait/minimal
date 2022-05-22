using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.Models
{
    public class CARRITO
    {
        [Key]
        [Required]
        [Display(Name = "ID")]
        public int CAR_ID { get; set; }

        [Required]
        [Display(Name = "Usuario")]
        [MinLength(3, ErrorMessage = "Mínimo 3 caracteres")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string CLI_USUARIO { get; set; }

        [Required]
        [Display(Name = "ID")]
        [MinLength(1, ErrorMessage = "Mínimo 1 caracter")]
        [MaxLength(25, ErrorMessage = "Máximo 25 caracteres")]
        public string PRD_ID { get; set; }

        [Required]
        [Display(Name = "Cantidad de productos")]
        public int CAR_CANTIDAD { get; set; }
    }
}
