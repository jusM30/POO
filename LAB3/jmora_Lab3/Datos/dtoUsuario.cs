using jmora_Lab3.Base_de_Datos;
using jmora_Lab3.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace jmora_Lab3.Datos
{
    public class dtoUsuario
    {
        private ConnSQL conn = new ConnSQL();//para hacer consultas SQL
        private string _SQLConnection = Conn.GetConnectionStrings();


        public bool validarIngreso(clsUsuario datos)
        {
            try
            {
                string consulta = "SELECT Usuario FROM dbFarmaciaPueblo.dbo.tbUsuario WHERE Usuario ='"
                    + datos.Usuario + "' AND Clave = '" + datos.Clave + "'";

                var existe = conn.SQLCargaDataTable(_SQLConnection, consulta, null);
                if (existe.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

    }
}
 
