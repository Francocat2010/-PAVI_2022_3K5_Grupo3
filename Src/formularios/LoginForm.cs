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
            Environment.Exit(0);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCredenciales(txtUsuario.Text, txtPassword.Text))
            {
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

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}