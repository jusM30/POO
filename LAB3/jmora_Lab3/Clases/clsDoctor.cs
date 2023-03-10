using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmora_Lab3.Clases
{
    public class clsDoctor
    {
        #region Atributos
        private int id;
        private String codigoMedico, nombreCompleto, cedula,adicionadoPor, modificadoPor, estado;
        private DateTime fechaAdicion, fechaModificacion;

        #endregion

        #region Constructores
        public clsDoctor()
        {
            this.id = 0;
            this.codigoMedico = "";
            this.nombreCompleto = "";
            this.cedula = "";
            this.adicionadoPor = "";
            this.modificadoPor = "";
            this.fechaAdicion = DateTime.Now;
            this.fechaModificacion= DateTime.Now;
            this.estado = "";

        }

        public clsDoctor( string estado,string codigo, string nombre, string cedula, string adicionadoPor, string modificadoPor, DateTime fechaAdicion,DateTime fechaModificacion)
        {
            this.codigoMedico = codigo;
            this.nombreCompleto = nombre;
            this.cedula = cedula;
            this.adicionadoPor = adicionadoPor;
            this.modificadoPor = modificadoPor;
            this.fechaAdicion= fechaAdicion;
            this.fechaModificacion= fechaModificacion;
            this.estado = estado;
        }

        //constructor para insertar
        public clsDoctor (string nombre,string codigo,string cedula, string adicionadoPor, DateTime fechaAdicion, string estado )
        {
            this.NombreCompleto = nombre;
            this.CodigoMedico = codigo;
            this.Cedula = cedula;
            this.adicionadoPor = adicionadoPor;
            this.FechaAdicion = fechaAdicion;
            this.estado = estado;


        }
        //constructor para actualizar
        public clsDoctor(int id,string nombre, String codigoMedico, string modificadoPor, DateTime fechaModificacion, string estado)
        {
            this.id = id;

            this.NombreCompleto = nombre;
            this.codigoMedico = codigoMedico;
            this.modificadoPor = modificadoPor;
            this.fechaModificacion = fechaModificacion;
            this.estado = estado;

        }


        #endregion

        #region Funciones y Procedimientos
        public string imprimirDatos()
        {
            string dato = "";
            dato = "Codigo del medico " + this.codigoMedico + "\n" +
                "Nombre completo " + this.nombreCompleto + "\n" +
                "Cedula " + this.cedula;
            return dato;
            #endregion
            
        }
        #region Metodos
        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string CodigoMedico
        {
            set { codigoMedico = value; }
            get { return codigoMedico; }
        }

        public string NombreCompleto
        {
            set { nombreCompleto = value; }
            get { return nombreCompleto; }
        }

        public string Estado
        {
            set { estado = value; }
            get { return estado; }
        }

        public String Cedula
        {
            set { cedula = value; }
            get { return cedula; }
        }

        public String AdicionadoPor
        {
            set { adicionadoPor = value; }
            get { return adicionadoPor; }
        }
        public DateTime FechaAdicion
        {
            set { fechaAdicion = value; }
            get { return fechaAdicion; }
        }
        public String ModificadoPor
        {
            set { modificadoPor = value; }
            get { return modificadoPor; }
        }
        public DateTime FechaModificacion
        {
            set { fechaModificacion = value; }
            get { return fechaModificacion; }
        }

        #endregion
    }
}
