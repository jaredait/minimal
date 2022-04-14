using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.Models
{
    public class DETALLE_FACTURA
    {
        [Key]
        [Required]
        [Display(Name = "ID Producto")]
        [MinLength(1, ErrorMessage = "Mínimo 1 caracter")]
        [MaxLength(25, ErrorMessage = "Máximo 25 caracteres")]
        public string PRD_ID { get; set; }
        
        [Required]
        [Display(Name = "Número de factura")]
        [MinLength(1, ErrorMessage = "Mínimo  caracter")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres")]
        public string FAC_NUMERO { get; set; }
        
        [Range(0, 9999999.99, ErrorMessage = "El precio debe estar entre 0 y 9999999.99")]
        [Display(Name = "Precio producto")]
        public decimal DET_PRECIO_PRD { get; set; }
        
        [Range(0, 65535)]
        [Display(Name = "Cantidad")]
        public int DET_CANTIDAD { get; set; }
    }
}
