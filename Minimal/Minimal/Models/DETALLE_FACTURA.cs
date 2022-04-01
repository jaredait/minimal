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
        public string PRD_ID { get; set; }
        public string FAC_NUMERO { get; set; }
        public decimal DET_PRECIO_PRD { get; set; }
        public int DET_CANTIDAD { get; set; }
    }
}
