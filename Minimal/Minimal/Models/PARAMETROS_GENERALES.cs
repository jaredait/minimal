using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.Models
{
    public class PARAMETROS_GENERALES
    {
        [Key]
        public string PAR_NOMBRE { get; set; }
        public string PAR_VALOR { get; set; }
    }
}
