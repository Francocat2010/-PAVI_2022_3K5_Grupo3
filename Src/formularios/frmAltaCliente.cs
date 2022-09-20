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

namespace ProyectoTPI_3k5
{
    public partial class frmAltaCliente : Form
    {
        public frmAltaCliente()
        {
            InitializeComponent();
        }

        private void btnGuardarPersona_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(String.Empty)) 
            {
                MessageBox.Show("Debe poner el nombre", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtApellido.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe poner el apellido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtNroDocumento.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe poner el numero de documento", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtCalle.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe poner la calle en donde vive", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtNroCasa.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe poner el numero de casa", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtbarrio.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe poner el codigo barrio", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int activo;

            if (chkactivo.Checked)
            {
                activo = 0;
            }
            else 
            {
                activo = 1;
            }
        

            Dictionary<string, object> parametros = new Dictionary<string, object>(); ;
            parametros.Add("@nombre", txtNombre.Text);
            parametros.Add("@apellido", txtApellido.Text);
            parametros.Add("@nro_casa", txtNroCasa.Text);
            parametros.Add("@barrio", txtbarrio.Text);
            parametros.Add("@nro_documento", txtNroDocumento.Text);
            parametros.Add("@calle", txtCalle.Text);
            parametros.Add("@activo", activo.ToString());


            string insert = "INSERT INTO clientes (nro_doc_cliente, nombre_cliente,apellido_cliente,calle,nro_calle,id_barrio,activo_cliente) VALUES(@nro_documento, @nombre, @apellido, @calle,@nro_casa, @barrio, @activo)";
            int respuesta = new Managmentdb().EjecutarSQL(insert, parametros);

            if (respuesta == 1)
            {
                MessageBox.Show("nuevo cliente agregado!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al agregar un cliente nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
