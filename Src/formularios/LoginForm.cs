using ProyectoTPI_3k5.datos;
using System.Data;
using System.Data.SqlClient;

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

            // Usuario usu = new Usuario(txtUsuario.Text, txtPassword.Text);

            //string usuCorrecto = "Juan";
            //string passCorrecto = "1234";

            if (ValidarCredenciales(txtUsuario.Text, txtPassword.Text))
            {
                MenuPrincipalForm menuPrincipal = new MenuPrincipalForm(txtUsuario.Text);
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ingrese valores correctos");
            }
        }
            public bool ValidarCredenciales(string pUsuario, string pPassword)
            {
                bool uservalido = false;

                try
                {
                    string query = string.Concat(" SELECT * ",
                                                "   FROM Usuarios ",
                                                "  WHERE usuario= '", pUsuario, "'");

                    DataTable resultado = new Managmentdb().ConsultaSQL(query);

                    if (resultado.Rows.Count >= 1)
                    {
                        if (resultado.Rows[0]["password"].ToString() == pPassword)
                        {
                            uservalido = true;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return uservalido;
            }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}