using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Minimal.Models;
using Minimal_Cliente.Data;
using Minimal_Cliente.Models;

namespace Minimal_Cliente.Pages.LogIn.Cliente
{
    public class EditModel : PageModel
    {
        private readonly Minimal_Cliente.Data.Minimal_ClienteContext _context;

        public EditModel(Minimal_Cliente.Data.Minimal_ClienteContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CLIENTE CLIENTE { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CLIENTE = await _context.CLIENTE.FirstOrDefaultAsync(m => m.CLI_USUARIO == id);

            if (CLIENTE == null)
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

            _context.Attach(CLIENTE).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CLIENTEExists(CLIENTE.CLI_USUARIO))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("/Tienda/Index");
        }

        private bool CLIENTEExists(string id)
        {
            return _context.CLIENTE.Any(e => e.CLI_USUARIO == id);
        }
    }
}
