using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacasSolares.Models.Entities
{
    internal class Cliente
    {
        #region atributos
        private string nombre;
        private string apellido;
        private string direccion;
        private int tlf;
        #endregion

        #region constructores
        public Cliente()
        {
            this.nombre = "";
            this.apellido = "";
            this.direccion = "";
            this.tlf = 0;
        }

        public Cliente(string nombre, string apellido, string direccion, int tlfn)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.tlf = tlfn;
        }
        #endregion

        #region propiedades
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public String Direccion 
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public int Tlf
        {
            get { return tlf; }
            set { tlf = value; }
        }

        public String NombreCompleto
        {
            get { return $"{nombre} {apellido}"; }
        }

        #endregion
    }
}
