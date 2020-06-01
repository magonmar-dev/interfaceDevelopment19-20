using capa_entidades;
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

namespace capa_presentacion
{
    /// <summary>
    /// Lógica de interacción para Productos.xaml
    /// </summary>
    public partial class Productos : UserControl
    {
        private Negocio neg;

        private List<Articulo> listaProductos;
        private List<TipoArticulo> listaTipos;
        private List<Marca> listaMarcas;

        private Articulo selectedProduct;

        public Productos(Negocio neg)
        {
            InitializeComponent();

            this.neg = neg;

            LeerProductos();

            listaTipos = neg.GetTiposArticulo();
            cbTipoB.Items.Add("Todos");
            cbTipo.Items.Add("");
            foreach (TipoArticulo tipo in listaTipos)
            {
                cbTipoB.Items.Add(tipo.Descripcion);
                cbTipo.Items.Add(tipo.Descripcion);
            }
            cbTipoB.SelectedIndex = 0;
            cbTipo.SelectedIndex = 0;

            listaMarcas = neg.GetMarcas();
            cbMarca.Items.Add("");
            foreach(Marca marca in listaMarcas)
            {
                cbMarca.Items.Add(marca.MarcaID);
            }
            cbMarca.SelectedIndex = 0;

            OcultarPaneles();
        }

        private void LeerProductos()
        {
            listaProductos = neg.GetProductos();
            dataGrid.ItemsSource = listaProductos;
        }

        private void BuscarProductos()
        {
            List<Articulo> productos = neg.GetProductos()
                 .FindAll(p => p.Nombre.ToLower().StartsWith(txbNomB.Text.ToLower()));

            switch (cbTipoB.SelectedItem.ToString())
            {
                case "TV": productos = productos.FindAll(p => p.TipoArticuloID == "1"); break;
                case "Memoria": productos = productos.FindAll(p => p.TipoArticuloID == "2"); break;
                case "Camara": productos = productos.FindAll(p => p.TipoArticuloID == "3"); break;
                case "Objetivo": productos = productos.FindAll(p => p.TipoArticuloID == "4"); break;
                default: break;
            }

            listaProductos.Clear();
            listaProductos = productos;
            dataGrid.ItemsSource = listaProductos;
        }

        private void txbNomB_TextChanged(object sender, TextChangedEventArgs e)
        {
            BuscarProductos();
        }

        private void cbTipoB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BuscarProductos();
        }

        private void btnBorrarFiltros_Click(object sender, RoutedEventArgs e)
        {
            txbNomB.Clear();
            cbTipoB.SelectedIndex = 0;
            LeerProductos();
        }

        private void VaciarCampos()
        {
            txbNom.Clear();
            txbPvp.Clear();
            cbMarca.SelectedIndex = 0;
            txbEspecs.Clear();
            cbTipo.SelectedIndex = 0;

            txbPanel.Clear();
            txbPantallaTV.Clear();
            txbResolTV.Clear();
            txbHD.Clear();
            ckbTDT.IsChecked = false;
            txbTipoMem.Clear();
            txbResolCam.Clear();
            txbSensor.Clear();
            txbTipoCam.Clear();
            txbFactor.Clear();
            txbObj.Clear();
            txbPantallaCam.Clear();
            txbZoom.Clear();
            txbTipoObj.Clear();
            txbMontura.Clear();
            txbFocal.Clear();
            txbApertura.Clear();
            txbEspeciales.Clear();
        }

        private string ObtenerTipo(string codigoTipo)
        {
            foreach (TipoArticulo tipo in listaTipos)
                if (tipo.TipoArticuloID.Equals(codigoTipo))
                    return tipo.Descripcion;

            return null;
        }

        private void OcultarPaneles()
        {
            panelTV.Visibility = Visibility.Hidden;
            panelMemoria.Visibility = Visibility.Hidden;
            panelCamara.Visibility = Visibility.Hidden;
            panelObjetivo.Visibility = Visibility.Hidden;
        }

        private Memoria obtenerMemoria(string id)
        {
            List<Memoria> memorias = neg.GetMemorias();

            foreach (Memoria m in memorias)
                if (m.MemoriaID == id)
                    return m;

            return null;
        }

        private Tv obtenerTV(string id)
        {
            List<Tv> TVs = neg.GetTVs();

            foreach (Tv t in TVs)
                if (t.TvID == id)
                    return t;

            return null;
        }

