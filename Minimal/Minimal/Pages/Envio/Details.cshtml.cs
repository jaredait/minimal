using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minimal.Data;
using Minimal.Models;

namespace Minimal.Pages.Envio
{
    public class DetailsModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;

        public DetailsModel(Minimal.Data.MinimalContext context)
        {
            _context = context;
        }

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
    }
}
