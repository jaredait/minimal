using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.Models
{
    public class CATEGORIA
    {
        [Key]
        [Required]
        [Display(Name = "ID")]
        [MinLength(3, ErrorMessage ="Mínimo 3 caracteres")]
        [MaxLength(15, ErrorMessage ="Máximo 15 caracteres")]
        public string CAT_ID { get; set; }

        [Display(Name = "Nombre")]
        [Required]
        [MinLength(3, ErrorMessage = "Mínimo 3 caracteres")]
        [MaxLength(50, ErrorMessage ="Máximo 50 caracteres")]
        public string CAT_NOMBRE { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(250, ErrorMessage ="Máximo 250 caracteres")]
        public string CAT_DESCRIPCION { get; set; }

        [Display(Name = "Ruta imagen")]
        [MaxLength(250, ErrorMessage ="Máximo 250 caracteres")]
        public string CAT_RUTA_IMAGEN { get; set; }
    }
}
