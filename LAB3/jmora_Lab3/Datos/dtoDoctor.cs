using jmora_Lab3.Base_de_Datos;
using jmora_Lab3.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace jmora_Lab3.Datos
{
    public class dtoDoctor
    {
        private ConnSQL conn = new ConnSQL();//para hacer consultas SQL
        private string _SQLConnection = Conn.GetConnectionStrings();

        public bool guardarDoctor(clsDoctor datos)
        {
            try
            {
                string registro = "INSERT INTO dbFarmaciaPueblo.dbo.tbDoctor VALUES ('" + datos.NombreCompleto+"','"+datos.CodigoMedico+"','"+datos.Cedula+"','"+datos.AdicionadoPor+"','"+datos.FechaAdicion+"',null,null,'"+datos.Estado+"')";
                conn.SQLExecuteCmm(_SQLConnection, registro);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public void consultarCedulaDoctor(ComboBox cmb)
        {
            try
            {
                string consulta = "SELECT Cedula, NombreDoctor FROM dbFarmaciaPueblo.dbo.tbDoctor";

                var doctor = conn.SQLCargaDataTable(_SQLConnection, consulta, null);
                if (doctor.Rows.Count > 0)
                {
                    for (int i = 0; i < doctor.Rows.Count; i++)
                    {
                        cmb.Items.Add(doctor.Rows[i].ItemArray[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public bool ActualizarDatosDoctor(clsDoctor datos, string vCedula)
        {
            try
            {
                string actualizar = "UPDATE dbFarmaciaPueblo.dbo.tbDoctor SET nombreDoctor = '" + datos.NombreCompleto + "', CodigoMedico = '" + datos.CodigoMedico + "', modificadoPor = '" + datos.ModificadoPor + "', fechaModificacion = '" + datos.FechaModificacion + "', Estado = '"+datos.Estado+"' WHERE Cedula = '" + vCedula + "'";
                conn.SQLExecuteCmm(_SQLConnection, actualizar);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }


        



        //    var doctor = conn.SQLCargaDataTable(_SQLConnection, consulta, null);

    }
 }



