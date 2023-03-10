using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaApp.Clases
{
    public class clsHoja
    {
        #region Atributos     
        private int identificador, idMascota;
        private string sintomas, diagnostico, tratamiento;
        #endregion


        #region metodos


        public int Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }



        public string Sintomas
        {
            get { return sintomas; }
            set { sintomas = value; }
        }

        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }
        public string Tratamiento
        {
            get { return tratamiento; }
            set { tratamiento = value; }
        }

        public int IdMascota
        {
            get { return idMascota; }
            set { idMascota = value; }
        }


        #endregion


        #region Constructores

        public clsHoja()
        {

            this.identificador = 0;
            this.sintomas = "";
            this.diagnostico = "";
            this.tratamiento = "";
            this.idMascota = 0;

        }
        public clsHoja(int ident, string sin, string diag, string trat, int idMasc)
        {

            this.identificador = ident;
            this.sintomas = sin;
            this.diagnostico = diag;
            this.tratamiento = trat;
            this.idMascota = idMasc;


        }

        #endregion

        #region Funciones

        public string imprimirDatos()
        {

            string datos = "";
            datos = "Sintomas " + this.sintomas + "\n"
                + "Diagnostico" + this.diagnostico + "\n"
                + "Tratamiento" + this.tratamiento + "\n"
                + "Id Mascota" + this.idMascota;



            return datos;

        }



        #endregion
    }
}
