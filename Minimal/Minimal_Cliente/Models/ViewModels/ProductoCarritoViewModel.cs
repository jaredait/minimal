using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.ViewModels
{
    public class ProductoCarritoViewModel
    {
        public string CLI_USUARIO { get; set; }
        public string PRD_ID { get; set; }
        public int CAR_CANTIDAD { get; set; }
        public decimal PRD_PRECIO { get; set; }
        public decimal PRD_PESO { get; set; }
        public string PRD_DESCRIPCION { get; set; }
        public string PRD_RUTA_IMAGEN { get; set; }

    }
}
