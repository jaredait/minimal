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

namespace Minimal.Pages.Tipo_Pago
{
    public class EditModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;

        public EditModel(Minimal.Data.MinimalContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TIPO_PAGO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TIPO_PAGOExists(TIPO_PAGO.TIP_ID))
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

        private bool TIPO_PAGOExists(string id)
        {
            return _context.TIPO_PAGO.Any(e => e.TIP_ID == id);
        }
    }
}
