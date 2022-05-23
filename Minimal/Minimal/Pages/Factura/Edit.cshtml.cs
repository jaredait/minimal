using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Minimal.Data;
using Minimal.DataAccess;
using Minimal.Models;
using Minimal.ViewModels;

namespace Minimal.Pages.Factura
{
    public class EditModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;
        private IDetalle_FacturaAccess detalle_FacturaAccess { get; set; }
        private IFacturaAccess facturaAccess{ get; set; }

        public EditModel(Minimal.Data.MinimalContext context)
        {
            _context = context;
            facturaDetalleViewModel = new FacturaDetalleViewModel();
            detalle_FacturaAccess = new Detalle_FacturaAccess(context);
            facturaAccess = new FacturaAccess(context);
        }

        [BindProperty]
        public FacturaDetalleViewModel facturaDetalleViewModel { get; set; }

        public void OnGet(int id)
        {
            facturaDetalleViewModel.Factura = facturaAccess.ObtenerFacturaPorId(id);
            facturaDetalleViewModel.Detalle_Factura = (List<DETALLE_FACTURA>)detalle_FacturaAccess.ObtenerDetallaPorFacturaId(id);
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(facturaDetalleViewModel.Factura).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FACTURAExists(facturaDetalleViewModel.Factura.FAC_NUMERO))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FACTURAExists(int id)
        {
            return _context.FACTURA.Any(e => e.FAC_NUMERO == id);
        }
    }
}
