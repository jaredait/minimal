using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minimal_Cliente.Data;
using Minimal_Cliente.Models;
using Minimal_Cliente.Models.Access;
using Minimal_Cliente.Models.ViewModels;

namespace Minimal_Cliente.Pages.Carrito
{
    public class DeleteModel : PageModel
    {
        private readonly Minimal_Cliente.Data.Minimal_ClienteContext _context;

        public DeleteModel(Minimal_Cliente.Data.Minimal_ClienteContext context)
        {
            _context = context;
            productoCarritoAccess = new ProductoCarritoAccess(context);
            carritoAccess = new CarritoAccess(context);
        }

        [BindProperty]
        public CARRITO carritoDelete { get; set; }
        [BindProperty]
        public ProductoCarritoViewModel productoCarrito { get; set; }
        [BindProperty]
        public string idUsuario { get; set; }

        private IProductoCarritoAccess productoCarritoAccess;
        private ICarritoAccess carritoAccess;

        public void OnGet(int? id)
        {
            carritoDelete = carritoAccess.GetCarritoPorId(Convert.ToInt32(id));
            productoCarrito = productoCarritoAccess.GetProductoCarritoPorId(Convert.ToInt32(id));
        }

        public RedirectResult OnPost(int id)
        {
            carritoAccess.EliminarProducto(id);
            return Redirect($"/Carrito?id={idUsuario}");
        }
    }
}
