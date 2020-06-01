using capa_entidades;
using capa_negocio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Lógica de interacción para Usuarios.xaml
    /// </summary>
    public partial class Usuarios : UserControl
    {
        private Negocio neg;
        private Label lblErrores;

        private List<Usuario> listaUsuarios;
        private List<Provincia> listaProvincias;
        private List<Localidad> listaPueblos;
        private List<Pedido> listaPedidos;

        private Usuario selectedUser;

        public Usuarios(Negocio neg, Label lblErrores)
        {
            InitializeComponent();

            this.neg = neg;
            this.lblErrores = lblErrores;

            LeerUsuarios();

            listaProvincias = neg.GetProvincias();
            cbProvincia.ItemsSource = listaProvincias;
            cbProvincia.SelectedIndex = 0;

            RellenarPueblos();
            cbPueblo.SelectedIndex = 0;

            dpFecha.DisplayDateEnd = DateTime.Today;
            dpFecha.SelectedDate = DateTime.ParseExact("01/01/2000",
                "dd/MM/yyyy", CultureInfo.InvariantCulture);

            listaPedidos = neg.GetPedidos();
        }

        private void LeerUsuarios()
        {
            listaUsuarios = neg.GetUsuarios();
            dataGrid.ItemsSource = listaUsuarios;
        }

        private void BuscarUsuarios()
        {
           List<Usuario> usuarios = neg.GetUsuarios()
                .FindAll(u => u.Nombre.ToLower().StartsWith(txbNomB.Text.ToLower()))
                .FindAll(u => u.Apellidos.ToLower().StartsWith(txbApeB.Text.ToLower()))
                .FindAll(u => u.Email.ToLower().StartsWith(txbEmailB.Text.ToLower()))
                .FindAll(u => u.Dni.ToLower().StartsWith(txbDniB.Text.ToLower()));

            listaUsuarios.Clear();
            listaUsuarios = usuarios;
            dataGrid.ItemsSource = listaUsuarios;
        }

        private void textChanged(object sender, RoutedEventArgs e)
        {
            BuscarUsuarios();
        }

        private void btnBorrarFiltros_Click(object sender, RoutedEventArgs e)
        {
            txbNomB.Clear();
            txbApeB.Clear();
            txbEmailB.Clear();
            txbDniB.Clear();
            LeerUsuarios();
        }

        private void VaciarCampos()
        {
            txbEmail.Clear();
            txbPass.Clear();
            txbRepass.Clear();
            txbNom.Clear();
            txbApe.Clear();
            txbDni.Clear();
            txbTel.Clear();
            txbDir.Clear();
            txbDir2.Clear();
            txbCod.Clear();
            cbProvincia.SelectedIndex = 0;
            RellenarPueblos();
            cbPueblo.SelectedIndex = 0;
            cbPueblo.IsEnabled = false;
            dpFecha.SelectedDate = DateTime.ParseExact("01/01/2000",
                "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGrid.SelectedItems.Count == 0)
            {
                VaciarCampos();
                selectedUser = null;
            }
            else
            {
                Usuario u = (Usuario) dataGrid.SelectedItem;
                selectedUser = neg.GetUsuario(u.UsuarioID);

                if (selectedUser.Email != null)
                    txbEmail.Text = selectedUser.Email;
                txbPass.Clear();
                txbRepass.Clear();
                txbPass.IsEnabled = txbRepass.IsEnabled = false;
                if (selectedUser.Nombre != null)
                    txbNom.Text = selectedUser.Nombre;
                if (selectedUser.Apellidos != null)
                    txbApe.Text = selectedUser.Apellidos;
                if (selectedUser.Dni != null)
                    txbDni.Text = selectedUser.Dni;
                if (selectedUser.Telefono != null)
                    txbTel.Text = selectedUser.Telefono;
                if (selectedUser.Calle != null)
                    txbDir.Text = selectedUser.Calle;
                if (selectedUser.Calle2 != null)
                    txbDir2.Text = selectedUser.Calle2;
                if (selectedUser.Codpos != null)
                    txbCod.Text = selectedUser.Codpos;
                if (selectedUser.ProvinciaID != null)
                {
                    cbProvincia.SelectedItem = ObtenerProvincia(selectedUser.ProvinciaID);
                    RellenarPueblos();
                }
                if (selectedUser.PuebloID != null)
                    cbPueblo.SelectedItem = ObtenerLocalidad(selectedUser.PuebloID);
                if(selectedUser.Nacido != null)
                    dpFecha.SelectedDate = DateTime.Parse(selectedUser.Nacido);
            }
        }

        private string ObtenerCodProvincia()
        {
            foreach (Provincia provincia in listaProvincias)
                if (provincia.ProvinciaID == ((Provincia) (cbProvincia.SelectedItem)).ProvinciaID)
                    return provincia.ProvinciaID;

            return null;
        }

        private void RellenarPueblos()
        {
            if ((listaPueblos = neg.GetLocalidades(ObtenerCodProvincia())) != null)
            {
                cbPueblo.IsEnabled = true;
                cbPueblo.ItemsSource = listaPueblos;
                cbPueblo.SelectedIndex = 0;
            }
        }

        private void cbProvincia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RellenarPueblos();
        }

        private Provincia ObtenerProvincia(string codigoProvincia)
        {
            foreach (Provincia provincia in listaProvincias)
                if (provincia.ProvinciaID == codigoProvincia)
                    return provincia;

            return null;
        }

        private Localidad ObtenerLocalidad(string codigoLocalidad)
        {
            foreach (Localidad localidad in listaPueblos)
                if (localidad.LocalidadID == codigoLocalidad)
                    return localidad;

            return null;
        }

        private bool ValidarEmail()
        {
            string regex = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
            return Regex.IsMatch(txbEmail.Text, regex);
        }

        private bool ValidarPassword()
        {
            string regex = "(?=.*[0-9])(?=.*[A-Z])(?=.*\\W)";
            return Regex.IsMatch(txbPass.Password, regex);
        }

        private bool ValidarRePassword()
        {
            if (!txbRepass.Password.Equals(txbPass.Password))
                return false;
            else
                return true;
        }

        private bool ValidarDni()
        {
            int num;

            if (txbDni.Text.Substring(0, 1) == "X")
                num = Convert.ToInt32("0" + txbDni.Text.Substring(1, 8));
            else if (txbDni.Text.Substring(0, 1) == "Y")
                num = Convert.ToInt32("1" + txbDni.Text.Substring(1, 8));
            else if (txbDni.Text.Substring(0, 1) == "Z")
                num = Convert.ToInt32("2" + txbDni.Text.Substring(1, 8));
            else
                num = Convert.ToInt32(txbDni.Text.Substring(0, 8));

            string letraActual = txbDni.Text.Substring(8).ToUpper();
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
                return false;
            else
                return true;
        }

        private bool ValidarTelefono()
        {
            string regex = "^[0-9]{9}|[0-9]{12}$";
            return Regex.IsMatch(txbTel.Text.Trim(), regex);
        }

        private bool ValidarCodpos()
        {
            string regex = "^[0-9]{5}$";
            return Regex.IsMatch(txbCod.Text.Trim(), regex);
        }

        private bool ValidarFormulario(bool modificar)
        {
            lblErrores.Content = "";

            if (txbEmail.Text.Trim() == "")
            {
                lblErrores.Content = "El email no puede estar vacio";
                return false;
            }
            else if (!ValidarEmail())
            {
                lblErrores.Content = "No es un email válido";
                return false;
            }

            if (!modificar)
            {
                if (txbPass.Password.Trim() == "")
                {
                    lblErrores.Content = "La contraseña no puede estar vacia";
                    return false;
                }
                else if (!ValidarPassword())
                {
                    lblErrores.Content = "No es una contraseña válida. " +
                        "Debe contener al menos un número, una mayúscula y un carácter no alfanumérico";
                    return false;
                }

                if (!ValidarRePassword())
                {
                    lblErrores.Content = "Las contraseñas no son iguales";
                    return false;
                }

                if (txbDni.Text.Trim() == "")
                {
                    lblErrores.Content = "El DNI no puede estar vacio";
                    return false;
                }
                else if (txbDni.Text.Length < 9)
                {
                    lblErrores.Content = "El DNI debe tener 9 caracteres";
                    return false;
                }
                else if (!ValidarDni())
                {
                    lblErrores.Content = "No es un DNI válido";
                    return false;
                }
            }

            if(txbNom.Text.Trim() == "")
            {
                lblErrores.Content = "El nombre no puede estar vacio";
                return false;
            }

            if(txbApe.Text.Trim() == "")
            {
                lblErrores.Content = "Los apellidos no pueden estar vacios";
                return false;
            }

            if (!ValidarTelefono())
            {
                lblErrores.Content = "No es un número de teléfono válido";
                return false;
            }

            if (!ValidarCodpos())
            {
                lblErrores.Content = "No es un código postal válido";
                return false;
            }

            return true;
        }

        private void btnIns_Click(object sender, RoutedEventArgs e)
        {
            if (ValidarFormulario(false))
            {
                lblErrores.Content = "";

                int totalFilas = listaUsuarios.Count;
                string id = (Convert.ToInt32(listaUsuarios[totalFilas-1].UsuarioID) + 1).ToString();
                string provinciaID = ((Provincia)(cbProvincia.SelectedItem)).ProvinciaID;
                string puebloID = ((Localidad)(cbPueblo.SelectedItem)).LocalidadID;
                string fecha = dpFecha.DisplayDate.ToString("yyyy-MM-dd");
                if(neg.InsertarUsuario(id, txbEmail.Text.Trim(), txbPass.Password.Trim(), txbNom.Text.Trim(), txbApe.Text.Trim(),
                    txbDni.Text.Trim(), txbTel.Text.Trim(), txbDir.Text.Trim(), txbDir2.Text.Trim(), txbCod.Text.Trim(),
                    puebloID, provinciaID, fecha))
                {
                    MessageBox.Show("Usuario insertado", "Insertar usuario",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                    LeerUsuarios();
                    VaciarCampos();
                    selectedUser = null;
                }
                else
                {
                    MessageBox.Show("Error al insertar el usuario", "Insertar usuario",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnMod_Click(object sender, RoutedEventArgs e)
        {
            if (ValidarFormulario(true))
            {
                if (selectedUser != null)
                {
                    string id = selectedUser.UsuarioID;
                    string provinciaID = ((Provincia)(cbProvincia.SelectedItem)).ProvinciaID;
                    string puebloID = ((Localidad)(cbPueblo.SelectedItem)).LocalidadID;
                    string fecha = dpFecha.DisplayDate.ToString("yyyy-MM-dd");
                    if (neg.ModificarUsuario(id, txbEmail.Text.Trim(), selectedUser.Password, txbNom.Text.Trim(), txbApe.Text.Trim(),
                        txbDni.Text.Trim(), txbTel.Text.Trim(), txbDir.Text.Trim(), txbDir2.Text.Trim(), txbCod.Text.Trim(),
                        puebloID, provinciaID, fecha))
                    {
                        MessageBox.Show("Usuario modificado", "Modificar usuario",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                        LeerUsuarios();
                        VaciarCampos();
                        selectedUser = null;
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el usuario", "Modificar usuario",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                    txbPass.IsEnabled = true;
                    txbRepass.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("Seleccione el usuario que quiere modificar", "Modificar usuario",
                        MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
        }

        private void btnEli_Click(object sender, RoutedEventArgs e)
        {
            if (selectedUser != null)
            {
                string id = selectedUser.UsuarioID;

                MessageBoxResult result = MessageBox.Show("¿Seguro que quiere eliminar este usuario?\n\n" +
                    "Nombre: " + selectedUser.Nombre + "\nApellidos: " + selectedUser.Apellidos
                    + "\nDNI: " + selectedUser.Dni + "\nEmail: " + selectedUser.Email
                    , "Eliminar usuario " + id, MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    bool tienePedidos = false;
                    foreach (Pedido pedido in listaPedidos)
                    {
                        if (pedido.UsuarioID == selectedUser.UsuarioID)
                            tienePedidos = true;
                    }

                    if (tienePedidos)
                    {
                        MessageBox.Show("No se puede eliminar un usuario que tenga pedidos en la base de datos", "Eliminar usuario",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                        tienePedidos = false;
                    }
                    else
                    {
                        if (neg.EliminarUsuario(id))
                        {
                            MessageBox.Show("Usuario eliminado", "Eliminar usuario",
                                MessageBoxButton.OK, MessageBoxImage.Information);
                            LeerUsuarios();
                            VaciarCampos();
                            selectedUser = null;
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el usuario", "Eliminar usuario",
                                MessageBoxButton.OK, MessageBoxImage.Error);
                        }

                        txbPass.IsEnabled = true;
                        txbRepass.IsEnabled = true;
                    }
                }
                else if (result == MessageBoxResult.No) { }
            }
            else
            {
                MessageBox.Show("Seleccione el usuario que quiere eliminar", "Eliminar usuario",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}