using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Clases
{
    internal class clsEstudiante
    {
        #region Atributos
        private int identificacion, celular;
        private string nombre, apellido1,apellido2,fechaNacimiento,correo,nivel;
        #endregion

        #region Constructores
        public clsEstudiante()
        {
            this.identificacion = 0;
            this.celular = 0;
            this.nombre = "";
            this.apellido1 = "";
            this.apellido2 = "";
            this.fechaNacimiento = "";
            this.correo = "";
            this.nivel = "";
        }

        public clsEstudiante(int identificacion, int celular, string nombre, string apellido1, string apellido2, string fechaNacimiento, string correo, string nivel)
        {
            this.identificacion = identificacion;
            this.celular = celular;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.fechaNacimiento = fechaNacimiento;
            this.correo = correo;
            this.nivel = nivel;
        }
        #endregion

        #region Funciones y Procedimientos
        public string imprimirDatos()
        {
            string dato = "";
            dato = "Identificador del Estudiante: " + this.identificacion + "\n" +
                "Nombre: " + this.nombre + "\n" +
                "Apellidos: " + this.apellido1 + " " + this.apellido2 + "\n" +
                "Fecha de Nacimiento: " + this.fechaNacimiento + "\n" +
                "Correo del Estudiante: " + this.correo + "\n" +
                "Nivel: " + this.nivel + "\n";

            return dato;
        }
        #endregion

        #region Metodos
        public int Identificador
        {
            set {identificacion = value;}
            get { return identificacion; }
        }

        public String Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public String Apellido1
        {
            set { apellido1 = value; }
            get { return apellido1; }
        }

        public String Apellido2
        {
            set { apellido2 = value; }
            get { return apellido2; }
        }

         public String FechaNacimiento
        {
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }

        public String Correo
        {
            set { correo = value; }
            get { return correo; }
        }

        public String Nivel
        {
            set { nivel = value; }
            get { return nivel; }
        }
        #endregion
    }
}
