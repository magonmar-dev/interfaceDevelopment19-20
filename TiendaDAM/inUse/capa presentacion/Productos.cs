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
        }

        private void cbTipoB_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscarProducto();
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            txbNomB.Clear();
            cbTipoB.SelectedIndex = 0;
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

                OcultarPaneles();

                switch (selectedProduct.TipoArticuloID)
                {
                    case "1": // TV
                        Tv tv = obtenerTV(id);
                        txbPanel.Text = tv.Panel;
                        txbPantallaTV.Text = tv.Pantalla;
                        txbResolTV.Text = tv.Resolucion;
                        txbHD.Text = tv.HDReadyFullHD;
                        ckbTDT.Checked = tv.Tdt;
                        panelTV.Visible = true;
                        break;
                    case "2": // Memoria
                        txbTipoMem.Text = obtenerMemoria(id).Tipo;
                        panelMemoria.Visible = true;
                        break;
                    case "3": // Cámara
                        Camara cam = obtenerCamara(id);
                        txbResolCam.Text = cam.Resolucion;
                        txbSensor.Text = cam.Sensor;
                        txbTipoCam.Text = cam.Tipo;
                        txbFactor.Text = cam.Factor;
                        txbObjetivo.Text = cam.Objetivo;
                        txbPantallaCam.Text = cam.Pantalla;
                        txbZoom.Text = cam.Zoom;
                        panelCamara.Visible = true;
                        break;
                    case "4": // Objetivo
                        Objetivo obj = obtenerObjetivo(id);
                        txbTipoObj.Text = obj.Tipo;
                        txbMontura.Text = obj.Montura;
                        txbFocal.Text = obj.Focal;
                        txbApertura.Text = obj.Apertura;
                        txbEspeciales.Text = obj.Especiales;
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