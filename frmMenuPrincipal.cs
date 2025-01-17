﻿using Proyecto_TPI.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TPI
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmAltaCliente ventana = new frmAltaCliente();
            ventana.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La mejor version de ti");
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaServicio ventana = new frmConsultaServicio();
            ventana.Show();
        }

        private void altaTelefonoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAltaContrato ventana = new frmAltaContrato();
            ventana.Show();
        }

        private void darAltaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmAltaServicios ventana = new FrmAltaServicios();
            ventana.Show();
        }

        private void nuevaLocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaLocalidad ventana = new frmAltaLocalidad();
            ventana.Show();
        }
    }
}
