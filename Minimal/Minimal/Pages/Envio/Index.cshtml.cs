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
    public class IndexModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;

        public IndexModel(Minimal.Data.MinimalContext context)
        {
            _context = context;
        }

        public IList<ENVIO> ENVIO { get;set; }

        public async Task OnGetAsync()
        {
            ENVIO = await _context.ENVIO.ToListAsync();
        }
    }
}
