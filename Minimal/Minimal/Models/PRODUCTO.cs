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
        [Display(Name = "ID")]
        public string PRD_ID { get; set; }
        public string PRD_NOMBRE { get; set; }
        public decimal PRD_PRECIO { get; set; }
        public decimal PRD_PESO { get; set; }
        public string PRD_DESCRIPCION { get; set; }
        public Byte[] PRD_MINIATURA { get; set; }
        public string PRD_RUTA_IMAGEN { get; set; }
        public DateTime PRD_FECHA_CREACION { get; set; }
        public int PRD_STOCK { get; set; }
    }
}
