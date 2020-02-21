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
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            f2 = new FormPrincipal(textBox1.Text, neg);

            if (neg.Validar(textBox1.Text, textBox2.Text))
            {
                f2.Show();
                Hide();
            } 
            else
            {
                label3.BackColor = System.Drawing.Color.Red;
                label3.Text = "Acceso denegado";
                maxIntentos--;
                if (maxIntentos <= 0)
                    Application.Exit();
            }
        }
    }
}
