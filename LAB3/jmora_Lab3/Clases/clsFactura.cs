using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmora_Lab3.Clases
{
    internal class clsFactura
    {
        #region Atributos
        private int id, identificadorFarmacia;
        private string formaPago;
        private double totalPagar;
        #endregion

        #region Constructores
        public clsFactura()
        {
            this.id = 0;
            this.identificadorFarmacia = 0;
            this.formaPago = "";
            this.totalPagar = 0;
        }
        public clsFactura(int iden, int ideFarmacia, string formaPago, double totalPagar)
        {
            this.id = iden;
            this.identificadorFarmacia = ideFarmacia;
            this.formaPago = formaPago;
            this.totalPagar = totalPagar;
        }
        #endregion

        #region Funciones y Procedimientos
        public string imprimirDatos()
        {
            string datos;
            datos = "Forma de pago"+this.formaPago+"\n" + "Total a Pagar" + this.totalPagar;
            return datos;
            
        }
        #endregion

        #region Constructores
        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public int IdentificadorFarmacia
        {
            set { identificadorFarmacia = value; }
            get { return identificadorFarmacia; }
        }

        public string FormaPago
        {
            set { formaPago = value; }
            get { return formaPago; }
        }

        public double TotalPagar
        {
            set { totalPagar = value; }
            get { return totalPagar; }
        }

        #endregion
    }
}
