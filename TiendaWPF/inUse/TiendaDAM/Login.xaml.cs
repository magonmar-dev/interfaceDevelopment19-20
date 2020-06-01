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
using System.Windows.Shapes;
using TiendaDAM;

namespace capa_presentacion
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private MainWindow f2;
        private Negocio neg;
        private byte maxIntentos = 3;

        public Login()
        {
            neg = new Negocio();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (neg.Validar(tbUsuario.Text, tbContra.Password))
            {
                f2 = new MainWindow(tbUsuario.Text, neg);
                f2.Show();
                Hide();
            }
            else
            {
                statusBar.Background.Opacity = 100;
                maxIntentos--;
                lblInfo.Content = "Acceso denegado. Intentos restantes: " + maxIntentos;
                if (maxIntentos <= 0)
                    App.Current.Shutdown();
            }
        }
    }
}
