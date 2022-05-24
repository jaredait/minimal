﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Minimal.Data;
using Minimal.Models;

namespace Minimal.Pages.Carrito
{
    public class CreateModel : PageModel
    {
        private readonly Minimal.Data.MinimalContext _context;

        public CreateModel(Minimal.Data.MinimalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CARRITO CARRITO { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CARRITO.Add(CARRITO);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}