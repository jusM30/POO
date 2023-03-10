using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmora_Lab3.Clases
{
    internal class clsHojaClinica
    {
        #region Atributos
        private int id;
        private string identificadorCliente, identificadorDoctor, sintomas, diagnostico;
        private DateTime fechaAtencion;
        #endregion

        #region Constructores
        public clsHojaClinica()
        {
            this.id = 0;
            this.identificadorDoctor = "";
            this.identificadorCliente = "";
            this.diagnostico = "";
            this.sintomas = "";
            this.fechaAtencion = Convert.ToDateTime(1 / 9 / 2023);

        }

        public clsHojaClinica(int id, string ideDoc, string ideCli, string diag, string sintomas, DateTime fecha)
        {
            this.id = id;
            this.identificadorDoctor= ideDoc;
            this.identificadorCliente= ideCli;
            this.diagnostico= diag;
            this.sintomas = sintomas;
            this.fechaAtencion= fecha;
        }
        #endregion

        #region Funciones y Procedimientos
        public string imprimirDatos()
        {
            string dato = "";
            dato = "Identificador del Doctor " + this.identificadorDoctor + "\n" + "Identificador del CLiente " + this.identificadorCliente + "\n"
                + "Diagnostico " + this.diagnostico + " Sintomas " + this.sintomas + "\n" + "Fecha de atención " + this.fechaAtencion;
            return dato;
        }
        #endregion

        #region Metodos
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string IdentificadorDoctor
        {
            set { identificadorDoctor = value; }
            get { return identificadorDoctor; }
        }
        public string IdentificadorCliente
        {
            set { identificadorCliente = value; }
            get { return identificadorCliente; }
        }
        public DateTime FechaAtencion
        {
            set { fechaAtencion = value; }
            get { return fechaAtencion; }
        }
        public string Sintomas
        {
            set { sintomas = value; }
            get { return sintomas; }
        }
        public string Diagnostico
        {
            set { diagnostico = value; }
            get { return diagnostico; }
        }
        #endregion
    }
}
