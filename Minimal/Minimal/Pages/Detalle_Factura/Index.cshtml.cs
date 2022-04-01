using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minimal.Data;
using Minimal.Models;

namespace Minimal.Pages.Detalle_Factura
{
    public class IndexModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;

        public IndexModel(Minimal.Data.MinimalContext context)
        {
            _context = context;
        }

        public IList<DETALLE_FACTURA> DETALLE_FACTURA { get;set; }

        public async Task OnGetAsync()
        {
            DETALLE_FACTURA = await _context.DETALLE_FACTURA.ToListAsync();
        }
    }
}
