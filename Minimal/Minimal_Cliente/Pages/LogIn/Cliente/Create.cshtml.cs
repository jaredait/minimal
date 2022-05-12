using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Minimal.Models;
using Minimal_Cliente.Data;

namespace Minimal_Cliente.Pages.LogIn.Cliente
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
        public CLIENTE CLIENTE { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            CLIENTE.CLI_CONTRASENA = GenerarContrasena();
            _context.CLIENTE.Add(CLIENTE);
            await _context.SaveChangesAsync();
            SendEmail(CLIENTE.CLI_NOMBRE, CLIENTE.CLI_EMAIL, CLIENTE.CLI_CONTRASENA);

            return RedirectToPage("./Index");
        }

        public void SendEmail(string user, string email, string contrasena)
        {
            using(MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("garciaandres3d@gmail.com");
                mail.To.Add(email);
                mail.Body = $"Hola {user}, la clave para que pueda ingresar a Minimal es la siguiente: {contrasena}. </br> Una vez que haya ingresado podrá cambiar su clave.";
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("garciaandres3d@gmail.com", "970baby");
                    smtp.Send(mail);
                }
            }
        }

        public string GenerarContrasena()
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int longitud = caracteres.Length;
            char letra;
            int longitudContrasenia = 10;
            string contraseniaAleatoria = string.Empty;
            for (int i = 0; i < longitudContrasenia; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                contraseniaAleatoria += letra.ToString();
            }
            return contraseniaAleatoria;
        }
    }
}
