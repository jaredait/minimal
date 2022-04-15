using Minimal.Models;
using Minimal_Cliente.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.Access
{
    public class ProductoAccess : IProductoAccess
    {
        private readonly Minimal_ClienteContext _contexto;
        public List<PRODUCTO> ListaProductos { get; set; }

        public ProductoAccess(Minimal_ClienteContext contexto)
        {
            _contexto = contexto;
            ListaProductos = new List<PRODUCTO>();
        }

        public IEnumerable<PRODUCTO> getProductosPorId(string[] ids)
        {
            try
            {
                PRODUCTO productoTemp;

                if(ids.Length > 0)
                {
                    // iterar por cada id para obtener los productos
                    foreach (string id in ids)
                    {
                        productoTemp = _contexto.PRODUCTO.Where(p => p.PRD_ID == id).FirstOrDefault();
                        if (productoTemp == null)
                        {
                            throw new NullReferenceException();
                        }
                        ListaProductos.Add(productoTemp);
                    }
                }
                return ListaProductos;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
