using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minimal.Models;
using Minimal_Cliente.Data;
using Minimal_Cliente.Models.Access;

namespace Minimal_Cliente.Pages.TiendaProductos
{
    public class IndexModel : PageModel
    {
        private readonly Minimal_Cliente.Data.Minimal_ClienteContext _context;
        private CarritoAccess carritoAccess;

        public IndexModel(Minimal_Cliente.Data.Minimal_ClienteContext context)
        {
            _context = context;
            carritoAccess = new CarritoAccess(context);
        }

        public IList<PRODUCTO> PRODUCTO { get;set; }

        public async Task OnGetAsync()
        {
            PRODUCTO = await _context.PRODUCTO.ToListAsync();
        }

        public void OnPostAgregarCarrito()
        {
            int x = 2;
            int y = x;
        }

        public IActionResult onPost()
        {
            int x = 2;
            int y = x;
            return Page();
        }
    }
}
