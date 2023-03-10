using jmora_Lab3.Base_de_Datos;
using jmora_Lab3.Clases;
using jmora_Lab3.Datos;
using jmora_Lab3.Formularios;
using jmora_Lab3.Utilidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace jmora_Lab2.Formularios
{
    /// <summary>
    /// Lógica de interacción para Doctor.xaml
    /// </summary>
    public partial class Doctor : Window
    {
        public Doctor()
        {
            InitializeComponent();
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            if (txtCodigo.Text.Length > 0 && txtNombre.Text.Length > 0 && txtCedula.Text.Length > 0)
            {

                clsDoctor doctor = new clsDoctor(txtNombre.Text, txtCodigo.Text, txtCedula.Text, variablesGlobales.usuariologin, DateTime.Now, txtEstado.Text);                                      ;

                //data transfer object DTO que comunica con la base de datos
                dtoDoctor doc = new dtoDoctor();
                if (doc.guardarDoctor(doctor) == true)
                {
                    MessageBox.Show("Datos Guardados con éxito!");
                }
                else
                {
                    MessageBox.Show("Datos incorrectos!");
                }
            }
            else
            {
                MessageBox.Show("Debes completar los campos");
            }
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            var ventana = new DoctorModificar();

            ventana.ShowDialog();
        }
    }
    
}
