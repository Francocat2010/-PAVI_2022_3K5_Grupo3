using Proyecto_TPI.Validador;
using Proyecto_TPI.Entidades;
using System.Data.SqlClient;
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
    public partial class frmAltaLocalidad : Form
    {
        public frmAltaLocalidad()
        {
            InitializeComponent();
        }

        private bool AgregarLocalidadABD(Localidades local)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Localidad (nombre, codigo_postal) VALUES (@nombre, @codigo_postal)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", local.Nombre_localidad);
                cmd.Parameters.AddWithValue("@codigo_postal", local.Codigo_postal);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }


        private void btnGuardarLocalid_Click(object sender, EventArgs e)
        {
            {
                bool van = validador.validar(Controls);
                if (!van) { return; }
                Localidades local = new Localidades();
                local.Nombre_localidad = txtNomLocalidad.Text;
                local.Codigo_postal = Int32.Parse(txtCodPostal.Text);

                bool van1 = validador.validar_existencia_localidad(local.Nombre_localidad);
                if (!van1)
                {
                    MessageBox.Show("Ya existe una localidad con ese nombre");
                    return;
                }

                bool resultado = AgregarLocalidadABD(local);
                if (resultado)
                {
                    MessageBox.Show("Localidad agregado con exito...");

                }
                else
                {
                    MessageBox.Show("Error al agregar la localidad...");
                }

                this.Close();

            }
        }

        
    }
}
