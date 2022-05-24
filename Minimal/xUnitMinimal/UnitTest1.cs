using Minimal_Cliente.Models;
using Minimal_Cliente.Models.AccessLocal;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace xUnitMinimal
{
    public class UnitTest1
    {
        [Fact] 
        public void TestObtenerClientePorId()
        {
            ClienteAccessLocal clienteAccessLocal = new ClienteAccessLocal();
            CLIENTE clienteObtenido = clienteAccessLocal.obtenerClientePorId("1710218475");
            CLIENTE clientePrueba = new CLIENTE
            {
                CLI_USUARIO = "1710218475",
                CLI_CONTRASENA = "Jampudiam8528",
                CLI_CEDULA_RUC = "1710218475",
                CLI_EMAIL = "jaredampudia@gmail.com",
                CLI_NOMBRE = "Jared",
                CLI_APELLIDO = "Ampudia",
                CLI_EDAD = 24,
                CLI_SEXO = 'M',
                CLI_DIRECCION = "Armenia 1, Alfredo Baquerizo Moreno y Pablo Palacios",
                CLI_CIUDAD = "Quito",
                CLI_PROVINCIA = "Pichincha",
                CLI_TELEFONO = "0986257891"
            };
            Assert.True(CompararClientes(clienteObtenido, clientePrueba));
        }

        private bool CompararClientes(CLIENTE clienteObtenido, CLIENTE clientePrueba)
        {
            return clienteObtenido.CLI_USUARIO == clientePrueba.CLI_USUARIO;
        }

        [Fact]
        public void TestObtenerListaProductosPorId()
        {
            ProductoAccessLocal productoAccessLocal = new ProductoAccessLocal();
            string[] ids = new string[] { "MEDROJ1012", "CAMNEGM" };
            List<PRODUCTO> listaProductos = (List<PRODUCTO>)productoAccessLocal.getProductosPorId(ids);
            Assert.True(CompararListaProductos(ids, listaProductos));
        }

        private bool CompararListaProductos(string[] ids, List<PRODUCTO> listaProductos)
        {
            bool iguales = true;
            foreach(string id in ids)
            {
                if(listaProductos.Where(p => p.PRD_ID == id) == null)
                {
                    iguales = false;
                }
            }
            iguales = ids.Length == listaProductos.Count;
            return iguales;
        }
    }
}
