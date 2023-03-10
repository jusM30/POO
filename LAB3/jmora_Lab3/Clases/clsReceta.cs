using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmora_Lab3.Clases
{
    internal class clsReceta
    {
        #region Atributos
        private int id, idHoja;
        private string descripcionTratamiento, dosisIndicadas;
        #endregion


        #region Constructores
        public clsReceta()
        {
            this.id = 0;
            this.idHoja = 0;
            this.descripcionTratamiento = "";
            this.dosisIndicadas = "";
        }
        public clsReceta(int iden, int idDoctor, string descripcionTratamiento, string dosisIndicadas)
        {
            this.id = iden;
            this.idHoja = idDoctor;
            this.descripcionTratamiento = descripcionTratamiento;
            this.dosisIndicadas = dosisIndicadas;
        }
        #endregion

        #region Funciones y Procedimientos
        public string imprimirDatos()
        {
            string datos;
            datos = "Hoja clinica " + this.idHoja + "\n" + "Descripcion del tratamiento" + this.descripcionTratamiento + ", Dosis indicadas " + this.dosisIndicadas;
            return datos;
        }
        #endregion

        #region Metodos
        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public int IdHoja
        {
            set { idHoja = value; }
            get { return idHoja; }
        }

        public string DescripcionTratamiento
        {
            set { descripcionTratamiento = value; }
            get { return descripcionTratamiento; }
        }

        public string DosisIndicadas
        {
            set { dosisIndicadas = value; }
            get { return dosisIndicadas; }
        }
        #endregion
    }
}
