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
    public class DeleteModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;
        private IDetalle_FacturaAccess detalle_FacturaAccess { get; set; }
        private IFacturaAccess facturaAccess { get; set; }

        public DeleteModel(Minimal.Data.MinimalContext context)
        {
            _context = context;
            facturaDetalleViewModel = new FacturaDetalleViewModel();
            detalle_FacturaAccess = new Detalle_FacturaAccess(context);
            facturaAccess = new FacturaAccess(context);
        }

        [BindProperty]
        public FACTURA FACTURA { get; set; }
        [BindProperty]
        public FacturaDetalleViewModel facturaDetalleViewModel { get; set; }

        public void OnGet(int id)
        {

            facturaDetalleViewModel.Factura = facturaAccess.ObtenerFacturaPorId(id);
            facturaDetalleViewModel.Detalle_Factura = (List<DETALLE_FACTURA>)detalle_FacturaAccess.ObtenerDetallaPorFacturaId(id);

        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FACTURA = await _context.FACTURA.FindAsync(id);

            if (FACTURA != null)
            {
                _context.FACTURA.Remove(FACTURA);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
