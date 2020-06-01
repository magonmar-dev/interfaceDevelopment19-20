using capa_entidades;
using capa_negocio;
using LiveCharts;
using LiveCharts.Wpf;
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

namespace capa_presentacion
{
    /// <summary>
    /// Lógica de interacción para Estadisticas.xaml
    /// </summary>
    public partial class Estadisticas : UserControl
    {
        private Negocio neg;
        private Label lblStatus;

        public Estadisticas(Negocio neg, Label lblStatus)
        {
            InitializeComponent();

            this.neg = neg;
            this.lblStatus = lblStatus;

            lblStatus.Visibility = Visibility.Visible;

            dpMes.Value = DateTime.Parse("01/03/2010");
            dpMes.Maximum = DateTime.Today;

            sinDatosDia.Visibility = Visibility.Hidden;
            sinDatosTipo.Visibility = Visibility.Hidden;

            ActualizarGraficos();
        }

        private void ActualizarGraficos()
        {
            GraficoDia();
            GraficoTipo();
        }

        private void GraficoDia()
        {
            bool conDatos = true;

            string fechaBusqueda = dpMes.Value.ToString().Substring(3, 7);

            List<Pedido> pedidosPorDia = neg.GetPedidos().FindAll(p => p.Fecha.Substring(3, 7) == fechaBusqueda);

            if (pedidosPorDia.Count == 0)
                conDatos = false;

            SeriesCollection serie = new SeriesCollection();
            string date = dpMes.Value.ToString();
            int month = Convert.ToInt32(date.Substring(3, 2));
            int year = Convert.ToInt32(date.Substring(6, 4));
            int diasMes = DateTime.DaysInMonth(year, month);

            List<string> labels = new List<string>();
            ChartValues<int> values = new ChartValues<int>();
            int max = 1;
            for (int i = 1; i <= diasMes; i++)
            {
                int v = pedidosPorDia.FindAll(p => p.Fecha.Substring(0, 2) == i.ToString("00")).Count;
                values.Add(v);
                if (v > max)
                    max = v;

                labels.Add(i.ToString());
            }

            serie.Add(new ColumnSeries
            {
                Title = "Pedidos",
                Values = values,
                Fill = Brushes.GreenYellow
            });

            gd_y.Separator = new LiveCharts.Wpf.Separator { Step = 1 };
            gd_y.MaxValue = max;
            gd_x.MaxValue = labels.Count;
            gd_x.Labels = labels;
            chartDia.Series = serie;

            if (!conDatos)
            {
                chartDia.Visibility = Visibility.Hidden;
                sinDatosDia.Visibility = Visibility.Visible;
            }
            else
            {
                chartDia.Visibility = Visibility.Visible;
                sinDatosDia.Visibility = Visibility.Hidden;
            }
        }

        private void GraficoTipo()
        {
            bool conDatos = true;

            string fechaBusqueda = dpMes.Value.ToString().Substring(3, 7);

            List<Pedido> pedidosPorTipo = neg.GetPedidos().FindAll(p => p.Fecha.Substring(3, 7) == fechaBusqueda);

            if (pedidosPorTipo.Count == 0)
                conDatos = false;

            SeriesCollection serie1 = new SeriesCollection();
            List<Articulo> articulos = new List<Articulo>();
            SolidColorBrush[] brushes = new SolidColorBrush[] { Brushes.Bisque, Brushes.DarkCyan, Brushes.DarkGoldenrod, Brushes.PowderBlue };

            foreach (Pedido p in pedidosPorTipo)
            {
                foreach (Linped l in neg.GetLinpeds(p.PedidoID))
                {
                    articulos.Add(neg.GetArticulo(l.ArticuloID));
                }
            }

            int tipoActual = 0;
            foreach (TipoArticulo ta in neg.GetTiposArticulo())
            {
                int cantArticulos = 0;

                foreach (Articulo art in articulos)
                {
                    if (art.TipoArticuloID == ta.TipoArticuloID.ToString())
                    {
                        cantArticulos++;
                    }
                }
                articulos.RemoveAll(a => a.TipoArticuloID == ta.TipoArticuloID.ToString());
                serie1.Add(new PieSeries
                {
                    Title = ta.Descripcion,
                    Values = new ChartValues<double> { cantArticulos },
                    Stroke = brushes[tipoActual],
                    Fill = brushes[tipoActual]
                });
                tipoActual++;
            }

            chartTipo.Series = serie1;

            if (!conDatos)
            {
                chartTipo.Visibility = Visibility.Hidden;
                sinDatosTipo.Visibility = Visibility.Visible;
            }
            else
            {
                chartTipo.Visibility = Visibility.Visible;
                sinDatosTipo.Visibility = Visibility.Hidden;
            }
        }

        private void fecha_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            lblStatus.Content = "Cargando datos...";
            dpMes.IsEnabled = false;
            ActualizarGraficos();
            lblStatus.Content = "Datos cargados";
            dpMes.IsEnabled = true;
        }
    }
}
