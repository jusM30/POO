using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmora_Lab3.Clases
{
    internal class clsFarmacia
    {
        #region Atributos
        private int id, telefono;
        private string cedulaJuridica, nombre, correoElectronico;
        #endregion

        #region Constructores
        public clsFarmacia()
        {
            this.id = 0;
            this.telefono = 0;
            this.cedulaJuridica = "";
            this.nombre= "";
            this.correoElectronico = "";
        }
        public clsFarmacia(int id, int telefono, string cedulaJuridica, string nombre, string correoElectronico)
        {
            this.id = id;
            this.telefono = telefono;
            this.cedulaJuridica = cedulaJuridica;
            this.nombre = nombre;
            this.correoElectronico = correoElectronico;
        }
        #endregion

        #region Funciones y Procedimientos
        public string imprimirDatos()
        {
            string datos;
            datos = "Cedula Jurídica" +this.cedulaJuridica+"\n"+"Nombre "+this.nombre+"\n"+
                "Telefono "+this.telefono+"\n"+ "Correo Electrónico "+this.correoElectronico; 
            return datos;
        }
        #endregion

        #region Metodos
        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public int Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string CedulaJuridica
        {
            set { cedulaJuridica = value; }
            get { return cedulaJuridica; }
        }

        public string CorreoElectronico
        {
            set { correoElectronico = value; }
            get { return correoElectronico; }
        }
        #endregion
    }
}
