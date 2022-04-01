using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minimal.Data;
using Minimal.Models;

namespace Minimal.Pages.Detalle_Factura
{
    public class DeleteModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;

        public DeleteModel(Minimal.Data.MinimalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DETALLE_FACTURA DETALLE_FACTURA { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DETALLE_FACTURA = await _context.DETALLE_FACTURA.FirstOrDefaultAsync(m => m.PRD_ID == id);

            if (DETALLE_FACTURA == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DETALLE_FACTURA = await _context.DETALLE_FACTURA.FindAsync(id);

            if (DETALLE_FACTURA != null)
            {
                _context.DETALLE_FACTURA.Remove(DETALLE_FACTURA);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
