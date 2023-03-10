using jmora_Lab2.Formularios;
using jmora_Lab3.Formularios;
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

namespace jmora_Lab3
{
    /// <summary>
    /// Lógica de interacción para VentanaPrincipal.xaml
    /// </summary>
    public partial class VentanaPrincipal : Window
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ventana = new Usuario();

            ventana.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var ventana = new Cliente();

            ventana.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var ventana = new Alergias();

            ventana.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var ventana = new Doctor();

            ventana.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var ventana = new HojaClinica();

            ventana.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var ventana = new Receta();

            ventana.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var ventana = new Farmacia();

            ventana.ShowDialog();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var ventana = new Factura();

            ventana.ShowDialog();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            var ventana = new DetalleFactura();

            ventana.ShowDialog();
        }

    }
}
