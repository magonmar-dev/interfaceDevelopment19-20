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
            if (neg.Validar(textBox1.Text, textBox2.Text))
            {
                label3.Visible = false;
                f2 = new FormPrincipal(textBox1.Text, neg);
                f2.Show();
                Hide();
            }
            else
            {
                label3.Visible = true;
                maxIntentos--;
                label3.Text = "Acceso denegado. Quedan " + maxIntentos + " intentos";
                
                if (maxIntentos <= 0)
                    Application.Exit();
            }
        }
    }
}
