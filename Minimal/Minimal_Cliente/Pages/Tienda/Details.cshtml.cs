using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minimal.Models;
using Minimal_Cliente.Data;
using Minimal_Cliente.Models;

namespace Minimal_Cliente.Pages.Tienda
{
    public class DetailsModel : PageModel
    {
        private readonly Minimal_Cliente.Data.Minimal_ClienteContext _context;

        public DetailsModel(Minimal_Cliente.Data.Minimal_ClienteContext context)
        {
            _context = context;
        }

        public PRODUCTO PRODUCTO { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PRODUCTO = await _context.PRODUCTO.FirstOrDefaultAsync(m => m.PRD_ID == id);

            if (PRODUCTO == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
