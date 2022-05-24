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
using Minimal_Cliente.Models;

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
            CLIENTE.CLI_CONTRASENA = GenerarContrasena();
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.CLIENTE.Add(CLIENTE);
            await _context.SaveChangesAsync();
            SendEmail(CLIENTE.CLI_NOMBRE, CLIENTE.CLI_EMAIL, CLIENTE.CLI_CONTRASENA);

            return RedirectToPage("../Index");
        }

        public void SendEmail(string user, string email, string contrasena)
        {
            using(MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("soyminimalstreetwear@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Usuario y Contraseña Minimal";
                mail.Body = $"Hola {user}, Gracias por formar parte de Minimal </br> " +
                    $"Su contraseña temporal de ingreso es: {contrasena}. </br> " +
                    $"Por su seguridad, una vez ingrese al sistema cambie su contraseña.";
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("soyminimalstreetwear@gmail.com", "proyectosusy2022");
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
