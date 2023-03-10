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
    /// Lógica de interacción para Cliente.xaml
    /// </summary>
    public partial class Cliente : Window
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Tipo de Identificación: " + txtId.Text + "\n" +
                    " Número de Identificación: " + txtIden.Text + "\n" +
                    " Nombre: " + txtNombre.Text + "\n" +
                    " Primer Apellido: " + txtApellido.Text + "\n" +
                    " Segundo Apellido: " + txtSegundoApe.Text + "\n" +
                    " Fecha de Nacimiento: " + txtFechaN.Text + "\n" +
                    " Peso: " + txtPeso.Text + "\n" +
                    " Sexo: " + txtSexo.Text + "\n" +
                    " Teléfono Celular: " + txtCelular.Text + "\n" +
                    " Correo Electrónico: " + txtCorreo.Text + "\n");
        }
    }
}
