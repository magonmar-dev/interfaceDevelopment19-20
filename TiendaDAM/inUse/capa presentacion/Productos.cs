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

namespace capa_presentacion
{
    public partial class Productos : Form
    {
        private Negocio neg;

        private DataView vista;
        private DataTable dt;

        private List<Articulo> listaProductos;
        private List<TipoArticulo> listaTipos;
        private List<Marca> listaMarcas;

        private Articulo selectedProduct;

        public Productos(Negocio neg)
        {
            InitializeComponent();

            this.neg = neg;

            dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID", typeof(string)));
            dt.Columns.Add(new DataColumn("Nombre", typeof(string)));
            dt.Columns.Add(new DataColumn("PVP", typeof(string)));
            dt.Columns.Add(new DataColumn("Marca", typeof(string)));
            dt.Columns.Add(new DataColumn("Tipo", typeof(string)));

            vista = new DataView(dt);
            dataGridView.DataSource = vista;

            listaTipos = neg.GetTiposArticulo();
            cbTipoB.Items.Add("Todos");
            cbTipoB.Items.AddRange(listaTipos.ToArray());
            cbTipoB.SelectedIndex = 0;

            cbTipo.Items.Add("");
            cbTipo.Items.AddRange(listaTipos.ToArray());
            cbTipo.SelectedIndex = 0;

            listaMarcas = neg.GetMarcas();
            cbMarca.Items.Add("");
            cbMarca.Items.AddRange(listaMarcas.ToArray());
            cbMarca.SelectedIndex = 0;

            leer_productos();

            OcultarPaneles();
        }

        private void leer_productos()
        {
            listaProductos = neg.GetProductos();

            int i = 0;

            dt.Clear();

            while (i < listaProductos.Count)
            {
                DataRow row = dt.NewRow();
                row["ID"] = listaProductos[i].ArticuloID;
                row["Nombre"] = listaProductos[i].Nombre;
                row["PVP"] = listaProductos[i].Pvp;
                row["Marca"] = listaProductos[i].MarcaID;
                row["Tipo"] = obtenerTipo(listaProductos[i].TipoArticuloID);
                dt.Rows.Add(row);
                row.AcceptChanges();

                i++;
            }

            dataGridView.ClearSelection();
            selectedProduct = null;
        }

        private string obtenerTipo(string codigoTipo)
        {
            foreach (TipoArticulo tipo in listaTipos)
                if (tipo.TipoArticuloID.Equals(codigoTipo))
                    return tipo.Descripcion;

            return null;
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

        private void buscarProducto()
        {
            string auxNom = txbNomB.Text;
            string auxTipo = cbTipoB.SelectedItem.ToString();

            if (auxNom == "")
                auxNom = "*";

            if (auxTipo == "Todos")
                auxTipo = "*";

            vista.RowFilter = "Nombre LIKE '" + auxNom + "*' AND Tipo LIKE '" + auxTipo + "*'";
        }

        private void txbNomB_TextChanged(object sender, EventArgs e)
        {
            buscarProducto();
            selectedProduct = null;
        }

        private void cbTipoB_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscarProducto();
            selectedProduct = null;
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            txbNomB.Clear();
            cbTipoB.SelectedIndex = 0;
            vaciarCampos();
            selectedProduct = null;
            OcultarPaneles();
        }

        private void vaciarCampos()
        {
            txbNombre.Clear();
            nudPvp.Value = Convert.ToDecimal(0.0);
            cbMarca.SelectedIndex = 0;
            txbEspec.Clear();
            cbTipo.SelectedIndex = 0;

            txbPanel.Clear();
            txbPantallaTV.Clear();
            txbResolTV.Clear();
            txbHD.Clear();
            ckbTDT.Checked = false;
            txbTipoMem.Clear();
            txbResolCam.Clear();
            txbSensor.Clear();
            txbTipoCam.Clear();
            txbFactor.Clear();
            txbObjetivo.Clear();
            txbPantallaCam.Clear();
            txbZoom.Clear();
            txbTipoObj.Clear();
            txbMontura.Clear();
            txbFocal.Clear();
            txbApertura.Clear();
            txbEspeciales.Clear();
        }       

