using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaApp.Clases
{
    public class clsMascota
    {
        #region Atributos    
        private int identificador,idPropietario;
        private string nombre,  alergias;
        private char sexo;
        private DateTime fechaNacimiento;
        #endregion


        #region metodos


        public int Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }

       

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string Alergias
        {
            get { return alergias; }
            set { alergias = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public int IdPropietario
        {
            get { return idPropietario; }
            set { idPropietario = value; }
        }

        #endregion


        #region Constructores

        public clsMascota()
        {

            this.identificador = 0;
            this.nombre = "";
            this.fechaNacimiento = Convert.ToDateTime("10/01/2019");
            this.alergias = "";
            this.sexo = 'm';
            this.idPropietario = 0;
          
        }
        public clsMascota(int ident, string nom, DateTime fNaci, string ale, char sex, int idPro)
        {

            this.identificador = ident;
            this.nombre = nom;
            this.fechaNacimiento = fNaci;
            this.alergias = ale;
            this.sexo = sex;
            this.idPropietario = idPro;
           
        }

        #endregion

        #region Funciones
        public string imprimirDatos()
        {

            string datos = "";
            datos = "Nombre " + this.nombre  + "\n"
                + "Fecha Nacimiento" + this.fechaNacimiento + "\n"
                + "Alergias" + this.alergias + "\n"
                + "Sexo" + this.sexo + "\n"
                + "Id Propietario" + this.idPropietario;



            return datos;

        }
        #endregion
    }
}
