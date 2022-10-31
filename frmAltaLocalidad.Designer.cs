namespace Proyecto_TPI
{
    partial class frmAltaLocalidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodPostal = new System.Windows.Forms.MaskedTextBox();
            this.txtNomLocalidad = new System.Windows.Forms.TextBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.lblNomLocalidad = new System.Windows.Forms.Label();
            this.btnGuardarLocalid = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodPostal);
            this.groupBox1.Controls.Add(this.txtNomLocalidad);
            this.groupBox1.Controls.Add(this.lblCodPostal);
            this.groupBox1.Controls.Add(this.lblNomLocalidad);
            this.groupBox1.Location = new System.Drawing.Point(22, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Localidad";
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(134, 115);
            this.txtCodPostal.Mask = "99999";
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(152, 23);
            this.txtCodPostal.TabIndex = 6;
            this.txtCodPostal.ValidatingType = typeof(int);
            // 
            // txtNomLocalidad
            // 
            this.txtNomLocalidad.Location = new System.Drawing.Point(134, 60);
            this.txtNomLocalidad.Name = "txtNomLocalidad";
            this.txtNomLocalidad.Size = new System.Drawing.Size(152, 23);
            this.txtNomLocalidad.TabIndex = 2;
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodPostal.Location = new System.Drawing.Point(23, 113);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(105, 21);
            this.lblCodPostal.TabIndex = 1;
            this.lblCodPostal.Text = "Codigo Postal";
            // 
            // lblNomLocalidad
            // 
            this.lblNomLocalidad.AutoSize = true;
            this.lblNomLocalidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomLocalidad.Location = new System.Drawing.Point(39, 58);
            this.lblNomLocalidad.Name = "lblNomLocalidad";
            this.lblNomLocalidad.Size = new System.Drawing.Size(68, 21);
            this.lblNomLocalidad.TabIndex = 0;
            this.lblNomLocalidad.Text = "Nombre";
            // 
            // btnGuardarLocalid
            // 
            this.btnGuardarLocalid.Location = new System.Drawing.Point(252, 228);
            this.btnGuardarLocalid.Name = "btnGuardarLocalid";
            this.btnGuardarLocalid.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarLocalid.TabIndex = 5;
            this.btnGuardarLocalid.Text = "Guardar";
            this.btnGuardarLocalid.UseVisualStyleBackColor = true;
            this.btnGuardarLocalid.Click += new System.EventHandler(this.btnGuardarLocalid_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(156, 228);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmAltaLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 280);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarLocalid);
            this.Name = "frmAltaLocalidad";
            this.Text = "frmAltaLocalidad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label lblNomLocalidad;
        private TextBox txtNomLocalidad;
        private Label lblCodPostal;
        private Button btnCancelar;
        private Button btnGuardarLocalid;
        private MaskedTextBox txtCodPostal;
    }
}