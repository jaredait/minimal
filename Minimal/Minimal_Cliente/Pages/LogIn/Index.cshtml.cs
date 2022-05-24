using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Minimal.Models;
using Minimal_Cliente.Models;
using Minimal_Cliente.Models.Access;

namespace Minimal_Cliente.Pages.LogIn
{
    public class IndexModel : PageModel
    {
        //private readonly UserManager<IdentityUser> userManager;
        //private readonly SignInManager<IdentityUser> signInManager;
        private SessionAccess sessionAccess;

        public IndexModel(Minimal_Cliente.Data.Minimal_ClienteContext context)
        {
            sessionAccess = new SessionAccess(context);
        }
        public CLIENTE cliente { get; set; }
        [BindProperty]
        public string nombreUsuario { get; set; }

        [BindProperty]
        public Credencial Credencial { get; set; }
        /*public IndexModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser>signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }*/
        public void OnGet()
        {
        }
        public string obtenerUsuario()
        {
            string cli_usuario = Credencial.Usuario;
            string cli_contrasena = Credencial.Contrasena;
            cliente = sessionAccess.getClientePorId(cli_usuario, cli_contrasena);
            return cliente.CLI_NOMBRE.ToString();
        }
        public IActionResult OnPost()
        {
            string cli_usuario = Credencial.Usuario;
            string cli_contrasena = Credencial.Contrasena;
            cliente = sessionAccess.getClientePorId(cli_usuario , cli_contrasena);
             //nombreUsuario = obtenerUsuario();
            if (cliente != null)
            {
                return RedirectToPage("/Tienda/Index", new { id = Credencial.Usuario}) ;
            }
            else
            {
                ModelState.AddModelError("", "Usuario o Contraseņa Incorrecta");
            }
            return Page();
        }
    }
    public class Credencial
    {
        [Required]
        public string Usuario { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }
    }
}
