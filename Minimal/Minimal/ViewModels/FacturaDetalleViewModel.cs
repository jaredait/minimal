using Minimal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.ViewModels
{
    public class FacturaDetalleViewModel
    {
        public FacturaDetalleViewModel()
        {

        }

        public FacturaDetalleViewModel(FACTURA factura, List<DETALLE_FACTURA> detalle_Factura)
        {
            Factura = factura;
            Detalle_Factura = detalle_Factura;
        }

        public FACTURA Factura { get; set; }
        public List<DETALLE_FACTURA> Detalle_Factura { get; set; }


    }
}
