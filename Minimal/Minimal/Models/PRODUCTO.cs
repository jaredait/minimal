using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.Models
{
    public class PRODUCTO
    {
        [Key]
        [Required]
        [Display(Name = "ID")]
        [MinLength(1, ErrorMessage = "Mínimo 1 caracter")]
        [MaxLength(25, ErrorMessage = "Máximo 25 caracteres")]
        public string PRD_ID { get; set; }

        [Display(Name = "Nombre")]
        [MinLength(1, ErrorMessage = "Mínimo 1 caracter")]
        [MaxLength(25, ErrorMessage = "Máximo 25 caracteres")]
        public string PRD_NOMBRE { get; set; }

        [Required]
        [Display(Name = "Precio")]
        [Range(0, 9999999.99, ErrorMessage = "El precio debe estar entre 0 y 9999999.99")]
        public decimal PRD_PRECIO { get; set; }

        [Display(Name = "Peso en gramos")]
        [Range(0, 9999999.99, ErrorMessage = "El precio debe estar entre 0 y 9999999.99")]
        public decimal PRD_PESO { get; set; }

        [Display(Name = "Descripción")]
        [MinLength(1, ErrorMessage = "Mínimo 1 caracter")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string PRD_DESCRIPCION { get; set; }

        [Display(Name = "Ruta de imagen")]
        [MinLength(1, ErrorMessage = "Mínimo 1 caracter")]
        [MaxLength(250, ErrorMessage = "Máximo 250 caracteres")]
        public string PRD_RUTA_IMAGEN { get; set; }

        [Display(Name = "Fecha creación")]
        [DataType(DataType.Date)]
        public DateTime PRD_FECHA_CREACION { get; set; }

        [Display(Name = "Stock")]
        [Range(0, 64535, ErrorMessage = "Stock fuera del rango permitido")]
        public int PRD_STOCK { get; set; }
    }
}
