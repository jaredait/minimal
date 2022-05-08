using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Minimal.Models;
using Minimal_Cliente.Data;
using Minimal_Cliente.Models;
using Minimal_Cliente.Models.Access;

namespace Minimal_Cliente.Pages.Tienda
{
    public class EditModel : PageModel
    {
        private readonly Minimal_Cliente.Data.Minimal_ClienteContext _context;

        public EditModel(Minimal_Cliente.Data.Minimal_ClienteContext context)
        {
            _context = context;
            carritoAccess = new CarritoAccess(context);
            carrito = new CARRITO();
        }

        [BindProperty]
        public PRODUCTO productoEdit { get; set; }
        [BindProperty]
        public string idUsuario { get; set; }
        public CARRITO carrito;

        private ICarritoAccess carritoAccess;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            productoEdit = await _context.PRODUCTO.FirstOrDefaultAsync(m => m.PRD_ID == id);

            if (productoEdit == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            carrito.CLI_USUARIO = idUsuario;
            carrito.PRD_ID = productoEdit.PRD_ID;

            if (carritoAccess.CarritoExiste(carrito))
            {
                carritoAccess.AgregarUno(carrito);
            }
            else
            {
                carritoAccess.AddProducto(carrito);
            }


            return RedirectToPage("./Index");
        }
    }
}
