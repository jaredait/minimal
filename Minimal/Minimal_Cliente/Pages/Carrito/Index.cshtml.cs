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
using Minimal_Cliente.Models.ViewModels;

namespace Minimal_Cliente.Pages.Carrito
{
    public class IndexModel : PageModel
    {
        public IProductoCarritoAccess productoCarritoAccess;
        public CarritoAccess carritoAccess;

        public IndexModel(Minimal_Cliente.Data.Minimal_ClienteContext context)
        {
            productoCarritoAccess = new ProductoCarritoAccess(context);
            carritoAccess = new CarritoAccess(context);
        }

        public List<ProductoCarritoViewModel> ListaProductoCarrito { get;set; }
        public List<CARRITO> ListaCarrito { get; set; }

        public void OnGet(string id)
        {
            ListaCarrito = carritoAccess.getProductos(id);

            ListaProductoCarrito = (List<ProductoCarritoViewModel>)productoCarritoAccess.GetProductoCarritoViewModels(ListaCarrito);
        }
    }
}
