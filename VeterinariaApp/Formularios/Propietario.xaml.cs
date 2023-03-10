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

namespace VeterinariaApp.Formularios
{
    /// <summary>
    /// Interaction logic for Propietario.xaml
    /// </summary>
    public partial class Propietario : Window
    {
        public Propietario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Tipo de Identificación: " + cmbtipoIdentificacion.Text + "\n" +
                    " Número de Identificación: " + txtTelefono.Text + "\n" +
                    " Primer Nombre: " + txtprimerNombre.Text + "\n" +
                    " Sgeundo Nombre: " + txtsegundoNombre.Text + "\n" +
                    " Primer Apellido: " + txtprimerApellido.Text + "\n" +
                    " Segundo Apellido: " + txtsegundoApellido.Text + "\n" +
                    " Teléfono Celular: " + txtTelefono.Text + "\n" +
                    " Correo Electrónico: " + txtCorreo.Text + "\n");
        }

        private void txtprimerNombre_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cmbtipoIdentificacion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
