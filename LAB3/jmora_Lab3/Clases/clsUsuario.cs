using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmora_Lab3.Clases
{
    public class clsUsuario
    {
        #region Atributos
        private int id;
        private String usuario, clave;
        #endregion



        #region Constructores
        public clsUsuario()
        {
            this.id = 0;
            this.usuario= "";
            this.clave = "";
        }

        public clsUsuario (String usuario, String clave)
        {
           
            this.usuario = usuario;
            this.clave = clave;
        }
        #endregion

        #region Funciones y Procedimientos
        public String imprimirDatos()

        {
            string dato = "";
            dato = "Usuario " + this.usuario + "\n" + "Clave " + this.clave;
            return dato;
        }
        #endregion



        #region Metodos
        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Usuario
        {
            set { usuario = value; }
            get { return usuario; }
        }

        public string Clave
        {
            set { clave = value; }
            get { return clave; }
        }
        #endregion
    }
}
