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

        public Productos(Negocio neg)
        {
            InitializeComponent();

            this.neg = neg;

            dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID", typeof(string)));
            dt.Columns.Add(new DataColumn("Nombre", typeof(string)));
            dt.Columns.Add(new DataColumn("PVP", typeof(string)));
            dt.Columns.Add(new DataColumn("Marca", typeof(string)));


            vista = new DataView(dt);
            dataGridView.DataSource = vista;

            leer_productos();
        }

        public void leer_productos()
        {
            listaProductos = neg.GetProductos();

            int i = 0;

            dt.Clear();

            while (i < listaProductos.Count)
            {
                DataRow row = dt.NewRow();
                row["ID"] = listaProductos[i].ArticuloID;
                row["Nombre"] = listaProductos[i].Nombre;
                row["PVP"] = listaProductos[i].Pvp.ToString();
                row["Marca"] = listaProductos[i].MarcaID;
                dt.Rows.Add(row);
                row.AcceptChanges();

                i++;
            }
        }
    }
}