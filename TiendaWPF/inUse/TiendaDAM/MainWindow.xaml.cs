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
        private UserControl actualForm;

        public MainWindow(string usuario, Negocio neg)
        {
            InitializeComponent();

            this.neg = neg;

            lblHora.Content = DateTime.Now.ToString("HH:mm");
            lblErrores.Content = "";

            userIcon.Content = usuario.Substring(0, 1).ToUpper();
            ToolTip t = new ToolTip();
            t.Content = usuario;
            userIcon.ToolTip = t;

            CargarFormUsuarios();
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

        private void CargarFormUsuarios()
        {
            titulo.Content = "Usuarios";
            titulo.Visibility = Visibility.Visible;

            actualForm = new Usuarios(neg, lblErrores);
            actualForm.HorizontalAlignment = HorizontalAlignment.Center;
            actualForm.VerticalAlignment = VerticalAlignment.Center;

            panel.Children.Clear();
            panel.Children.Add(actualForm);
        }

        private void btnUsuarios_Click(object sender, RoutedEventArgs e)
        {
            CargarFormUsuarios();
        }

        private void btnProductos_Click(object sender, RoutedEventArgs e)
        {
            titulo.Content = "Productos";
            titulo.Visibility = Visibility.Visible;

            actualForm = new Productos(neg);
            actualForm.HorizontalAlignment = HorizontalAlignment.Center;
            actualForm.VerticalAlignment = VerticalAlignment.Center;

            panel.Children.Clear();
            panel.Children.Add(actualForm);
        }

        private void btnPedidos_Click(object sender, RoutedEventArgs e)
        {
            titulo.Content = "Pedidos";
            titulo.Visibility = Visibility.Visible;

            actualForm = new Pedidos(neg);
            actualForm.HorizontalAlignment = HorizontalAlignment.Center;
            actualForm.VerticalAlignment = VerticalAlignment.Center;

            panel.Children.Clear();
            panel.Children.Add(actualForm);
        }

        private void btnEstadisticas_Click(object sender, RoutedEventArgs e)
        {
            titulo.Content = "Estadísticas";
            titulo.Visibility = Visibility.Visible;

            actualForm = new Estadisticas(neg, lblErrores);
            actualForm.HorizontalAlignment = HorizontalAlignment.Center;
            actualForm.VerticalAlignment = VerticalAlignment.Center;

            panel.Children.Clear();
            panel.Children.Add(actualForm);
        }
    }
}
