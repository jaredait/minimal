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
        public string CAT_ID { get; set; }
        public string PRD_ID { get; set; }
    }
}
