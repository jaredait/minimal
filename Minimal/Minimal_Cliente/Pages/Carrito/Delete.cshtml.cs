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

namespace Minimal_Cliente.Pages.Carrito
{
    public class DeleteModel : PageModel
    {
        private readonly Minimal_Cliente.Data.Minimal_ClienteContext _context;

        public DeleteModel(Minimal_Cliente.Data.Minimal_ClienteContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CARRITO CARRITO { get; set; }
        public IProductoCarritoAccess productoCarritoAccess;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // aqui consultar el objeto ProducoCarrito y mostrarlo en la vista
            CARRITO = await _context.CARRITO.FirstOrDefaultAsync(m => m.CAR_ID == id);

            if (CARRITO == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CARRITO = await _context.CARRITO.FindAsync(id);

            if (CARRITO != null)
            {
                _context.CARRITO.Remove(CARRITO);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
