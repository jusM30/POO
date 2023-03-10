using jmora_Lab3.Clases;
using jmora_Lab3.Utilidades;
using jmora_Lab3.Datos;
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
using jmora_Lab3;

namespace jmora_Lab2.Formularios
{
    /// <summary>
    /// Lógica de interacción para Usuario.xaml
    /// </summary>
    public partial class Usuario : Window
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text.Length > 0 && txtClave.Password.ToString().Length > 0)
            {
                clsUsuario usuario = new clsUsuario (txtUsuario.Text, txtClave.Password.ToString());

                //data transfer object DTO que comunica con la base de datos
                dtoUsuario usu = new dtoUsuario();
                if (usu.validarIngreso(usuario) == true)
                {
                    variablesGlobales.usuariologin = usuario.Usuario;
                    VentanaPrincipal ventana = new VentanaPrincipal();
                    ventana.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos!");
                }
            }
            else
            {
                MessageBox.Show("Debes completar los campos de Usuario y Clave");
            }
        }

        private void txtClave_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int character = Convert.ToInt32(Convert.ToChar(e.Text));
            if ((character >= 65 && character <= 90) || (character >= 97 && character <= 122) || (character >= 48 && character <= 57))
                e.Handled = false;
            else
                e.Handled = true;
        }

         
    }
}
