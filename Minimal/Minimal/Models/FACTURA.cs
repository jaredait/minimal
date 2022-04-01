using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.Models
{
    public class FACTURA
    {
        [Key]
        public string FAC_NUMERO { get; set; }
        public string CLI_USUARIO { get; set; }
        public string TIP_ID { get; set; }
        public string ENV_NUMERO { get; set; }
        public DateTime FAC_FECHA { get; set; }
        public string FAC_DIRECCION_CLI { get; set; }
        public string FAC_EMAIL_CLI { get; set; }
        public decimal FAC_MONTO_SUBTOTAL { get; set; }
        public decimal FAC_MONTO_TOTAL { get; set; }
    }
}
