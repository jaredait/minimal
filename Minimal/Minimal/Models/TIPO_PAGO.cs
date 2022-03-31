using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.Models
{
    public class TIPO_PAGO
    {
        [Key]
        public string TIP_ID { get; set; }
        public string TIP_DESC { get; set; }
    }
}
