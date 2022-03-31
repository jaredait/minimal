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
        public string CAT_ID { get; set; }

        [Display(Name = "Nombre")]
        public string CAT_NOMBRE { get; set; }
        public string CAT_DESCRIPCION { get; set; }
        public Byte[] CAT_MINIATURA { get; set; }
        public string CAT_RUTA_IMAGEN { get; set; }
    }
}
