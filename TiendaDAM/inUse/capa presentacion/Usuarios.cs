using capa_entidades;
using capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace capa_presentacion
{
    public partial class Usuarios : Form
    {
        private Negocio neg;
        private DataView vista;
        private DataTable dt;

        private List<Usuario> listaUsuarios;
        private List<Localidad> listaPueblos;
        private List<Provincia> listaProvincias;

        public Usuarios(Negocio neg)
        {
            InitializeComponent();

            this.neg = neg;

            dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            dt.Columns.Add(new DataColumn("Nombre", typeof(string)));
            dt.Columns.Add(new DataColumn("Apellidos", typeof(string)));
            dt.Columns.Add(new DataColumn("Email", typeof(string)));
            dt.Columns.Add(new DataColumn("DNI", typeof(string)));

            vista = new DataView(dt);
            dataGridView.DataSource = vista;
            dataGridView.Columns[0].Width = 30;
            dataGridView.Columns[1].Width = 80;
            dataGridView.Columns[2].Width = 170;
            dataGridView.Columns[3].Width = 120;
            dataGridView.Columns[4].Width = 80;

            listaProvincias = neg.GetProvincias();
            foreach(Provincia p in listaProvincias)
            {
                cbProvincia.Items.Add(p.Nombre);
            }
            cbProvincia.SelectedIndex = 0;

            listaPueblos = neg.GetLocalidades();
            foreach (Localidad l in listaPueblos)
            {
                cbPueblo.Items.Add(l.Nombre);
            }
            cbPueblo.SelectedIndex = 0;

            leer_usuarios();
        }

        public void leer_usuarios()
        {
            listaUsuarios = neg.GetUsuarios();

            int i = 0;

            dt.Clear();

            while (i < listaUsuarios.Count)
            {
                DataRow row = dt.NewRow();
                row["ID"] = listaUsuarios[i].UsuarioID.ToString();
                row["Nombre"] = listaUsuarios[i].Nombre;
                row["Apellidos"] = listaUsuarios[i].Apellidos;
                row["Email"] = listaUsuarios[i].Email;
                row["DNI"] = listaUsuarios[i].Dni;
                dt.Rows.Add(row);
                row.AcceptChanges();

                i++;
            }
        }

        private void txbEmail_Validating(object sender, CancelEventArgs e)
        {
            if(txbEmail.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txbEmail, "El campo no puede estar vacio");
            }
            else
            {
                errorProvider1.Clear();
                string regex = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
                if (!Regex.IsMatch(txbEmail.Text, regex))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txbEmail, "No es un email válido");
                }
                else
                    errorProvider1.Clear();
            }
        }

        private void txbNom_Validating(object sender, CancelEventArgs e)
        {
            if (txbNom.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txbNom, "El campo no puede estar vacio");
            }
            else
                errorProvider1.Clear();
        }

        private void txbApe_Validating(object sender, CancelEventArgs e)
        {
            if (txbApe.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txbApe, "El campo no puede estar vacio");
            }
            else
                errorProvider1.Clear();
        }

        private void txbDNI_Validating(object sender, CancelEventArgs e)
        {
            if (txbDNI.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txbDNI, "El campo no puede estar vacio");
            }
            else if(txbDNI.Text.Length < 9)
            {
                e.Cancel = true;
                errorProvider1.SetError(txbDNI, "Debe tener 9 caracteres");
            }
            else
            {
                errorProvider1.Clear();

                int num;

                if (txbDNI.Text.Substring(0, 1) == "X")
                    num = Convert.ToInt32("0" + txbDNI.Text.Substring(1, 8));
                else if (txbDNI.Text.Substring(0, 1) == "Y")
                    num = Convert.ToInt32("1" + txbDNI.Text.Substring(1, 8));
                else if (txbDNI.Text.Substring(0, 1) == "Z")
                    num = Convert.ToInt32("2" + txbDNI.Text.Substring(1, 8));
                else
                    num = Convert.ToInt32(txbDNI.Text.Substring(0, 8));

                string letraActual = txbDNI.Text.Substring(8).ToUpper();
                string letra = "";

                switch (num % 23)
                {
                    case 0: letra = "T"; break;
                    case 1: letra = "R"; break;
                    case 2: letra = "W"; break;
                    case 3: letra = "A"; break;
                    case 4: letra = "G"; break;
                    case 5: letra = "M"; break;
                    case 6: letra = "Y"; break;
                    case 7: letra = "F"; break;
                    case 8: letra = "P"; break;
                    case 9: letra = "D"; break;
                    case 10: letra = "X"; break;
                    case 11: letra = "B"; break;
                    case 12: letra = "N"; break;
                    case 13: letra = "J"; break;
                    case 14: letra = "Z"; break;
                    case 15: letra = "S"; break;
                    case 16: letra = "Q"; break;
                    case 17: letra = "V"; break;
                    case 18: letra = "H"; break;
                    case 19: letra = "L"; break;
                    case 20: letra = "C"; break;
                    case 21: letra = "K"; break;
                    case 22: letra = "E"; break;
                }

                if (letra != letraActual)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txbDNI, "No es un DNI válido");
                }
                else
                    errorProvider1.Clear();
            }
        }

        private void txbPass_Validating(object sender, CancelEventArgs e)
        {
            string regex = "(?=.*[0-9])(?=.*[A-Z])(?=.*\\W)";
            if (!Regex.IsMatch(txbPass.Text, regex))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbPass, "No es una contraseña válida. " +
                    "Debe contener al menos un número, una mayúscula y un carácter no alfanumérico");
            }
            else
                errorProvider1.Clear();
        }

        private void txbRepPass_Validating(object sender, CancelEventArgs e)
        {
            if (!txbRepPass.Text.Equals(txbPass.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txbRepPass, "Las contraseñas no son iguales");
            }
            else
                errorProvider1.Clear();
        }
                
        private void btnIns_Click(object sender, EventArgs e)
        {
            int id = listaUsuarios.Count;
            string puebloID = listaPueblos[cbPueblo.SelectedIndex].LocalidadID;
            string provinciaID = listaProvincias[cbProvincia.SelectedIndex].ProvinciaID;
            string fecha = dtpNac.Value.ToString("yyyy-MM-dd");
            if (neg.Insertar(id, txbEmail.Text.Trim(), txbPass.Text.Trim(), txbNom.Text.Trim(), txbApe.Text.Trim(),
                txbDNI.Text.Trim(), mtxbTel.Text.Trim(), txbDir1.Text.Trim(), txbDir2.Text.Trim(), txbCod.Text.Trim(), 
                puebloID, provinciaID, fecha))
            {
                MessageBox.Show("Usuario insertado");
                leer_usuarios();
            }
            else
            {
                MessageBox.Show("Error al insertar el usuario");
            }
        }

        private void txbNomB_KeyPress(object sender, KeyPressEventArgs e)
        {
            string aux = txbNomB.Text;

            if (aux == "")
                aux = "*";

            vista.RowFilter = "Nombre LIKE '" + aux + "*'";
        }

        private void txbApeB_KeyPress(object sender, KeyPressEventArgs e)
        {
            string aux = txbApeB.Text;

            if (aux == "")
                aux = "*";

            vista.RowFilter = "Apellidos LIKE '" + aux + "*'";
        }

        private void txbEmailB_TextChanged(object sender, EventArgs e)
        {
            string aux = txbEmailB.Text;

            if (aux == "")
                aux = "*";

            vista.RowFilter = "Email LIKE '" + aux + "*'";
        }

        private void txbDniB_TextChanged(object sender, EventArgs e)
        {
            string aux = txbDniB.Text;

            if (aux == "")
                aux = "*";

            vista.RowFilter = "DNI LIKE '" + aux + "*'";
        }
    }
}