        private void OcultarPaneles()
        {
            panelMemoria.Visible = false;
            panelTV.Visible = false;
            panelObjetivo.Visible = false;
            panelCamara.Visible = false;
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                vaciarCampos();
                selectedProduct = null;
                OcultarPaneles();
            }
            else
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                string id = row.Cells[0].Value.ToString();
                selectedProduct = neg.GetArticulo(id);

                vaciarCampos();

                if (selectedProduct.Nombre != null)
                    txbNombre.Text = selectedProduct.Nombre;
                if (selectedProduct.Pvp != null)
                    nudPvp.Value = Convert.ToDecimal(selectedProduct.Pvp);
                if (selectedProduct.MarcaID != null)
                    cbMarca.SelectedItem = selectedProduct.MarcaID;
                if (selectedProduct.Especificaciones != null)
                    txbEspec.Text = selectedProduct.Especificaciones;
                if (selectedProduct.TipoArticuloID != null)
                    cbTipo.SelectedItem = obtenerTipo(selectedProduct.TipoArticuloID);

                switch (selectedProduct.TipoArticuloID)
                {
                    case "1": // TV
                        txbPanel.Clear();
                        txbPantallaTV.Clear();
                        txbResolTV.Clear();
                        txbHD.Clear();
                        ckbTDT.Checked = false;
                        Tv tv = obtenerTV(id);
                        if (tv.Panel != null)
                            txbPanel.Text = tv.Panel;
                        if (tv.Pantalla != null)
                            txbPantallaTV.Text = tv.Pantalla;
                        if (tv.Resolucion != null) 
                            txbResolTV.Text = tv.Resolucion;
                        if (tv.HDReadyFullHD != null) 
                            txbHD.Text = tv.HDReadyFullHD;
                        ckbTDT.Checked = tv.Tdt;
                        OcultarPaneles();
                        panelTV.Visible = true;
                        break;
                    case "2": // Memoria
                        txbTipoMem.Clear();
                        if (obtenerMemoria(id).Tipo != null)
                            txbTipoMem.Text = obtenerMemoria(id).Tipo;
                        OcultarPaneles();
                        panelMemoria.Visible = true;
                        break;
                    case "3": // Cámara
                        txbResolCam.Clear();
                        txbSensor.Clear();
                        txbTipoCam.Clear();
                        txbFactor.Clear();
                        txbObjetivo.Clear();
                        txbPantallaCam.Clear();
                        txbZoom.Clear();
                        Camara cam = obtenerCamara(id);
                        if(cam.Resolucion != null)
                            txbResolCam.Text = cam.Resolucion;
                        if (cam.Sensor != null) 
                            txbSensor.Text = cam.Sensor;
                        if (cam.Tipo != null) 
                            txbTipoCam.Text = cam.Tipo;
                        if (cam.Factor != null) 
                            txbFactor.Text = cam.Factor;
                        if (cam.Objetivo != null) 
                            txbObjetivo.Text = cam.Objetivo;
                        if (cam.Pantalla != null) 
                            txbPantallaCam.Text = cam.Pantalla;
                        if (cam.Zoom != null) 
                            txbZoom.Text = cam.Zoom;
                        OcultarPaneles();
                        panelCamara.Visible = true;
                        break;
                    case "4": // Objetivo
                        txbTipoObj.Clear();
                        txbMontura.Clear();
                        txbFocal.Clear();
                        txbApertura.Clear();
                        txbEspeciales.Clear();
                        Objetivo obj = obtenerObjetivo(id);
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
                        OcultarPaneles();
                        panelObjetivo.Visible = true;
                        break;
                    default: break;
                }
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                if (neg.ModificarArticulo(selectedProduct.ArticuloID, selectedProduct.Nombre, nudPvp.Value.ToString(),
                    selectedProduct.MarcaID, selectedProduct.Imagen, selectedProduct.UrlImagen, selectedProduct.Especificaciones,
                    selectedProduct.TipoArticuloID))
                {
                    MessageBox.Show("Producto modificado", "Modificar producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    leer_productos();
                    selectedProduct = null;
                    vaciarCampos();
                    OcultarPaneles();
                }
                else
                {
                    MessageBox.Show("Error al modificar el producto", "Modificar producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione el producto que quiere modificar", "Modificar producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}