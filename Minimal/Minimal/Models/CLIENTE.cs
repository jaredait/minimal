using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.Models
{
    public class CLIENTE
    {
        [Key]
        public string CLI_USUARIO { get; set; }
        public string CLI_CONTRASENA { get; set; }
        public string CLI_CEDULA_RUC { get; set; }
        public string CLI_EMAIL { get; set; }
        public string CLI_NOMBRE { get; set; }
        public string CLI_APELLIDO { get; set; }
        public int CLI_EDAD { get; set; }
        public char CLI_SEXO { get; set; }
        public string CLI_DIRECCION { get; set; }
        public string CLI_CIUDAD { get; set; }
        public string CLI_PROVINCIA { get; set; }
        public string CLI_TELEFONO { get; set; }
    }
}
