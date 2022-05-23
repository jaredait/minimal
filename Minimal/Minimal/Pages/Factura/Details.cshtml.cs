using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minimal.Data;
using Minimal.DataAccess;
using Minimal.Models;
using Minimal.ViewModels;

namespace Minimal.Pages.Factura
{
    public class DetailsModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;
        private IDetalle_FacturaAccess detalle_FacturaAccess { get; set; }
        private IFacturaAccess facturaAccess { get; set; }

        public DetailsModel(Minimal.Data.MinimalContext context)
        {
            _context = context;
            facturaDetalleViewModel = new FacturaDetalleViewModel();
            detalle_FacturaAccess = new Detalle_FacturaAccess(context);
            facturaAccess = new FacturaAccess(context);
        }

        public FacturaDetalleViewModel facturaDetalleViewModel { get; set; }

        public void OnGet(int id)
        {
            facturaDetalleViewModel.Factura = facturaAccess.ObtenerFacturaPorId(id);
            facturaDetalleViewModel.Detalle_Factura = (List<DETALLE_FACTURA>)detalle_FacturaAccess.ObtenerDetallaPorFacturaId(id);
        }
    }
}
