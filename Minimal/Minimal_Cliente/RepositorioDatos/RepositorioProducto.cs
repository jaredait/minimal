using Minimal.Models;
using Minimal_Cliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.RepositorioDatos
{
    public class RepositorioProducto
    {
        public RepositorioProducto()
        {
            ListaProductos = new List<PRODUCTO>();
            CargarDatos();
        }

        public List<PRODUCTO> ListaProductos { get; set; }

        private void CargarDatos()
        {
            ListaProductos.Add(new PRODUCTO
            {
                PRD_ID = "CAMNEGM",
                PRD_DESCRIPCION = "Camiseta",
                PRD_FECHA_CREACION = Convert.ToDateTime("2022-04-03"),
                PRD_NOMBRE = "Camiseta",
                PRD_PESO = 100,
                PRD_PRECIO = 15.99M,
                PRD_RUTA_IMAGEN = "camiseta-negra.jpg",
                PRD_STOCK = 100
            });

            ListaProductos.Add(new PRODUCTO
            {
                PRD_ID = "MEDROJ1012",
                PRD_DESCRIPCION = "Medias rojas talla 10-12",
                PRD_FECHA_CREACION = Convert.ToDateTime("2022-04-03"),
                PRD_NOMBRE = "Medias",
                PRD_PESO = 50,
                PRD_PRECIO = 9.99M,
                PRD_RUTA_IMAGEN = "red-socks.jpg",
                PRD_STOCK = 74
            });
        }
    }
}
