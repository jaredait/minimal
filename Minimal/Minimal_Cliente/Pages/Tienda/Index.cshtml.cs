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

namespace Minimal_Cliente.Pages.Tienda
{
    public class IndexModel : PageModel
    {
        private readonly Minimal_Cliente.Data.Minimal_ClienteContext _context;

        public IndexModel(Minimal_Cliente.Data.Minimal_ClienteContext context)
        {
            _context = context;
        }
        public string nombreUsuario { get; set; }
        public IList<PRODUCTO> listaProductos { get;set; }
        public CLIENTE CLIENTE { get; private set; }

        
        public async Task OnGetAsync(string id)
        {
            listaProductos = await _context.PRODUCTO.ToListAsync();
            
            if (!String.IsNullOrEmpty(id))
            {
                string id2 = id;
                CLIENTE = await _context.CLIENTE.FirstOrDefaultAsync(m => m.CLI_USUARIO == id);
                nombreUsuario = CLIENTE.CLI_NOMBRE;
            }
        }
    }
}
