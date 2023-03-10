using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmora_Lab3.Clases
{
    internal class clsCliente
    {
        #region Atributos
        private int id;
        private string telefono,tipoIdentificacion,numeroIdentificacion,primerNombre, segundoNombre, primerApellido, segundoApellido, sexo, alergias;
        private double peso;
        private DateTime fechaNacimiento;
        #endregion


        #region Constructores
        public clsCliente()
        {
            this.id= 0;
            this.tipoIdentificacion = "";
            this.numeroIdentificacion = "";
            this.telefono = "";
            this.primerNombre = "";
            this.segundoNombre = "";
            this.primerApellido = "";
            this.segundoApellido = "";
            this.fechaNacimiento = Convert.ToDateTime("2/6/2023");
            this.peso = 0.0;
            this.sexo = "";
            this.alergias = "";
        }

        public clsCliente(string telefono,string tIde, string nIde,int iden, string pnom, string snom, string pape, string sape, DateTime fechaNacimiento, string sexo, string alergias, double peso)
        {
            this.id = iden;
            this.numeroIdentificacion= nIde;
            this.tipoIdentificacion = tIde;
            this.telefono= telefono;
            this.primerNombre = pnom;
            this.segundoNombre = snom;
            this.primerApellido = pape;
            this.segundoApellido = sape;
            this.fechaNacimiento = fechaNacimiento;
            this.sexo = sexo;
            this.alergias = alergias;
            this.peso = peso;
        }

        #endregion

        #region Funciones y Procedimientos
        public string imprimirDatos()
        {
            string dato = "";
            dato = "Tipo de identificación "+this.tipoIdentificacion+" Número de identificación"+this.numeroIdentificacion+"\n"+"Nombre Completo" + this.primerNombre + " " + this.segundoNombre + "\n" +
            this.primerApellido + " " + this.segundoApellido + "\n"+"Número de telefono"+this.telefono+"\n" + "Fecha de nacimiento " + this.fechaNacimiento + "\n" +
            "Peso y Sexo " + this.peso + " " + this.sexo + "\n" + "Alergias " + this.alergias;
            return dato;

        }
        #endregion

        #region Metodos
        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string PrimerNombre
        {
            set { primerNombre = value; }
            get { return primerNombre; }
        }

        public string SegundoNombre
        {
            set { segundoNombre = value; }
            get { return segundoNombre; }
        }

        public string PrimerApellido
        {
            set { primerApellido = value; }
            get { return primerApellido; }
        }

        public string SegundoApellido
        {
            set { segundoApellido = value; }
            get { return segundoApellido; }
        }

        public DateTime FechaNacimiento
        {
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }

        public double Peso
        {
            set { peso = value; }
            get { return peso; }
        }

        public string TipoIdentificacion
        {
            set { tipoIdentificacion = value; }
            get { return tipoIdentificacion; }
        }

        public string NumeroIdentificacion
        {
            set { numeroIdentificacion = value; }
            get { return numeroIdentificacion; }
        }

        public string Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }

        public string Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        }

        public string Alergias
        {
            set { alergias = value; }
            get { return alergias; }
        }
        #endregion
    }
}
