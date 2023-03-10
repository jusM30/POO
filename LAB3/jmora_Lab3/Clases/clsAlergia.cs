using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmora_Lab3.Clases
{
    internal class clsAlergia
    {
        #region
        private int id;
        private string identificadorCli, alergias;
        #endregion

        #region Constructores
        public clsAlergia()
        {
            this.id = 0;
            this.identificadorCli = "";
            this.alergias = "";
        }

        public clsAlergia(int id, string identificadorCli, string alergias)
        {
            this.id = id;
            this.identificadorCli = identificadorCli;
            this.alergias = alergias;
        }
        #endregion

        #region Funciones y Procedimientos
        public String imprimirDatos()
        {
            string dato = "";
            dato = "Identificador del Cliente " + this.identificadorCli + "\n" + "Alergias " + this.alergias;
            return dato;
        }
        #endregion

        #region Metodos

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string IdentificadorCli
        {
            set { identificadorCli = value; }
            get { return identificadorCli; }
        }

        public string Alergias
        {
            set { alergias = value; }
            get { return alergias; }
        }

        #endregion
    }
}
