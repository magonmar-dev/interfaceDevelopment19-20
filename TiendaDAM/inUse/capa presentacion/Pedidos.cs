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
    public partial class Pedidos : Form
    {
        private Negocio neg;

        private DataView vistaPedidos;
        private DataTable dtPedidos;
        private DataView vistaLinped;
        private DataTable dtLinped;

        private List<Pedido> listaPedidos;
        private List<Usuario> listaUsuarios;
        private List<Articulo> listaArticulos;
        private List<TipoArticulo> listaTipos;
        private List<Linped> listaLinped;

        private Pedido selectedOrder;

        public Pedidos(Negocio neg, ToolStripStatusLabel lbl)
        {
            InitializeComponent();

            dtpFechaB.CustomFormat = "dd/MM/yyyy";
            dtpFechaB.Value = dtpFechaB.MinDate;
            dtpFechaB.MaxDate = DateTime.Today;

            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.MaxDate = DateTime.Today;
            dtpFecha.Value = dtpFecha.MaxDate;

            this.neg = neg;

            selectedOrder = null;

            dtPedidos = new DataTable();
            dtPedidos.Columns.Add(new DataColumn("ID", typeof(string)));
            dtPedidos.Columns.Add(new DataColumn("Usuario", typeof(string)));
            dtPedidos.Columns.Add(new DataColumn("Fecha", typeof(string)));

            vistaPedidos = new DataView(dtPedidos);
            dgvPedidos.DataSource = vistaPedidos;

            leer_pedidos();

            listaUsuarios = neg.GetUsuarios();
            cbUsu.Items.AddRange(listaUsuarios.ToArray());
            cbUsu.SelectedIndex = 0;

            listaTipos = neg.GetTiposArticulo();
            cbTipo.Items.Add("");
            cbTipo.Items.AddRange(listaTipos.ToArray());
            cbTipo.SelectedIndex = 0;

            dtLinped = new DataTable();
            dtLinped.Columns.Add(new DataColumn("ID", typeof(string)));
            dtLinped.Columns.Add(new DataColumn("Nombre", typeof(string)));
            dtLinped.Columns.Add(new DataColumn("Importe", typeof(string)));
            dtLinped.Columns.Add(new DataColumn("Cantidad", typeof(string)));

            vistaLinped = new DataView(dtLinped);
            dgvLinped.DataSource = vistaLinped;

            btnIns.Enabled = true;
            btnMod.Enabled = false;
        }

        private void RellenarArticulos(object sender, EventArgs e)
        {
            cbArt.Items.Clear();

            if (cbTipo.SelectedIndex == 0)
            {
                listaArticulos = neg.GetProductos();
                cbArt.Items.AddRange(listaArticulos.ToArray());
            }
            else
            {
                foreach(Articulo a in neg.GetProductos())
                {
                    if(a.TipoArticuloID == cbTipo.SelectedIndex.ToString())
                    {
                        listaArticulos.Add(a);
                        cbArt.Items.Add(a);
                    }
                }
            }

            cbArt.SelectedIndex = 0;
        }

        private void leer_pedidos()
        {
            listaPedidos = neg.GetPedidos();

            int i = 0;

            dtPedidos.Clear();

            while (i < listaPedidos.Count)
            {
                DataRow row = dtPedidos.NewRow();
                row["ID"] = listaPedidos[i].PedidoID;
                row["Usuario"] = neg.GetUsuario(listaPedidos[i].UsuarioID).Nombre;
                row["Fecha"] = listaPedidos[i].Fecha.Substring(0, 10);
                dtPedidos.Rows.Add(row);
                row.AcceptChanges();

                i++;
            }

            dgvPedidos.ClearSelection();
            selectedOrder = null;
        }

        private void leer_linped(string pedidoId)
        {
            listaLinped = neg.GetLinpeds(pedidoId);

            int i = 0;

            dtLinped.Clear();

            while(i < listaLinped.Count)
            {
                DataRow row = dtLinped.NewRow();
                row["ID"] = listaLinped[i].Linea;
                row["Nombre"] = neg.GetArticulo(listaLinped[i].ArticuloID).Nombre;
                row["Importe"] = listaLinped[i].Importe;
                row["Cantidad"] = listaLinped[i].Cantidad;
                dtLinped.Rows.Add(row);
                row.AcceptChanges();

                i++;
            }

            dgvLinped.ClearSelection();
        }

        private void buscarPedido()
        {
            string auxUsu = txbUsuB.Text;
            string auxFecha = dtpFechaB.Value.ToString().Substring(0, 10);

            if (auxUsu == "")
                auxUsu = "*";

            if (auxFecha == "01/03/2010")
                auxFecha = "*";

            vistaPedidos.RowFilter = "Usuario LIKE '" + auxUsu + "*' AND Fecha LIKE '" + auxFecha + "'";
        }

        private void txbUsuB_TextChanged(object sender, EventArgs e)
        {
            buscarPedido();
        }

        private void dtpFechaB_ValueChanged(object sender, EventArgs e)
        {
            buscarPedido();
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            txbUsuB.Clear();
            dtpFechaB.Value = dtpFechaB.MinDate;
        }

        private void vaciarCamposPedido()
        {
            cbUsu.SelectedIndex = 0;
            dtpFecha.Value = dtpFecha.MaxDate;
        }

        public void vaciarCamposArticulos()
        {
            cbTipo.SelectedIndex = 0;
            cbArt.Items.Clear();
            nudCant.Value = 1;
        }

        public void vaciarEtiquetasTotales()
        {
            lblTotalSinIVA.Text = "0.00 €";
            lblIVA.Text = "0.00 €";
            lblTotal.Text = "0.00 €";
        }

        private void dgvPedidos_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count == 0)
            {
                vaciarCamposPedido();
                vaciarCamposArticulos();
                dtLinped.Clear();
                vaciarEtiquetasTotales();
                selectedOrder = null;
                dgvLinped.Enabled = false;
                btnIns.Enabled = true;
                btnMod.Enabled = false;
                cbUsu.Enabled = true;
                dtpFecha.Enabled = true;
            }
            else
            {
                DataGridViewRow row = dgvPedidos.SelectedRows[0];
                string id = row.Cells[0].Value.ToString();
                selectedOrder = neg.GetPedido(id);

                vaciarCamposPedido();
                vaciarCamposArticulos();
                vaciarEtiquetasTotales();

                cbUsu.SelectedItem = neg.GetUsuario(selectedOrder.UsuarioID);
                dtpFecha.Value = DateTime.Parse(selectedOrder.Fecha.Substring(0, 10));

                leer_linped(selectedOrder.PedidoID);
                ActualizarTotales();

                btnAdd.Enabled = true;
                btnIns.Enabled = false;
                btnMod.Enabled = true;
                dgvLinped.Enabled = true;

                cbUsu.Enabled = false;
                dtpFecha.Enabled = false;
            }
        }

        public void ActualizarTotales()
        {
            float[] importes = new float[dgvLinped.Rows.Count];
            int[] cantidades = new int[dgvLinped.Rows.Count];

            int i = 0;
            foreach(DataGridViewRow row in dgvLinped.Rows)
            {
                importes[i] = Convert.ToSingle(row.Cells[2].Value.ToString());
                cantidades[i] = Convert.ToInt32(row.Cells[3].Value.ToString());
                i++;
            }

            float[] totales = neg.CalcFactura(importes, cantidades);
            lblTotalSinIVA.Text = totales[0].ToString("0.00") + " €";
            lblIVA.Text = totales[1].ToString("0.00") + " €";
            lblTotal.Text = totales[2].ToString("0.00") + " €";
        }

        private void dgvLinped_Click(object sender, EventArgs e)
        {
            if (dgvLinped.SelectedRows.Count != 0)
                btnDel.Enabled = true;
        }
        
        private string buscarProductoId(string nombre)
        {
            foreach(Articulo a in listaArticulos)
            {
                if(a.Nombre.Equals(nombre))
                {
                    return a.ArticuloID;
                }
            }

            return "";
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            if(dgvLinped.Rows.Count == 0)
            {
                MessageBox.Show("Debe añadir al menos un artículo", "Insertar pedido",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(selectedOrder != null)
                {
                    MessageBox.Show("Ya existe el pedido. Si desea modificarlo pulse el botón 'Modificar'", "Insertar pedido",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string pedidoId = (listaPedidos.Count+1).ToString();
                    string usuarioId = listaUsuarios[cbUsu.SelectedIndex].UsuarioID;
                    string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

                    if (neg.InsertarPedido(pedidoId, usuarioId, fecha))
                    {
                        MessageBox.Show("Pedido insertado", "Insertar pedido",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        int lineasInsertadas = 0;
                        foreach (DataGridViewRow row in dgvLinped.Rows)
                        {
                            string linea = (lineasInsertadas+1).ToString();
                            string productoId = buscarProductoId(row.Cells[1].Value.ToString());
                            int importe = Convert.ToInt32(row.Cells[2].Value);
                            int cantidad = Convert.ToInt32(row.Cells[3].Value);

                            if (neg.InsertarLinped(pedidoId, linea, productoId, importe, cantidad))
                            {
                                lineasInsertadas += 1;
                            }
                        }

                        if(lineasInsertadas == dgvLinped.Rows.Count)
                        {
                            MessageBox.Show("Lineas de pedido insertadas", "Insertar lineas de pedido",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al insertar lineas de pedido", "Insertar lineas de pedido",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        leer_pedidos();
                        selectedOrder = null;
                        vaciarCamposPedido();
                        vaciarCamposArticulos();
                        vaciarEtiquetasTotales();
                        dtLinped.Clear();
                        dgvLinped.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar el pedido", "Insertar pedido",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (dgvLinped.Rows.Count == 0)
            {
                MessageBox.Show("Debe añadir al menos un artículo", "Insertar pedido",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string pedidoId = selectedOrder.PedidoID;
                bool error = false;

                if (neg.GetLinpeds(pedidoId).Count != 0)
                {
                    error = !neg.EliminarLinpeds(pedidoId);
                }

                error = !InsertarLinpeds(pedidoId);

                if (error)
                {
                    MessageBox.Show("Error al modificar el pedido", "Modificar pedido",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Pedido modificado", "Modificar pedido",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    leer_pedidos();
                    selectedOrder = null;
                    vaciarCamposPedido();
                    vaciarCamposArticulos();
                    vaciarEtiquetasTotales();
                    dtLinped.Clear();
                    dgvLinped.Enabled = false;
                }
            }
        }

        private bool InsertarLinpeds(string pedidoId)
        {
            int errores = 0;

            for (int i = 0; i < dtLinped.Rows.Count; i++)
            {
                DataRow row = dtLinped.Rows[i];
                if (!neg.InsertarLinped(pedidoId, (i+1).ToString(), buscarProductoId(row["Nombre"].ToString()),
                    Convert.ToInt32(row["Importe"].ToString()), Convert.ToInt32(row["Cantidad"].ToString())))
                    errores += 1;
            }

            return (errores == 0 ? true : false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Articulo art = (Articulo)cbArt.SelectedItem;
            int importe = (art.Pvp == null ? 0 : Convert.ToInt32(art.Pvp));

            DataRow row = dtLinped.NewRow();

            row["ID"] = (dtLinped.Rows.Count+1);
            row["Nombre"] = art.Nombre;
            row["Importe"] = importe;
            row["Cantidad"] = Convert.ToInt32(nudCant.Value);

            dtLinped.Rows.Add(row);
            dtLinped.AcceptChanges();

            dgvLinped.ClearSelection();
            dgvLinped.Enabled = true;

            ActualizarTotales();
        }

        private DataRow BuscarFila(string idLinped)
        {
            foreach (DataRow row in dtLinped.Rows)
            {
                if (row["ID"].ToString() == idLinped)
                    return row;
            }

            return null;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvLinped.SelectedRows.Count == 1)
            {
                dtLinped.Rows.Remove(BuscarFila(
                    dgvLinped.SelectedRows[0].Cells[0].Value.ToString()));
                dtLinped.AcceptChanges();

                dgvLinped.ClearSelection();

                ActualizarTotales();
            }
        }
    }
}
