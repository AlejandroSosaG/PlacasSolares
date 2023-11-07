using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacasSolares.Models.Entities
{
    class listaClientes
    {
        public static List<Cliente> ListadoClientes()
        {
            /// <summary>
            /// Función que nos devuelve un listado de todas las personas
            /// </summary>
            /// <returns>listaPersonas</returns>
            List<Cliente> listaCliente = new List<Cliente>()
            {
                new Cliente("Alejandro", "Sosa", "C/ Martinete nº 53", 123456789),
                new Cliente("Angel", "Navarro", "", 987654321),
                new Cliente("Fernando", "Galiana", "", 000000000),
                new Cliente("Antonio", "Navarro", "", 999999999),
                new Cliente("Fernando", "Miguel", "", 666666666),
                new Cliente("Juanma", "Sanchez", "", 000000000),
                new Cliente("Yeray", "Jimenez", "", 111222333),
                new Cliente("Ruben", "Lindes", "", 123123123),
                new Cliente("Javier", "Sequera", "", 123456789),
                new Cliente("David", "Perea", "", 987654321),
                new Cliente("Alejandro", "Mulero", "", 000000000)
            };
            return listaCliente;
        }
    }
}
