using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minimal.Models;
using Minimal_Cliente.Data;

namespace Minimal_Cliente.Pages.LogIn.Cliente
{
    public class IndexModel : PageModel
    {
        private readonly Minimal_Cliente.Data.Minimal_ClienteContext _context;

        public IndexModel(Minimal_Cliente.Data.Minimal_ClienteContext context)
        {
            _context = context;
        }

        public IList<CLIENTE> CLIENTE { get;set; }

        public async Task OnGetAsync()
        {
            CLIENTE = await _context.CLIENTE.ToListAsync();
        }
    }
}
