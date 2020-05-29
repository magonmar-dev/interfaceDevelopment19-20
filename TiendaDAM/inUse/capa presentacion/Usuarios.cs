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
        private List<Pedido> listaPedidos;

        private Usuario selectedUser;

        public Usuarios(Negocio neg)
        {
            InitializeComponent();

            this.neg = neg;

            dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID", typeof(string)));
            dt.Columns.Add(new DataColumn("Nombre", typeof(string)));
            dt.Columns.Add(new DataColumn("Apellidos", typeof(string)));
            dt.Columns.Add(new DataColumn("Email", typeof(string)));
            dt.Columns.Add(new DataColumn("DNI", typeof(string)));

            vista = new DataView(dt);
            dataGridView.DataSource = vista;

            listaProvincias = neg.GetProvincias();
            foreach (Provincia p in listaProvincias)
            {
                cbProvincia.Items.Add(p.Nombre);
            }
            cbProvincia.SelectedIndex = 0;

            listaPueblos = neg.GetLocalidades(listaProvincias[0].ProvinciaID);

            leer_usuarios();
            listaPedidos = neg.GetPedidos();

            dtpNac.CustomFormat = "dd/MM/yyyy";
            dtpNac.MaxDate = DateTime.Today;
        }

        private string obtenerCodigoProvincia()
        {
            foreach (Provincia provincia in listaProvincias)
                if (provincia.Nombre.Equals(cbProvincia.Text))
                    return provincia.ProvinciaID;

            return null;
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            rellenarPueblos();
        }

        private void rellenarPueblos()
        {
            cbPueblo.Items.Clear();

            if ((listaPueblos = neg.GetLocalidades(obtenerCodigoProvincia())) != null)
            {
                foreach (Localidad l in listaPueblos)
                {
                    cbPueblo.Items.Add(l.Nombre);
                }
                cbPueblo.SelectedIndex = 0;
            }
        }

        private void leer_usuarios()
        {
            listaUsuarios = neg.GetUsuarios();

            int i = 0;

            dt.Clear();

            while (i < listaUsuarios.Count)
            {
                DataRow row = dt.NewRow();
                row["ID"] = listaUsuarios[i].UsuarioID;
                row["Nombre"] = listaUsuarios[i].Nombre;
                row["Apellidos"] = listaUsuarios[i].Apellidos;
                row["Email"] = listaUsuarios[i].Email;
                row["DNI"] = listaUsuarios[i].Dni;
                dt.Rows.Add(row);
                row.AcceptChanges();

                i++;
            }

            dataGridView.ClearSelection();
            selectedUser = null;
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
            string id = listaUsuarios.Count.ToString();
            string puebloID = listaPueblos[cbPueblo.SelectedIndex].LocalidadID;
            string provinciaID = listaProvincias[cbProvincia.SelectedIndex].ProvinciaID;
            string fecha = dtpNac.Value.ToString("yyyy-MM-dd");
            if (neg.InsertarUsuario(id, txbEmail.Text.Trim(), txbPass.Text.Trim(), txbNom.Text.Trim(), txbApe.Text.Trim(),
                txbDNI.Text.Trim(), mtxbTel.Text.Trim(), txbDir1.Text.Trim(), txbDir2.Text.Trim(), txbCod.Text.Trim(), 
                puebloID, provinciaID, fecha))
            {
                MessageBox.Show("Usuario insertado", "Insertar usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                leer_usuarios();
            }
            else
            {
                MessageBox.Show("Error al insertar el usuario", "Insertar usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if(selectedUser !=  null)
            {
                string id = selectedUser.UsuarioID;
                string puebloID = listaPueblos[cbPueblo.SelectedIndex].LocalidadID;
                string provinciaID = listaProvincias[cbProvincia.SelectedIndex].ProvinciaID;
                string fecha = dtpNac.Value.ToString("yyyy-MM-dd");
                if (neg.ModificarUsuario(id, txbEmail.Text.Trim(), selectedUser.Password, txbNom.Text.Trim(), txbApe.Text.Trim(),
                    txbDNI.Text.Trim(), mtxbTel.Text.Trim(), txbDir1.Text.Trim(), txbDir2.Text.Trim(), txbCod.Text.Trim(),
                    puebloID, provinciaID, fecha))
                {
                    MessageBox.Show("Usuario modificado", "Modificar usuario",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    leer_usuarios();
                    selectedUser = null;
                    vaciarCampos();
                }
                else
                {
                    MessageBox.Show("Error al modificar el usuario", "Modificar usuario",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txbPass.Enabled = true;
                txbRepPass.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione el usuario que quiere modificar", "Modificar usuario", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                string id = selectedUser.UsuarioID;

                DialogResult result = MessageBox.Show("¿Seguro que quiere eliminar este usuario?\n\n" +
                    "Nombre: " + selectedUser.Nombre + "\nApellidos: " + selectedUser.Apellidos
                    + "\nDNI: " + selectedUser.Dni + "\nEmail: " + selectedUser.Email
                    , "Eliminar usuario " + id, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bool tienePedidos = false;
                    foreach(Pedido pedido in listaPedidos)
                    {
                        if (pedido.UsuarioID == selectedUser.UsuarioID)
                            tienePedidos = true;
                    }

                    if(tienePedidos)
                    {
                        MessageBox.Show("No se puede eliminar un usuario que tenga pedidos en la base de datos", "Eliminar usuario",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tienePedidos = false;
                    }
                    else
                    {
                        if (neg.EliminarUsuario(id))
                        {
                            MessageBox.Show("Usuario eliminado", "Eliminar usuario",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            leer_usuarios();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el usuario", "Eliminar usuario",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        txbPass.Enabled = true;
                        txbRepPass.Enabled = true;
                    }                    
                }
                else if (result == DialogResult.No) {}
            }
            else 
            {
                MessageBox.Show("Seleccione el usuario que quiere eliminar", "Eliminar usuario", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buscarUsuario()
        {
            string auxNom = txbNomB.Text;
            string auxApe = txbApeB.Text;
            string auxEma = txbEmailB.Text;
            string auxDni = txbDniB.Text;

            if (auxNom == "")
                auxNom = "*";

            if (auxApe == "")
                auxApe = "*";

            if (auxEma == "")
                auxEma = "*";

            if (auxDni == "")
                auxDni = "*";

            vista.RowFilter = "Nombre LIKE '" + auxNom + "*' " +
                "AND Apellidos LIKE '" + auxApe + "*'" +
                "AND Email LIKE '" + auxEma + "*'" +
                "AND DNI LIKE '" + auxDni + "*'";
        }

        private void txbNomB_TextChanged(object sender, EventArgs e)
        {
            buscarUsuario();
        }

        private void txbApeB_TextChanged(object sender, EventArgs e)
        {
            buscarUsuario();
        }

        private void txbEmailB_TextChanged(object sender, EventArgs e)
        {
            buscarUsuario();
        }

        private void txbDniB_TextChanged(object sender, EventArgs e)
        {
            buscarUsuario();
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            txbNomB.Clear();
            txbApeB.Clear();
            txbEmailB.Clear();
            txbDniB.Clear();
        }

        private string obtenerProvincia(string codigoProvincia)
        {
            foreach (Provincia provincia in listaProvincias)
                if (provincia.ProvinciaID.Equals(codigoProvincia))
                    return provincia.Nombre;

            return null;
        }

        private string obtenerLocalidad(string codigoLocalidad)
        {
            foreach (Localidad localidad in listaPueblos)
                if (localidad.LocalidadID.Equals(codigoLocalidad))
                    return localidad.Nombre;

            return null;
        }

        private void vaciarCampos()
        {
            txbEmail.Clear();
            txbPass.Clear();
            txbRepPass.Clear();
            txbNom.Clear();
            txbApe.Clear();
            txbDNI.Clear();
            mtxbTel.Clear();
            txbDir1.Clear();
            txbDir2.Clear();
            txbCod.Clear();
            cbProvincia.SelectedIndex = 0;
            cbPueblo.SelectedIndex = 0;
            dtpNac.Value = dtpNac.MinDate;
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                vaciarCampos();
                selectedUser = null;
            }
            else
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                string id = row.Cells[0].Value.ToString();
                selectedUser = neg.GetUsuario(id);

                vaciarCampos();

                if (selectedUser.Email != null)
                    txbEmail.Text = selectedUser.Email;
                txbPass.Enabled = false;
                txbRepPass.Enabled = false;
                if (selectedUser.Nombre != null)
                    txbNom.Text = selectedUser.Nombre;
                if (selectedUser.Apellidos != null)
                    txbApe.Text = selectedUser.Apellidos;
                if (selectedUser.Dni != null)
                    txbDNI.Text = selectedUser.Dni;
                if (selectedUser.Telefono != null)
                    mtxbTel.Text = selectedUser.Telefono;
                if (selectedUser.Calle != null)
                    txbDir1.Text = selectedUser.Calle;
                if (selectedUser.Calle2 != null)
                    txbDir2.Text = selectedUser.Calle2;
                if (selectedUser.Codpos != null)
                    txbCod.Text = selectedUser.Codpos;
                if (selectedUser.ProvinciaID != null)
                {
                    cbProvincia.SelectedItem = obtenerProvincia(selectedUser.ProvinciaID);
                    rellenarPueblos();
                }
                if (selectedUser.PuebloID != null)
                    cbPueblo.SelectedItem = obtenerLocalidad(selectedUser.PuebloID);
                if (selectedUser.Nacido != null)
                    dtpNac.Value = DateTime.Parse(selectedUser.Nacido);
            }
        }
    }
}
