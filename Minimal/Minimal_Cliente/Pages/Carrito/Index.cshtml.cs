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
using Minimal_Cliente.Models.Access;

namespace Minimal_Cliente.Pages.Carrito
{
    public class IndexModel : PageModel
    {
        private ProductoAccess productoAccess;
        public CarritoAccess carritoAccess;

        public IndexModel(Minimal_Cliente.Data.Minimal_ClienteContext context)
        {
            productoAccess = new ProductoAccess(context);
            carritoAccess = new CarritoAccess(context);
        }

        public List<PRODUCTO> ListaProductos { get;set; }
        public List<CARRITO> ListaCarrito { get; set; }
        /*
        public async Task OnGetAsync()
        {
            ListaProductos = await _context.PRODUCTO.ToListAsync();
        }
        */
        public void OnGet()
        {
            ListaCarrito = carritoAccess.getProductos("1710218475");

        }
    }
}
