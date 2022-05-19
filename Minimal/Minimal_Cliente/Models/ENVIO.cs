using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models
{
    public class ENVIO
    {
        [Key]
        [Required]
        [Display(Name = "Número de envío")]
        [MinLength(1, ErrorMessage = "Mínimo 1 caracter")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres")]
        public string ENV_NUMERO { get; set; }
        
        [Required]
        [Display(Name = "Dirección")]
        [MinLength(10, ErrorMessage = "Mínimo 10 caracteres")]
        [MaxLength(250, ErrorMessage = "Máximo 250 caracteres")]
        public string ENV_DIRECCION { get; set; }
        
        [Required]
        [Display(Name = "Precio")]
        [Range(0, 9999999.99, ErrorMessage = "El precio debe estar entre 0 y 9999999.99")]
        public decimal ENV_PRECIO { get; set; }
    }
}
