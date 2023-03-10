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
    /// Lógica de interacción para Mascota.xaml
    /// </summary>
    public partial class Mascota : Window
    {
        public Mascota()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Identificador del Propietario: " + txtIdProp.Text + "\n" + "Nombre " + txtNombre.Text + "\n" + "Alergias " + txtAlergias.Text + "\n" + "Sexo " + txtSexo.Text + "\n"+
                "Fecha de Nacimiento " + txtFecha.Text + "\n");
        }
    }
}
