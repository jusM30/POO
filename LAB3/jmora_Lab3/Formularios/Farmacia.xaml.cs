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

namespace jmora_Lab2.Formularios
{
    /// <summary>
    /// Lógica de interacción para Farmacia.xaml
    /// </summary>
    public partial class Farmacia : Window
    {
        public Farmacia()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Cédula Juridica : " + txtCedula.Text + "\n" +
                    " Nombre: " + txtNombre.Text + "\n" +
                    " Telefono: " + txtTelefono.Text + "\n" +
                    " Correo Electronico: " + txtCorreo.Text + "\n");
        }
    }
}
