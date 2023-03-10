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
    /// Lógica de interacción para DetalleFactura.xaml
    /// </summary>
    public partial class DetalleFactura : Window
    {
        public DetalleFactura()
        {
            InitializeComponent();
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Identificador de la receta: " + txtIdRec.Text + "\n" +
                    " Identificador de la Factura: " + txtIdFac.Text + "\n" +
                    " Cantidad: " + txtCantidad.Text + "\n" +
                    " IVA: " + txtIVA1.Text + "\n" +
                    " Subtotal: " + txtSubtotal.Text + "\n" 
                    );
        }
    }
}
