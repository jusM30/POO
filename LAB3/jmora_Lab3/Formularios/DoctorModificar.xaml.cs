using jmora_Lab3.Clases;
using jmora_Lab3.Datos;
using jmora_Lab3.Utilidades;
using System;
using System.Collections.Generic;
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

namespace jmora_Lab3.Formularios
{
    /// <summary>
    /// Lógica de interacción para DoctorModificar.xaml
    /// </summary>
    public partial class DoctorModificar : Window
    {
        public DoctorModificar()
        {
            InitializeComponent();
            CargarDoctores();
        }

        public void CargarDoctores()
        {
            cmbDoctores.Items.Clear();
            dtoDoctor doc = new dtoDoctor();
            doc.consultarCedulaDoctor(cmbDoctores);
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtCodigo.Text.Length > 0 && txtNombreCom.Text.Length > 0)
            {

                clsDoctor doctor = new clsDoctor(0, txtNombreCom.Text,
                                                    txtCodigo.Text, variablesGlobales.usuariologin, DateTime.Now, txtEstado.Text);

                //data transfer object DTO que comunica con la base de datos,
                dtoDoctor doc = new dtoDoctor();
                if (doc.ActualizarDatosDoctor(doctor, cmbDoctores.Text) == true)
                {
                    MessageBox.Show("Datos Modificados con éxito!");
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtCedula.Text = cmbDoctores.SelectedValue.ToString();
         
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }
    }
}

