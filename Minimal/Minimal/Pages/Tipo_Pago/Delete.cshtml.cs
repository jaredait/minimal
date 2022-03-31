using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minimal.Data;
using Minimal.Models;

namespace Minimal.Pages.Tipo_Pago
{
    public class DeleteModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;

        public DeleteModel(Minimal.Data.MinimalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TIPO_PAGO TIPO_PAGO { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TIPO_PAGO = await _context.TIPO_PAGO.FirstOrDefaultAsync(m => m.TIP_ID == id);

            if (TIPO_PAGO == null)
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

            TIPO_PAGO = await _context.TIPO_PAGO.FindAsync(id);

            if (TIPO_PAGO != null)
            {
                _context.TIPO_PAGO.Remove(TIPO_PAGO);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
