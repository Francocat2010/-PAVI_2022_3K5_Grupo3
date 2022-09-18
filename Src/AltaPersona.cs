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
    public partial class AltaPersona : Form
    {
        public AltaPersona()
        {
            InitializeComponent();
        }

        private void AltaPersona_Load(object sender, EventArgs e)
        {
            txtCantidadDeHijos.Enabled = false;
            


            cboCarrera.Items.Add("Ing. en Sistemas");
            cboCarrera.Items.Add("Ing. Industrila");
            cboCarrera.Items.Add("Ing. Mecatronica");


            cboTipoDoc.Items.Add("DNI");
            cboTipoDoc.Items.Add("Passport");
            cboTipoDoc.Items.Add("Libreta universitaria");
        }

        private void btnGuardarPersona_Click(object sender, EventArgs e)
        {
            string resultado = "";

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string fechaNacimiento = txtFechaNacimiento.Text;
            string sexo = "";
            if (rdMasculino.Checked)
            {
                sexo = "Masculino";
            }
            if (rdFemenino.Checked)
            {
                sexo = "Femenino";
            }
            if (rdOtros.Checked)
            {
                sexo = "Otro";
            }
            string tipoDocumento = cboTipoDoc.GetItemText(cboTipoDoc.SelectedItem);
            string nroDocumento = txtNroDocumento.Text;
            string calle = txtCalle.Text;
            string nroCasa = txtNroCasa.Text;

            string soltero = "";
            string casado = "";
            string hijos = "";
            string cantidadHijos = "";
            if (chkSoltero.Checked)
            {
                soltero = "Soltero";
            }
            else
            {
                soltero = "No es soltero";
            }
            if (chkCasado.Checked)
            {
                casado = "Casado";
            }
            else
            {
                casado = "No es casado";

            }
            if (chkHijos.Checked)
            {
                hijos = "Si tiene hijos";
                cantidadHijos = txtCantidadDeHijos.Text;
            }
            else
            {
                hijos = "No tiene Hijos";
            }

            string carrera = cboCarrera.GetItemText(cboCarrera.SelectedItem);

            MessageBox.Show(nombre + " " + apellido + " " + sexo + " " + nroDocumento);
        }

        private void chkHijos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHijos.Checked)
            {
                txtCantidadDeHijos.Enabled = true;
            }
            else
            {
                txtCantidadDeHijos.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos() 
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtFechaNacimiento.Text = "";
            txtCantidadDeHijos = "";
            txtNroCasa = "";
            txtNroDocumento = "";

        }
    }
}
