using capa_negocio;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace capa_presentacion
{
   public partial class FormPrincipal : Form
   {
        private Negocio neg;
        private Usuarios formUsuarios;
        private Productos formProductos;
        private Pedidos formPedidos;
        private Estadisticas formEstadisticas;
        private AcercaDe formAcercaDe;

        DateTime timer;
        double seconds = 0;

        public FormPrincipal(string user, Negocio neg)
        {
            InitializeComponent();

            this.neg = neg;

            lblUsuario.Text = "Usuario : " + user;
            lblHora.Text = DateTime.Now.ToString("HH:mm");

            timer1.Interval = 1000;
            timer1.Start();
            timer = new DateTime();
            lblTimer.Text = timer.ToString("HH:mm:ss");

            lanzarFormUsuarios();

            lblStatus.Text = "AYUDA: Ctrl + Click para eliminar selección de la tabla";
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AskForClosing())
                e.Cancel = true;
        }

        private bool AskForClosing()
        {
            string message = "Are you sure to exit?";
            string caption = "Form Closing";

            var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.OKCancel,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.OK)
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblTimer.Text = timer.AddSeconds(seconds).ToString("HH:mm:ss");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void lanzarFormUsuarios()
        {
            cierra_formularios();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            formUsuarios = new Usuarios(neg);

            formUsuarios.MdiParent = this;
            formUsuarios.ControlBox = false;
            formUsuarios.FormBorderStyle = FormBorderStyle.None;

            lblStatus.Text = "AYUDA: Ctrl + Click para eliminar selección de la tabla";

            formUsuarios.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            lanzarFormUsuarios();
        }

        private void cierra_formularios()
        {
            this.Controls.Remove(panel1);

            for (int i = 0; i < this.MdiChildren.Count(); i++)
            {
                Form f = this.MdiChildren[i];
                f.Close();
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            cierra_formularios();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            formProductos = new Productos(neg);

            formProductos.MdiParent = this;
            formProductos.ControlBox = false;
            formProductos.FormBorderStyle = FormBorderStyle.None;

            lblStatus.Text = "AYUDA: Ctrl + Click para eliminar selección de la tabla";

            formProductos.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            cierra_formularios();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            formPedidos = new Pedidos(neg);

            formPedidos.MdiParent = this;
            formPedidos.ControlBox = false;
            formPedidos.FormBorderStyle = FormBorderStyle.None;

            lblStatus.Text = "AYUDA: Ctrl + Click para eliminar selección de la tabla";

            formPedidos.Show();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            cierra_formularios();

            this.IsMdiContainer = false;
            this.IsMdiContainer = true;

            formEstadisticas = new Estadisticas(neg, lblStatus);

            formEstadisticas.MdiParent = this;
            formEstadisticas.ControlBox = false;
            formEstadisticas.FormBorderStyle = FormBorderStyle.None;

            lblStatus.Text = "";

            formEstadisticas.Show();
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            cierra_formularios();

            formAcercaDe = new AcercaDe();

            lblStatus.Text = "";

            formAcercaDe.Show();
        }
    }
}
