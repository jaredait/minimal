using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Minimal.Models;
using Minimal_Cliente.Data;
using Minimal_Cliente.Models;

namespace Minimal_Cliente.Pages.Tienda
{
    public class CreateModel : PageModel
    {
        private readonly Minimal_Cliente.Data.Minimal_ClienteContext _context;

        public CreateModel(Minimal_Cliente.Data.Minimal_ClienteContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PRODUCTO PRODUCTO { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PRODUCTO.Add(PRODUCTO);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
