using ProyectoTPI_3k5.datos;
using ProyectoTPI_3k5.formularios;
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
        public MenuPrincipalForm(string usuario)
        {
            InitializeComponent();
            
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App Compania telefonica V-1.0", "Grupo03_PAV1", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ConsultaCliente().ShowDialog();
            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAltaCliente().ShowDialog();
        }
    }
}
