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

namespace Parcial1.Formularios
{
    /// <summary>
    /// Lógica de interacción para Estudiante.xaml
    /// </summary>
    public partial class Estudiante : Window
    {
        public Estudiante()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nombre: " + txtNombre.Text + "\n" +
                "Apellidos: " + txtApellido1.Text + " " + txtApellido2.Text+ "\n" +
                "Fecha de Nacimiento: " + txtFecha.Text + "\n" +
                "Correo del Estudiante: " + txtCorreo.Text + "\n" +
                "Celular: " + txtCelular.Text + "\n" +
                "Nivel: " + txtNivel.Text);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
