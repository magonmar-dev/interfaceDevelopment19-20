using capa_negocio;
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
using System.Windows.Threading;

namespace capa_presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Negocio neg;

        public MainWindow(string usuario, Negocio neg)
        {
            InitializeComponent();

            this.neg = neg;

            lblUsuario.Content = "Usuario: " + usuario;
            lblHora.Content = DateTime.Now.ToString("HH:mm");
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private bool AskForClosing()
        {
            var result = MessageBox.Show("Are you sure to exit?", "Window Closing",
                                 MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
                return true;
            else
                return false;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!AskForClosing())
                e.Cancel = true;
        }
    }
}
