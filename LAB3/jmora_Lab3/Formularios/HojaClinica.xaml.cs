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
    /// Lógica de interacción para HojaClinica.xaml
    /// </summary>
    public partial class HojaClinica : Window
    {
        public HojaClinica()
        {
            InitializeComponent();
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Identificador del Doctor: " + txtIdDoc.Text + "\n" +
                    " Identificador del Cliente: " + txtIdCli.Text + "\n" +
                    " Fecha Atención: " + txtFecha.Text + "\n" +
                    " Síntomas: " + txtSintomas.Text + "\n" +
                    " Diagnostico: " + txtDiagnostico.Text + "\n");
        }
    }
}
