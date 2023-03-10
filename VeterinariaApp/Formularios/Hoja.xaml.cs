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
    /// Lógica de interacción para Hoja.xaml
    /// </summary>
    public partial class Hoja : Window
    {
        public Hoja()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Identificador de la Mascota " + txtIdMas.Text + "\n" +
                "Sintomas " + txtSintomas.Text + "\n" +
                "Diagnostico " + txtDiagnostico.Text + "\n" +
                "Tratamiento " + txtTratamiento.Text + "\n");
        }
    }
}
