using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minimal.Data;
using Minimal.Models;

namespace Minimal.Pages.Categoria_Producto
{
    public class DeleteModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;

        public DeleteModel(Minimal.Data.MinimalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CATEGORIA_PRODUCTO CATEGORIA_PRODUCTO { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CATEGORIA_PRODUCTO = await _context.CATEGORIA_PRODUCTO.FirstOrDefaultAsync(m => m.CAT_ID == id);

            if (CATEGORIA_PRODUCTO == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CATEGORIA_PRODUCTO = await _context.CATEGORIA_PRODUCTO.FindAsync(id);

            if (CATEGORIA_PRODUCTO != null)
            {
                _context.CATEGORIA_PRODUCTO.Remove(CATEGORIA_PRODUCTO);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
