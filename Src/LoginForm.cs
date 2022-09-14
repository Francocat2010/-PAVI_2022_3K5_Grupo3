using ProyectoTPI_3k5.Entidades;

namespace ProyectoTPI_3k5
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario(txtUsuario.Text, txtPassword.Text);

            string usuCorrecto = "Juan";
            string passCorrecto = "1234";

            if (txtUsuario.Text.Equals(usuCorrecto) && txtPassword.Text.Equals(passCorrecto))
            {
                MenuPrincipalForm menuPrincipal = new MenuPrincipalForm(usu);
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ingrese valores correctos");
            }

        }
    }
}