using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minimal.Data;
using Minimal.Models;

namespace Minimal.Pages.Factura
{
    public class DetailsModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;

        public DetailsModel(Minimal.Data.MinimalContext context)
        {
            _context = context;
        }

        public FACTURA FACTURA { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FACTURA = await _context.FACTURA.FirstOrDefaultAsync(m => m.FAC_NUMERO == id);

            if (FACTURA == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
