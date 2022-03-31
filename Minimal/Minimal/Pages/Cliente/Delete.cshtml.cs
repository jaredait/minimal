using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minimal.Data;
using Minimal.Models;

namespace Minimal.Pages.Cliente
{
    public class DeleteModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;

        public DeleteModel(Minimal.Data.MinimalContext context)
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CLIENTE = await _context.CLIENTE.FindAsync(id);

            if (CLIENTE != null)
            {
                _context.CLIENTE.Remove(CLIENTE);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
