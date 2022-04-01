using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Minimal.Data;
using Minimal.Models;

namespace Minimal.Pages.Detalle_Factura
{
    public class EditModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;

        public EditModel(Minimal.Data.MinimalContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DETALLE_FACTURA).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DETALLE_FACTURAExists(DETALLE_FACTURA.PRD_ID))
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

        private bool DETALLE_FACTURAExists(string id)
        {
            return _context.DETALLE_FACTURA.Any(e => e.PRD_ID == id);
        }
    }
}
