using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTPI_3k5.Entidades;

namespace ProyectoTPI_3k5.ABMs
{
    public partial class AltaBarrios : Form
    {
        public AltaBarrios()
        {
            InitializeComponent();
        }

        private void AltaBarrios_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            txtNroBarrio.Visible = false;
            lblNroBarrio.Visible = false;
            //cargarGrilla()
            //CargarComboCiudad()
        }

        private void cargarComboCiudad()
        {
            cmbCiudad.DataSource = //BaseDeDatos.SelectTablas("Ciudad")
            cmbCiudad.DisplayMember = "Nombre";
            cmbCiudad.ValueMember = "CodPostal";
            cmbCiudad.SelectedIndex = -1;
        }

        private void cargarGrilla()
        {
            grillaBarrios.DataSource = //BaseDeDatos.SelecTablas("Barrio");

        }

        private Barrio ObtenerDatosBarrio()
        {
            Barrio bar = new Barrio();
            bar.NroBarrio = int.Parse(txtNroBarrio.Text);
            bar.Nombre = txtNombre.Text.Trim();
            bar.Ciudad = (int)cmbCiudad.SelectedValue;

            return bar;
        }

        private void validarIngresoDatos()
        {
            bool resultado = txtNombre.Text.Equals("") ||
            cmbCiudad.SelectedIndex.Equals(null);
        }

        //private bool ActualizarBarrio(Barrio bar)
        //{
        //    string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        //    SqlConnection cn = new SqlConnection(cadenaConex);
        //    bool Resultado = false;
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();

        //        string consulta = "UPDATE Barrio SET Nombre = @nombre_barrio, Nrociudad = @cod_ciudad" +
        //            " WHERE NroBarrio = @cod_barrio";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@cod_barrio", bar.NroBarrio);
        //        cmd.Parameters.AddWithValue("@nombre_barrio", bar.Nombre);
        //        cmd.Parameters.AddWithValue("@cod_ciudad", bar.Ciudad);
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = consulta;

        //        cn.Open();
        //        cmd.Connection = cn;
        //        cmd.ExecuteNonQuery();

        //        Resultado = true;

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("ERROR--->" + ex);
        //        throw;
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //    return Resultado;
        //}

        private void CargarCampos(Barrio bar)
        {
            txtNroBarrio.Text = bar.NroBarrio.ToString();
            txtNroBarrio.Visible = true;
            lblNroBarrio.Visible = true;
            txtNombre.Text = bar.Nombre;
            cmbCiudad.SelectedValue = bar.Ciudad;
        }

        //private bool CargarBarrio(Barrio bar)
        //{
        //    string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        //    SqlConnection cn = new SqlConnection(cadenaConex);
        //    bool Resultado = false;
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        string consulta = "insert into Barrio VALUES (@nombre_barrio,@cod_ciudad)";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@nombre_barrio", bar.Nombre);
        //        cmd.Parameters.AddWithValue("@cod_ciudad", bar.Ciudad);


        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = consulta;

        //        cn.Open();
        //        cmd.Connection = cn;
        //        cmd.ExecuteNonQuery();

        //        Resultado = true;

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("ERROR--->" + ex);
        //        throw;
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //    return Resultado;
        //}


        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (validarIngresoDatos())
            {
                MessageBox.Show("Ingrese todos los datos");
            }
            else
            {
                Barrio bar = ObtenerDatosBarrio();

                if(CargarBarrio(bar))
                {
                    MessageBox.Show("Cargado con exito");
                    LimpiarCampos()
                    cargarGrilla();
                    cargarComboCiudad();
                }
                else
                {
                    MessageBox.Show("Error al cargar el barrio");
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            cmbCiudad.SelectedValue = -1;
        }

        private void grillaBarrios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice > -1)
            {
                btnActualizar.Enabled = true;
                DataGridView filaSeleccionada = grillaBarrios.Rows[indice];
                string nroBarrio = filaSeleccionada.Cells["NroBarrio"].Value.ToString();
                Barrio bar = ObtenerBarrio(nroBarrio);
                LimpiarCampos();
                //el comando de abajo
                CargarCampos(bar);
            }
        }

        private bool EliminarExpediente(string nroBar)
        {
            //bool Resultado = false;
            //string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            //SqlConnection cn = new SqlConnection(cadenaConex);

            //try
            //{
            //    SqlCommand cmd = new SqlCommand();

            //    string consulta = " DELETE FROM Barrio WHERE NroBarrio= @cod_barrio";
            //    cmd.Parameters.Clear();
            //    cmd.Parameters.AddWithValue("cod_barrio", nroBar);
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = consulta;

            //    cn.Open();
            //    cmd.Connection = cn;
            //    cmd.ExecuteNonQuery();

            //    Resultado = true;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("ERROR--->" + ex);
            //    throw;
            //}
            //finally
            //{
            //    cn.Close();
            //}
            //return Resultado;
        }

        private void button1_Click(object sender, EventArgs e) //btnBaja
        {
            //if (txtNroBarrio.Text.Equals("0"))
            //{
            //    MessageBox.Show("Seleccione algun Barrio para eliminar");
            //}
            //else
            //{
            //    if (EliminarExpediente(textBoxNroBarrio.Text))
            //    {
            //        txtNroBarrio.Text = "0";
            //        txtNroBarrio.Visible = false;
            //        lblNroBarrio.Visible = false;
            //        btnActualizar.Enabled = false;

            //        MessageBox.Show("Eliminado con exito");
            //        cargarGrilla();
            //        LimpiarCampos();
            //        CargarComboCiudades();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error, no se pudo eliminar");
            //    }
            //}
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //if (validadIngresoDatos())
            //{
            //    MessageBox.Show("Ingrese Todos los datos");
            //}
            //else
            //{
            //    Barrio bar = ObtenerDatosBarrio();
            //    if (ActualizarBarrio(bar))
            //    {
            //        btnActualizar.Enabled = false;
            //        txtNroBarrio.Visible = false;
            //        lblNroBarrio.Visible = false;

            //        MessageBox.Show("Barrio Actualizado con exito");
            //        LimpiarCampos();
            //        cargarGrilla();
            //        CargarComboCiudad();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error al actualizar");
            //    }
            //}
        }
    }

      
}
