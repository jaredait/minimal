using Microsoft.EntityFrameworkCore;
using Minimal.Models;
using Minimal_Cliente.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.Access
{
    public class FacturacionAccess : IFacturacionAccess
    {
        private readonly Minimal_ClienteContext _contexto;

        public FacturacionAccess(Minimal_ClienteContext contexto)
        {
            _contexto = contexto;
        }

        public void RegistrarVenta(FACTURA f, List<CARRITO> listaProductos)
        {
            CLIENTE cliente = _contexto.CLIENTE.Where(c => c.CLI_USUARIO == f.CLI_USUARIO).FirstOrDefault();

            // completar propiedades del objeto factura
            f.ENV_NUMERO = "1";
            f.FAC_FECHA = DateTime.Now;
            f.FAC_DIRECCION_CLI = cliente.CLI_DIRECCION;
            f.FAC_EMAIL_CLI = cliente.CLI_EMAIL;

            try
            {
                using (var transaccion = _contexto.Database.BeginTransaction())
                {
                    string query = $"INSERT INTO FACTURA VALUES('{f.CLI_USUARIO}', '{f.TIP_ID}', '{f.ENV_NUMERO}', '{f.FAC_FECHA}', '{f.FAC_DIRECCION_CLI}', '{f.FAC_EMAIL_CLI}', {f.FAC_MONTO_SUBTOTAL}, {f.FAC_MONTO_TOTAL})";
                    _contexto.Database.ExecuteSqlRaw(query);
                    _contexto.SaveChanges();
                    transaccion.Commit();
                }
                RegistrarProductos(f, listaProductos);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private void RegistrarProductos(FACTURA factura, List<CARRITO> listaCarrito)
        {
            FACTURA facturaTemp = _contexto.FACTURA
                                    .FromSqlRaw($"SELECT * FROM FACTURA WHERE FAC_FECHA = '{factura.FAC_FECHA}' AND CLI_USUARIO = '{factura.CLI_USUARIO}'")
                                    .FirstOrDefault();

            foreach (CARRITO item in listaCarrito)
            {
                PRODUCTO productoTemp = _contexto.PRODUCTO.Where(p => p.PRD_ID == item.PRD_ID).FirstOrDefault();
                using (var transaccion = _contexto.Database.BeginTransaction())
                {
                    string query = $"INSERT INTO DETALLE_FACTURA VALUES('{item.PRD_ID}', {facturaTemp.FAC_NUMERO}, {productoTemp.PRD_PRECIO}, {item.CAR_CANTIDAD})";
                    _contexto.Database.ExecuteSqlRaw(query);
                    _contexto.SaveChanges();
                    transaccion.Commit();
                }
            }
        }

        public decimal ObtenerTotalListaCarrito(List<CARRITO> listaCarrito)
        {
            decimal total = 0M;
            foreach (CARRITO item in listaCarrito)
            {
                PRODUCTO productoTemp = _contexto.PRODUCTO.Where(p => p.PRD_ID == item.PRD_ID).FirstOrDefault();
                total += productoTemp.PRD_PRECIO;
            }
            return total;
        }
    }
}
