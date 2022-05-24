using Minimal_Cliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_Cliente.RepositorioDatos
{
    public class DatosCliente
    {
        public DatosCliente()
        {
            ListaClientes = new List<CLIENTE>();
            cargarDatos();    
        }

        public List<CLIENTE> ListaClientes { get; set; }

        public void cargarDatos()
        {
            ListaClientes.Add(new CLIENTE
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
            });

            ListaClientes.Add(new CLIENTE
            {
                CLI_USUARIO = "1765498751",
                CLI_CONTRASENA = "Xlcaceres5737",
                CLI_CEDULA_RUC = "1765498751",
                CLI_EMAIL = "xlcaceres@hotmail.com",
                CLI_NOMBRE = "Ximena",
                CLI_APELLIDO = "Caceres",
                CLI_EDAD = 24,
                CLI_SEXO = 'F',
                CLI_DIRECCION = "Conocoto Av Lola Quintana conjunto Juan Pablo II",
                CLI_CIUDAD = "Quito",
                CLI_PROVINCIA = "Pichincha",
                CLI_TELEFONO = "0986857423"
            });
        } 
    }
}
