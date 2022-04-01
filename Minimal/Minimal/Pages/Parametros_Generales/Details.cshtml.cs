using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minimal.Data;
using Minimal.Models;

namespace Minimal.Pages.Parametros_Generales
{
    public class DetailsModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;

        public DetailsModel(Minimal.Data.MinimalContext context)
        {
            _context = context;
        }

        public PARAMETROS_GENERALES PARAMETROS_GENERALES { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PARAMETROS_GENERALES = await _context.PARAMETROS_GENERALES.FirstOrDefaultAsync(m => m.PAR_NOMBRE == id);

            if (PARAMETROS_GENERALES == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
