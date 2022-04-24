﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minimal.Models;
using Minimal_Cliente.Data;
using Minimal_Cliente.Models.Access;

namespace Minimal_Cliente.Pages.Carrito
{
    public class IndexModel : PageModel
    {
        private ProductoAccess productoAccess;

        public IndexModel(Minimal_Cliente.Data.Minimal_ClienteContext context)
        {
            productoAccess = new ProductoAccess(context);
        }

        public List<PRODUCTO> ListaProductos { get;set; }
        /*
        public async Task OnGetAsync()
        {
            ListaProductos = await _context.PRODUCTO.ToListAsync();
        }
        */
        public void OnGet()
        {
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "alert('Test Event');", true);
            string[] tempIds = new string[] { "DEPNEG8" };
            ListaProductos = (List<PRODUCTO>)productoAccess.getProductosPorId(tempIds);
        }
    }
}