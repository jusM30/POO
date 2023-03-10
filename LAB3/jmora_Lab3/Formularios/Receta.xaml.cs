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
    /// Lógica de interacción para Receta.xaml
    /// </summary>
    public partial class Receta : Window
    {
        public Receta()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Identificador de la hoja: " + txtIdHoja.Text + "\n" +
                    " Clinica: " + txtClinica.Text + "\n" +
                    " Descripción del tratamiento: " + txtDescrip.Text + "\n" +
                    " Dosis: " + txtDosis.Text + "\n");
        }
    }
}
