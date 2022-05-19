using System;
using System.Collections.Generic;
using System.Linq;
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

        public IndexModel(Minimal_Cliente.Data.Minimal_ClienteContext context)
        {
            productoCarritoAccess = new ProductoCarritoAccess(context);
            carritoAccess = new CarritoAccess(context);
            tipo_PagoAccess = new Tipo_PagoAccess(context);
            facturacionAccess = new FacturacionAccess(context);
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
                FAC_MONTO_SUBTOTAL = subtotal,
                FAC_MONTO_TOTAL = total
            };
            facturacionAccess.RegistrarVenta(factura, ListaCarrito);
            carritoAccess.LimpiarCarrito(idUsuario);

            return RedirectToPage("/Tienda/Index", new { miParametro = 99 });
        }
    }
}
