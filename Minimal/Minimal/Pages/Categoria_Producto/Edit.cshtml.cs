using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Minimal.Data;
using Minimal.Models;

namespace Minimal.Pages.Categoria_Producto
{
    public class EditModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;

        public EditModel(Minimal.Data.MinimalContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CATEGORIA_PRODUCTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CATEGORIA_PRODUCTOExists(CATEGORIA_PRODUCTO.CAT_ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CATEGORIA_PRODUCTOExists(string id)
        {
            return _context.CATEGORIA_PRODUCTO.Any(e => e.CAT_ID == id);
        }
    }
}
