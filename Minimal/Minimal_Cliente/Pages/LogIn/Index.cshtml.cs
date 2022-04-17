using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Minimal_Cliente.Pages.LogIn
{
    public class IndexModel : PageModel
    {
        //private readonly UserManager<IdentityUser> userManager;
        //private readonly SignInManager<IdentityUser> signInManager;

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
        //Inicio de sesion Ximena Caceres
        /*
        private readonly Minimal_Cliente.Data.MinimalContext _context;

        public IndexModel(Minimal_Cliente.Data.MinimalContext context)
        {
            _context = context;
        }
        public IList<CLIENTE> CLIENTE { get; set; }

        public async Task OnGetAsync()
        {
            CLIENTE = await _context.CLIENTE.ToListAsync();
        }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(string returnURL = null)
        {
            if (ModelState.IsValid)
            {
                foreach ( item in Credencial)
                {

                }
                if (identityResult.Succeeded)
                {
                    if (returnURL == null || returnURL == "/")
                    {
                        return RedirectToPage("Index");
                    }
                    else
                    {
                        return RedirectToPage(returnURL);
                    }
                }
                ModelState.AddModelError("", "Usuario o Contraseña Incorrecta");
            }
            return Page();
        }
        */

        //Registro
        /*public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser()
                {
                    UserName = Credencial.Usuario,
                    PasswordHash = Credencial.Contrasena
                };
                var result = await userManager.CreateAsync(user, Credencial.Contrasena);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToPage("Index");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return Page();
        }*/
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
