using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.Models
{
    public class ENVIO
    {
        [Key]
        [MaxLength(15)]
        public string ENV_NUMERO { get; set; }
        public string ENV_DIRECCION { get; set; }
        public decimal ENV_PRECIO { get; set; }
    }
}
