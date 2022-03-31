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
    public class DetailsModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;

        public DetailsModel(Minimal.Data.MinimalContext context)
        {
            _context = context;
        }

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
    }
}
