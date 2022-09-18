using ProyectoTPI_3k5.datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTPI_3k5.formularios
{
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string strSql = "SELECT * FROM clientes WHERE 1=1 ";
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                strSql += "AND (nombre_cliente=@cliente) ";
                parametros.Add("cliente", txtNombre.Text);
            }

            if (chkActivos.Checked)
            {
                strSql += " AND activo_cliente = '1'";
            }
            else
            {
                strSql += " AND activo_cliente = '0'";
            }
            dgvClientes.DataSource = new Managmentdb().ConsultaSQL(strSql, parametros);
            if(dgvClientes.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
