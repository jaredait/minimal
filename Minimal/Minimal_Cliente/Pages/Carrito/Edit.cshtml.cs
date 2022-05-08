using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Minimal_Cliente.Data;
using Minimal_Cliente.Models;
using Minimal_Cliente.Models.Access;
using Minimal_Cliente.Models.ViewModels;

namespace Minimal_Cliente.Pages.Carrito
{
    public class EditModel : PageModel
    {
        private readonly Minimal_Cliente.Data.Minimal_ClienteContext _context;

        public EditModel(Minimal_Cliente.Data.Minimal_ClienteContext context)
        {
            _context = context;
            productoCarritoAccess = new ProductoCarritoAccess(context);
            carritoAccess = new CarritoAccess(context);
        }

        [BindProperty]
        public CARRITO carritoEdit { get; set; }
        [BindProperty]
        public ProductoCarritoViewModel productoCarrito { get; set; }

        private IProductoCarritoAccess productoCarritoAccess;
        private ICarritoAccess carritoAccess;

        public void OnGet(int? id)
        {
            carritoEdit = carritoAccess.GetCarritoPorId(Convert.ToInt32(id));
            productoCarrito = productoCarritoAccess.GetProductoCarritoPorId(Convert.ToInt32(id));
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public void OnPost()
        {
            carritoEdit = carritoAccess.GetCarritoPorId(carritoEdit.CAR_ID);
            CARRITO carritoTemp = new CARRITO()
            {
                CAR_ID = carritoEdit.CAR_ID,
                PRD_ID = carritoEdit.PRD_ID,
                CLI_USUARIO = carritoEdit.CLI_USUARIO,
                CAR_CANTIDAD = productoCarrito.CAR_CANTIDAD
            };
            carritoAccess.UpdateCarrito(carritoTemp);
        }
    }
}
