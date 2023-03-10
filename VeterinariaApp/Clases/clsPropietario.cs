using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaApp.Clases
{
    public class clsPropietario
    {

        #region Atributos
        private int identificador;
        private string primerNombre, segundoNombre, primerApellido, segundoApellido, numeroIdentificacion, correo, telefono;
       
        #endregion

        #region Metodos
        public int Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }

        public string PrimerNombre
        {
            get { return primerNombre; }
            set { primerNombre = value; }
        }

        public string SegundoNombre
        {
            get { return segundoNombre; }
            set { segundoNombre = value; }
        }

        public string PrimerApellido
        {
            get { return primerApellido; }
            set { primerApellido = value; }
        }

        public string SegundoApellido
        {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }

        public string NumeroIdentificacion
        {
            get { return numeroIdentificacion; }
            set { numeroIdentificacion = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        #endregion



        #region Constructores

        public clsPropietario() {

            this.identificador = 0;
            this.primerNombre = "";
            this.segundoNombre = "";
            this.primerApellido = "";
            this.SegundoApellido = "";
            this.numeroIdentificacion = "";
            this.correo = "";
            this.telefono = "";
        }
        public clsPropietario( int ident, string pNom, string sNom, string pApell, string sApell, string nident, string corre, string tel)
        {

            this.identificador = ident;
            this.primerNombre = pNom;
            this.segundoNombre = sNom;
            this.primerApellido = pApell;
            this.SegundoApellido = sApell;
            this.numeroIdentificacion = nident;
            this.correo = corre;
            this.telefono = tel;
        }

        #endregion


        #region Funciones
        public string imprimirDatos()
        {

            string datos = "";
            datos = "Nombre Completo" + this.primerNombre + this.segundoNombre + this.primerApellido + this.segundoApellido + "\n"
                + "Identificacion" + this.numeroIdentificacion + "\n"
                + "Correo Electronico" + this.correo + "\n"
                + "Telefono" + this.telefono;


            return datos;

        }
        #endregion




    }
}
