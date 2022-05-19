using Microsoft.EntityFrameworkCore;
using Minimal_Cliente.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.Access
{
    public class CarritoAccess : ICarritoAccess
    {
        private readonly Minimal_ClienteContext _contexto;
        public List<CARRITO> ListaCarrito { get; set; }

        public CarritoAccess(Minimal_ClienteContext contexto)
        {
            _contexto = contexto;
            ListaCarrito = new List<CARRITO>();
        }

        public bool AddProducto(CARRITO carritoNuevo)
        {
            // Es necesario operar como una transaccion porque la llave primaria de la tabla
            // CARRITO es una columna identidad (atributo autoincremental)

            try
            {
                using (var transaccion = _contexto.Database.BeginTransaction())
                {
                    string query = $"INSERT INTO CARRITO VALUES('{carritoNuevo.CLI_USUARIO}', '{carritoNuevo.PRD_ID}', {carritoNuevo.CAR_CANTIDAD})";
                    _contexto.Database.ExecuteSqlRaw(query);
                    _contexto.SaveChanges();
                    transaccion.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public List<CARRITO> GetProductos(string CLI_USUARIO)
        {
            return _contexto.CARRITO.Where(c => c.CLI_USUARIO == CLI_USUARIO).ToList();
        }

        public CARRITO GetCarritoPorId(int id)
        {
            return _contexto.CARRITO.Where(c => c.CAR_ID == id).FirstOrDefault();
        }

        public bool UpdateCarrito(CARRITO carritoActualizado)
        {
            CARRITO carritoTemp = GetCarritoPorId(carritoActualizado.CAR_ID);
            carritoTemp.CAR_CANTIDAD = carritoActualizado.CAR_CANTIDAD;
            _contexto.SaveChanges();
            return true;

        }

        public bool CarritoExiste(CARRITO carritoExistente)
        {
            CARRITO carritoTemp = _contexto.CARRITO.Where(c => c.CLI_USUARIO == carritoExistente.CLI_USUARIO &&
            c.PRD_ID == carritoExistente.PRD_ID).FirstOrDefault();

            return carritoTemp == null ? false : true;
        }

        public void AgregarUno(CARRITO carritoAgregar)
        {
            CARRITO carritoTemp = _contexto.CARRITO.Where(c => c.CLI_USUARIO == carritoAgregar.CLI_USUARIO &&
                        c.PRD_ID == carritoAgregar.PRD_ID).FirstOrDefault();
            carritoTemp.CAR_CANTIDAD++;
            _contexto.SaveChanges();
        }

        public bool EliminarProducto(int id)
        {
            CARRITO carritoTemp = GetCarritoPorId(id);
            _contexto.CARRITO.Remove(carritoTemp);
            _contexto.SaveChanges();
            return true;
        }

        public void LimpiarCarrito(string id)
        {
            List<CARRITO> listaCarritoTemp = GetProductos(id);
            foreach(CARRITO carritoTemp in listaCarritoTemp)
            {
                _contexto.CARRITO.Remove(carritoTemp);
                _contexto.SaveChanges();
            }
        }
    }
}
