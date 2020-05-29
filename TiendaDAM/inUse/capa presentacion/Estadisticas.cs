using capa_entidades;
using capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace capa_presentacion
{
    public partial class Estadisticas : Form
    {
        private Negocio neg;
        private ToolStripLabel lblStatus;

        private List<Pedido> listaPedidos;

        public Estadisticas(Negocio neg, ToolStripLabel lblStatus)
        {
            InitializeComponent();

            this.neg = neg;
            this.lblStatus = lblStatus;

            dtpMes.MaxDate = DateTime.Today;
            dtpMes.CustomFormat = "MMMM 'de' yyyy";

            listaPedidos = neg.GetPedidos();

            ActualizarGraficos();

            /*chartDia.Series[0].ChartType = 
            chartDia.Series[0].Name = "Numero de pedidos";
            chartDia.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
            chartDia.ChartAreas.FirstOrDefault().AxisX.Minimum = 1;

            pedidosPorDia.ChartAreas.FirstOrDefault().AxisY.Interval = 1;
            sinDatosTipo.Visible = false;
            sinDatosPorDia.Visible = false;*/
        }

        private void ActualizarGraficos()
        {
            GraficoDia();
            GraficoTipo();
        }

        private void GraficoDia()
        {
            bool conDatos = false;

            int mayor = 0;
            DateTime fechaBusqueda = dtpMes.Value;

            int[] pedidosPorDia = new int[DateTime.DaysInMonth(fechaBusqueda.Year, fechaBusqueda.Month) + 1];

            for (int i = 0; i < pedidosPorDia.Length; i++)
            {
                pedidosPorDia[i] = 0;
            }

            foreach (Pedido pedido in listaPedidos)
            {
                DateTime fechaPed = DateTime.Parse(pedido.Fecha);
                if (fechaPed.Month == fechaBusqueda.Month && fechaPed.Year == fechaBusqueda.Year)
                {
                    pedidosPorDia[fechaPed.Day]++;
                    conDatos = true;
                }
            }

            chartDia.Series[0].Points.Clear();

            for (int i = 1; i < pedidosPorDia.Length; i++)
            {
                if (mayor < pedidosPorDia[i])
                {
                    mayor = pedidosPorDia[i];
                }
                chartDia.Series[0].Points.Add(pedidosPorDia[i]);
            }

            chartDia.ChartAreas[0].AxisY.Maximum = mayor;
            chartDia.ChartAreas[0].AxisY.Interval = 1;

            if(!conDatos)
            {
                chartDia.Visible = false;
                sinDatosDia.Visible = true;
            }
            else
            {
                chartDia.Visible = true;
                sinDatosDia.Visible = false;
            }
        }

        private void GraficoTipo()
        {
            bool conDatos = false;

            DateTime fechaBusqueda = dtpMes.Value;

            List<int> pedidosPorTipo = new List<int>();
            List<TipoArticulo> listasTiposArt = neg.GetTiposArticulo();

            int total = 0;

            for (int i = 0; i < listasTiposArt.Count; i++)
            {
                pedidosPorTipo.Add(0);
            }

            foreach (Pedido pedido in listaPedidos)
            {
                DateTime fechaPed = DateTime.Parse(pedido.Fecha);
                if (fechaPed.Month == fechaBusqueda.Month && fechaPed.Year == fechaBusqueda.Year)
                {
                    conDatos = true;

                    foreach (Linped l in neg.GetLinpeds(pedido.PedidoID))
                    {
                        pedidosPorTipo[Convert.ToInt32(neg.GetArticulo(l.ArticuloID).TipoArticuloID) - 1] += l.Cantidad;
                        total += l.Cantidad;
                    }
                }
            }

            chartTipo.Series[0].Points.Clear();

            for (int i = 0; i < pedidosPorTipo.Count; i++)
            {
                if (pedidosPorTipo[i] != 0)
                {
                    DataPoint p = chartTipo.Series[0].Points.Add(pedidosPorTipo[i]);
                    p.Label = ((pedidosPorTipo[i] * 10000 / total) / 100.00) + "% (" + pedidosPorTipo[i] + ")";
                    p.LegendText = listasTiposArt[i].Descripcion;
                }
            }

            if (!conDatos)
            {
                chartTipo.Visible = false;
                sinDatosTipo.Visible = true;
            }
            else
            {
                chartTipo.Visible = true;
                sinDatosTipo.Visible = false;
            }
        }

        private void dtpMes_ValueChanged(object sender, EventArgs e)
        {
            dtpMes.Enabled = false;
            lblStatus.Text = "Cargando datos...";
            ActualizarGraficos();
            lblStatus.Text = "Datos cargados";
            dtpMes.Enabled = true;
        }
    }
}
