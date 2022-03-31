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

namespace Minimal.Pages.Envio
{
    public class EditModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;

        public EditModel(Minimal.Data.MinimalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ENVIO ENVIO { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ENVIO = await _context.ENVIO.FirstOrDefaultAsync(m => m.ENV_NUMERO == id);

            if (ENVIO == null)
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

            _context.Attach(ENVIO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ENVIOExists(ENVIO.ENV_NUMERO))
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

        private bool ENVIOExists(string id)
        {
            return _context.ENVIO.Any(e => e.ENV_NUMERO == id);
        }
    }
}
