using ProyectoTPI_3k5.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTPI_3k5
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm(Usuario usu)
        {
            InitializeComponent();
            lblBienvenida.Text = "Bienvenido " + usu.NombreDeUsuario;
            lblBienvenida.Visible = true;
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaPersona ventana = new AltaPersona();
            ventana.Show();
        }

        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