        private Objetivo obtenerObjetivo(string id)
        {
            List<Objetivo> objetivos = neg.GetObjetivos();

            foreach (Objetivo o in objetivos)
                if (o.ObjetivoID == id)
                    return o;

            return null;
        }

        private Camara obtenerCamara(string id)
        {
            List<Camara> camaras = neg.GetCamaras();

            foreach (Camara c in camaras)
                if (c.CamaraID == id)
                    return c;

            return null;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGrid.SelectedItems.Count == 0)
            {
                VaciarCampos();
                selectedProduct = null;
                OcultarPaneles();
            }
            else
            {
                Articulo a = (Articulo)dataGrid.SelectedItem;
                selectedProduct = neg.GetArticulo(a.ArticuloID);

                VaciarCampos();

                if (selectedProduct.Nombre != null)
                    txbNom.Text = selectedProduct.Nombre;
                if (selectedProduct.Pvp != null)
                    txbPvp.Text = selectedProduct.Pvp;
                if (selectedProduct.MarcaID != null)
                    cbMarca.SelectedItem = selectedProduct.MarcaID;
                if (selectedProduct.Especificaciones != null)
                    txbEspecs.Text = selectedProduct.Especificaciones;
                if (selectedProduct.TipoArticuloID != null)
                    cbTipo.SelectedItem = ObtenerTipo(selectedProduct.TipoArticuloID);

                OcultarPaneles();

                switch (selectedProduct.TipoArticuloID)
                {
                    case "1":
                        txbPanel.Clear();
                        txbPantallaTV.Clear();
                        txbResolTV.Clear();
                        txbHD.Clear();
                        ckbTDT.IsChecked = false;
                        Tv tv = obtenerTV(a.ArticuloID);
                        if (tv.Panel != null)
                            txbPanel.Text = tv.Panel;
                        if (tv.Pantalla != null)
                            txbPantallaTV.Text = tv.Pantalla;
                        if (tv.Resolucion != null)
                            txbResolTV.Text = tv.Resolucion;
                        if (tv.HDReadyFullHD != null)
                            txbHD.Text = tv.HDReadyFullHD;
                        ckbTDT.IsChecked = tv.Tdt;
                        panelTV.Visibility = Visibility.Visible;
                        break;
                    case "2": 
                        txbTipoMem.Clear();
                        if (obtenerMemoria(a.ArticuloID).Tipo != null)
                            txbTipoMem.Text = obtenerMemoria(a.ArticuloID).Tipo;
                        panelMemoria.Visibility = Visibility.Visible;
                        break;
                    case "3":
                        txbResolCam.Clear();
                        txbSensor.Clear();
                        txbTipoCam.Clear();
                        txbFactor.Clear();
                        txbObj.Clear();
                        txbPantallaCam.Clear();
                        txbZoom.Clear();
                        Camara cam = obtenerCamara(a.ArticuloID);
                        if (cam.Resolucion != null)
                            txbResolCam.Text = cam.Resolucion;
                        if (cam.Sensor != null)
                            txbSensor.Text = cam.Sensor;
                        if (cam.Tipo != null)
                            txbTipoCam.Text = cam.Tipo;
                        if (cam.Factor != null)
                            txbFactor.Text = cam.Factor;
                        if (cam.Objetivo != null)
                            txbObj.Text = cam.Objetivo;
                        if (cam.Pantalla != null)
                            txbPantallaCam.Text = cam.Pantalla;
                        if (cam.Zoom != null)
                            txbZoom.Text = cam.Zoom;
                        panelCamara.Visibility = Visibility.Visible;
                        break;
                    case "4":
                        txbTipoObj.Clear();
                        txbMontura.Clear();
                        txbFocal.Clear();
                        txbApertura.Clear();
                        txbEspeciales.Clear();
                        Objetivo obj = obtenerObjetivo(a.ArticuloID);
                        if (obj.Tipo != null)
                            txbTipoObj.Text = obj.Tipo;
                        if (obj.Montura != null)
                            txbMontura.Text = obj.Montura;
                        if (obj.Focal != null)
                            txbFocal.Text = obj.Focal;
                        if (obj.Apertura != null)
                            txbApertura.Text = obj.Apertura;
                        if (obj.Especiales != null)
                            txbEspeciales.Text = obj.Especiales;
                        panelObjetivo.Visibility = Visibility.Visible;
                        break;
                    default: break;
                }
            }
        }
    }
}
