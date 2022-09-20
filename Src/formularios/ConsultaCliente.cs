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

            if (dgvClientes.Rows.Count > 0 && chkActivos.Checked)
            {
                habilitarControles(true);
            }
            else
            {
                habilitarControles(false);
            }


        }

        private void habilitarControles(bool v)
        {
            btnmodificar.Enabled = v;
            btneliminar.Enabled = v;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvClientes.CurrentRow;
            if (fila != null)
            {
                new baja_modificacion(1, mapper(fila)).ShowDialog();
                this.btnConsultar_Click(null, null);
            }
        }

        private Cliente mapper(DataGridViewRow fila)
        {
            Cliente oSeleted = new Cliente();
            oSeleted.Nom_Cliente = fila.Cells["Nombre"].Value.ToString();
            oSeleted.Nro_Doc = (int)(fila.Cells["NroDocumento"].Value);
            oSeleted.Activo = (bool)fila.Cells["Activo"].Value;
            oSeleted.Ape_Cliente = fila.Cells["Apellido"].Value.ToString();
            oSeleted.Barrio = int.Parse(fila.Cells["barrio"].Value.ToString());
            oSeleted.Nro_calle = int.Parse(fila.Cells["numerocalle"].Value.ToString());
            oSeleted.Calle = fila.Cells["calle"].Value.ToString();


            return oSeleted;
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
            habilitarControles(false);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvClientes.CurrentRow;
            if (fila != null)
            {
                new baja_modificacion(2, mapper(fila)).ShowDialog();
                this.btnConsultar_Click(null, null);
            }
        }
    }
}
