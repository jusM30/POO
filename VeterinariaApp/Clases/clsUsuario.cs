using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaApp.Clases
{
    internal class clsUsuario
    {
        #region Atributos     
        private int identificador;
        private string nickName, clave;
        #endregion


        #region metodos


        public int Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }



        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
       


        #endregion


        #region Constructores

        public clsUsuario()
        {

            this.identificador = 0;
            this.nickName = "";
            this.clave = "";
           

        }

        public clsUsuario(int identificador, string nickName, string clave)
        {
            this.identificador = identificador;
            this.nickName = nickName;
            this.clave = clave;
        }



        #endregion

        #region Funciones
        public string imprimirDatos()
        {

            string datos = "";
            datos = "Usuario " + this.nickName + "\n"
                + "Clave" + this.clave;
               



            return datos;

        }

        #endregion
    }
}
