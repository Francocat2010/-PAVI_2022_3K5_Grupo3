using System;
using ProyectoTPI_3k5.datos;
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
    public partial class baja_modificacion : Form
    {

        private int accion;
        private Cliente oCliente;
        public baja_modificacion(int accion, Cliente oCliente)
        {
            InitializeComponent();
            this.accion = accion;
            this.oCliente = oCliente;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtdoc.Text))
            {
                MessageBox.Show("Campo numero de documento es requerido", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (accion == 1)
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@nombre", txtnombre.Text);
                parametros.Add("@apellido", txtapellido.Text);
                parametros.Add("@barrio", txtbarrio.Text);
                parametros.Add("@calle", txtcalle.Text);
                parametros.Add("@nro_calle", txtnumcasa.Text);
                parametros.Add("@activo", oCliente.Activo);
                parametros.Add("@documento", oCliente.Nro_Doc);

                string update = "UPDATE clientes SET nombre_cliente = @nombre, apellido_cliente = @apellido, calle = @calle, id_barrio = @barrio, nro_calle = @nro_calle WHERE nro_doc_cliente = @documento";

                int respuesta = new Managmentdb().EjecutarSQL(update, parametros);

                if (respuesta == 1)
                {
                    MessageBox.Show("cliente actualizado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al actualizar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                parametros.Add("@doc", oCliente.Nro_Doc);
                string delete = "UPDATE clientes SET activo_cliente = 0 WHERE nro_doc_cliente = @doc";

                int respuesta = new Managmentdb().EjecutarSQL(delete, parametros);
                
                
                if (respuesta == 1)
                {
                    MessageBox.Show("cliente eliminado!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al borrar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void alta_modificacion_Load(object sender, EventArgs e)
        {
            txtnombre.Text = oCliente.Nom_Cliente;
            txtdoc.Text = oCliente.Nro_Doc.ToString();
            chkactivo.Checked = oCliente.Activo;
            txtapellido.Text = oCliente.Ape_Cliente;
            txtbarrio.Text = oCliente.Barrio.ToString();
            txtcalle.Text = oCliente.Calle;
            txtnumcasa.Text = oCliente.Nro_calle.ToString();



            if (accion == 1)
            {
                txtdoc.Enabled = false;
                chkactivo.Enabled = false;
                this.Text = "Registrar baja de Producto";
            }
            else
            {
                txtdoc.Enabled = false;
                chkactivo.Enabled = false;
                txtapellido.Enabled = false;
                txtbarrio.Enabled = false;
                txtcalle.Enabled = false;
                txtnombre.Enabled = false;
                txtnumcasa.Enabled = false;
                this.Text = "Modificar Producto";
            }
        }
    }
}
