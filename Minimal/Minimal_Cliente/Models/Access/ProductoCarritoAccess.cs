using Minimal.Models;
using Minimal_Cliente.Data;
using Minimal_Cliente.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.Access
{
    public class ProductoCarritoAccess : IProductoCarritoAccess
    {
        private List<ProductoCarritoViewModel> listaProductoCarrito;
        private Minimal_ClienteContext _contexto;

        public ProductoCarritoAccess(Minimal_ClienteContext contexto)
        {
            _contexto = contexto;
            listaProductoCarrito = new List<ProductoCarritoViewModel>();
        }

        public ProductoCarritoViewModel GetProductoCarritoPorId(int id)
        {
            PRODUCTO productoTemp;
            CARRITO carritoTemp;

            carritoTemp = _contexto.CARRITO.Where(c => c.CAR_ID == id).FirstOrDefault();
            productoTemp = _contexto.PRODUCTO.Where(p => p.PRD_ID == carritoTemp.PRD_ID).FirstOrDefault();

            return new ProductoCarritoViewModel()
            {
                CAR_ID = carritoTemp.CAR_ID,
                CLI_USUARIO = carritoTemp.CLI_USUARIO,
                PRD_ID = carritoTemp.PRD_ID,
                CAR_CANTIDAD = carritoTemp.CAR_CANTIDAD,
                PRD_PRECIO = productoTemp.PRD_PRECIO,
                PRD_PESO = productoTemp.PRD_PESO,
                PRD_DESCRIPCION = productoTemp.PRD_DESCRIPCION,
                PRD_RUTA_IMAGEN = productoTemp.PRD_RUTA_IMAGEN
            };
        }

        /// <summary>
        /// Este metodo se usa para obtener la lista de productos con un formato de presentacion en el carrito de compras
        /// </summary>
        /// <param name="listaCarrito">Lista de objetos CARRITO que se desea obtener el formato para el view model</param>
        /// <returns>Lista de objetos con formato de view model</returns>
        public IEnumerable<ProductoCarritoViewModel> GetListaProductoCarrito(IEnumerable<CARRITO> listaCarrito)
        {
            PRODUCTO productoTemp = new PRODUCTO();
            CARRITO carritoTemp = new CARRITO();

            foreach (CARRITO item in listaCarrito)
            {
                productoTemp = _contexto.PRODUCTO.Where(p => p.PRD_ID == item.PRD_ID).FirstOrDefault();

                ProductoCarritoViewModel productoCarritoTemp = new ProductoCarritoViewModel()
                {
                    CAR_ID = item.CAR_ID,
                    CLI_USUARIO = item.CLI_USUARIO,
                    PRD_ID = item.PRD_ID,
                    CAR_CANTIDAD = item.CAR_CANTIDAD,
                    PRD_PRECIO = productoTemp.PRD_PRECIO,
                    PRD_PESO = productoTemp.PRD_PESO,
                    PRD_DESCRIPCION = productoTemp.PRD_DESCRIPCION,
                    PRD_RUTA_IMAGEN = productoTemp.PRD_RUTA_IMAGEN
                };

                listaProductoCarrito.Add(productoCarritoTemp);
            }

            return listaProductoCarrito;
        }
    }
}
