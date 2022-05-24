using Minimal.Models;
using Minimal_Cliente.Models.Access;
using Minimal_Cliente.RepositorioDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.Models.AccessLocal
{
    public class ProductoAccessLocal : IProductoAccess
    {
        public IEnumerable<PRODUCTO> getProductosPorId(string[] ids)
        {
            RepositorioProducto repositorioProducto = new RepositorioProducto();
            List<PRODUCTO> listaProductos =  repositorioProducto.ListaProductos;
            List<PRODUCTO> listaRetorno =  new List<PRODUCTO>();
            foreach (string id in ids)
            {
                listaRetorno.Add(listaProductos.Where(p => p.PRD_ID == id).FirstOrDefault());
            }
            return listaRetorno;
        }
    }
}
