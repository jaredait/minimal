using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.Models
{
    public class CATEGORIA_PRODUCTO
    {
        [Key]
        [Required]
        [Display(Name = "ID Categoría")]
        [MaxLength(15)]
        public string CAT_ID { get; set; }

        [Required]
        [Display(Name = "ID Producto")]
        [MaxLength(25)]
        public string PRD_ID { get; set; }
    }
}
