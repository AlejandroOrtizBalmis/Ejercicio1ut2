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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numeroAleatorio;
        public MainWindow()
        {
            InitializeComponent();
            numeroAleatorio = GenerarNumeroAleatorio();
        }

        private int GenerarNumeroAleatorio()
        {
            Random r = new Random();
            return r.Next(0,101);
        }
        private void comprobarButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(numeroTextBox.Text) == numeroAleatorio) resultadoTextBlock.Text = "Has acertado";
            else if (int.Parse(numeroTextBox.Text) > numeroAleatorio) resultadoTextBlock.Text = "Te has pasado";
            else resultadoTextBlock.Text = "Te has quedado corto";

        }

        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numeroTextBox.Text = "";
            resultadoTextBlock.Text = "";
            numeroAleatorio = GenerarNumeroAleatorio();
        }
    }
}
