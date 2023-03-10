using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jmora_Lab3.Clases
{
    internal class clsDetalleFactura
    {
        #region Atributos
        private int id, idFactura, idReceta, cantidad;
        private double IVA, subtotal;
        #endregion

        #region constructores
        public clsDetalleFactura()
        {
            this.id= 0;
            this.idFactura= 0;
            this.idReceta= 0;
            this.cantidad = 0;
            this.IVA= 0;
            this.subtotal= 0;
        }

        public clsDetalleFactura(int iden, int idedFactura, int cantidad, int idedReceta, double precio, double porcentajeIVA, double subtotal)
        {
            this.id = iden;
            this.idFactura = idedFactura;
            this.idReceta= idedReceta;
            this.cantidad = cantidad;
            this.IVA = porcentajeIVA;
            this.subtotal = subtotal;
        }
        #endregion

        #region Funciones y Procedimientos
        public string imprimirDatos()
        {
            string datos;
            datos = "Id de factura " + this.idFactura + "\n" + "Id de la receta " + this.idReceta + ", " + "Cantidad " + this.cantidad + "\n" +
            "Porcentaje de IVA " + this.IVA + "%" + "\n" + "Subtotal " + this.subtotal;
            return datos;
        }

        #endregion

        #region Metodos
        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public int IdFactura
        {
            set { idFactura = value; }
            get { return idFactura; }
        }

        public int IdReceta
        {
            set { idReceta = value; }
            get { return idReceta; }
        }

        public int Cantidad
        {
            set { cantidad = value; }
            get { return cantidad; }
        }


        public double PorcentajeIVA
        {
            set { IVA = value; }
            get { return IVA; }
        }

        public double Subtotal
        {
            set { subtotal = value; }
            get { return subtotal; }
        }
        #endregion
    }
}
