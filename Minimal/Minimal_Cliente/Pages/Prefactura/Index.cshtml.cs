using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Minimal_Cliente.Data;
using Minimal_Cliente.Models;
using Minimal_Cliente.Models.Access;
using Minimal_Cliente.Models.ViewModels;

namespace Minimal_Cliente.Pages.Prefactura
{
    public class IndexModel : PageModel
    {
        public IProductoCarritoAccess productoCarritoAccess;
        public CarritoAccess carritoAccess;
        public Tipo_PagoAccess tipo_PagoAccess;
        public IFacturacionAccess facturacionAccess;
        public IClienteAccess clienteAccess;

        public IndexModel(Minimal_Cliente.Data.Minimal_ClienteContext context)
        {
            productoCarritoAccess = new ProductoCarritoAccess(context);
            carritoAccess = new CarritoAccess(context);
            tipo_PagoAccess = new Tipo_PagoAccess(context);
            facturacionAccess = new FacturacionAccess(context);
            clienteAccess = new ClienteAccess(context);
        }

        [BindProperty]
        public string tipo_pago_seleccionado { get; set; }
        [BindProperty]
        public string tarjetaNumero { get; set; }
        [BindProperty]
        public string tarjetaPropietario { get; set; }
        [BindProperty]
        public string tarjetaFechaCaducidad { get; set; }
        [BindProperty]
        public string tarjetaCVV { get; set; }
        [BindProperty]
        public decimal subtotal { get; set; }
        [BindProperty]
        public decimal total { get; set; }
        [BindProperty]
        public string idUsuario { get; set; }


        public List<ProductoCarritoViewModel> ListaProductoCarrito { get; set; }
        public List<CARRITO> ListaCarrito { get; set; }
        public List<TIPO_PAGO> ListaTipoPago { get; set; }

        public void OnGet(string id)
        {
            ListaCarrito = carritoAccess.GetProductos(id);
            ListaProductoCarrito = (List<ProductoCarritoViewModel>)productoCarritoAccess.GetListaProductoCarrito(ListaCarrito);
            ListaTipoPago = (List<TIPO_PAGO>)tipo_PagoAccess.GetListaTipoPago();            
        }

        public IActionResult OnPost()
        {
            string id = idUsuario;
            ListaCarrito = carritoAccess.GetProductos(id);
            FACTURA factura = new FACTURA()
            {
                CLI_USUARIO = ListaCarrito[0].CLI_USUARIO,
                TIP_ID = tipo_pago_seleccionado,
            };
            facturacionAccess.RegistrarVenta(factura, ListaCarrito);
            carritoAccess.LimpiarCarrito(idUsuario);
            CLIENTE clienteTemp = clienteAccess.obtenerClientePorId(idUsuario);
            SendEmail(clienteTemp.CLI_NOMBRE, clienteTemp.CLI_EMAIL, CrearContenidoEmail(factura));

            return RedirectToPage("/Tienda/Index", new { id });
        }

        private string CrearContenidoEmail(FACTURA f)
        {
            string contenido = 
                    $"<p>Te informamos de una nueva compra.</p>" +
                    $"<p>Fecha y hora: {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}</p>" +
                    $"<p>Transacción: Compra comercio electrónico Minimal Streetwear</p>" +
                    $"<p><b>Detalle</b></p>" +
                    $"<p><b>Valor: </b>USD {Math.Round(facturacionAccess.ObtenerTotalListaCarrito(ListaCarrito), 2)}</p>" +
                    $"<p></p>" +
                    $"<p>- Minimal.</p>";

            return contenido;
        }

        public void SendEmail(string user, string email, string contenido)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("soyminimalstreetwear@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Facturación electrónica";
                mail.Body = $"<p>Hola {user},</p> " + contenido;
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
    }
}
