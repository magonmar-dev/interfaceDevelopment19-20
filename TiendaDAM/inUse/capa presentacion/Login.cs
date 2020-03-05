using System.Windows.Forms;
using capa_negocio;

namespace capa_presentacion
{
    public partial class Login : Form
    {
        private FormPrincipal f2;
        private Negocio neg;
        private byte maxIntentos = 3;

        public Login()
        {
            neg = new Negocio();
            InitializeComponent();
            label3.Visible = false;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            f2 = new FormPrincipal(textBox1.Text, neg);

            if (neg.Validar(textBox1.Text, textBox2.Text))
            {
                label3.Visible = false;
                f2.Show();
                Hide();
            }
            else
            {
                label3.Visible = true;
                label3.Text = "Acceso denegado";
                maxIntentos--;
                if (maxIntentos <= 0)
                    Application.Exit();
            }
        }
    }
}
