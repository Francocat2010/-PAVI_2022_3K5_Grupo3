namespace ProyectoTPI_3k5
{
    partial class frmAltaCliente
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.txtNroDocumento = new System.Windows.Forms.MaskedTextBox();
            this.txtNroCasa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarPersona = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.barriolbl = new System.Windows.Forms.Label();
            this.txtbarrio = new System.Windows.Forms.TextBox();
            this.chkactivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(136, 82);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(104, 30);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(246, 83);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 31);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(246, 132);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(265, 31);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(136, 130);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(105, 30);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNroDoc.Location = new System.Drawing.Point(56, 180);
            this.lblNroDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(184, 30);
            this.lblNroDoc.TabIndex = 11;
            this.lblNroDoc.Text = "Nro Documento:";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(248, 181);
            this.txtNroDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNroDocumento.Mask = "99999999";
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(265, 31);
            this.txtNroDocumento.TabIndex = 12;
            this.txtNroDocumento.ValidatingType = typeof(int);
            // 
            // txtNroCasa
            // 
            this.txtNroCasa.Location = new System.Drawing.Point(246, 279);
            this.txtNroCasa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNroCasa.Name = "txtNroCasa";
            this.txtNroCasa.Size = new System.Drawing.Size(271, 31);
            this.txtNroCasa.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(96, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nro. de casa:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(246, 231);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(271, 31);
            this.txtCalle.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(177, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Calle:";
            // 
            // btnGuardarPersona
            // 
            this.btnGuardarPersona.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarPersona.Location = new System.Drawing.Point(386, 459);
            this.btnGuardarPersona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarPersona.Name = "btnGuardarPersona";
            this.btnGuardarPersona.Size = new System.Drawing.Size(107, 82);
            this.btnGuardarPersona.TabIndex = 24;
            this.btnGuardarPersona.Text = "Guardar Persona";
            this.btnGuardarPersona.UseVisualStyleBackColor = true;
            this.btnGuardarPersona.Click += new System.EventHandler(this.btnGuardarPersona_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncancelar.Location = new System.Drawing.Point(136, 459);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(107, 82);
            this.btncancelar.TabIndex = 25;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(51, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 41);
            this.label4.TabIndex = 26;
            this.label4.Text = "Alta de nuevo cliente";
            // 
            // barriolbl
            // 
            this.barriolbl.AutoSize = true;
            this.barriolbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barriolbl.Location = new System.Drawing.Point(158, 336);
            this.barriolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.barriolbl.Name = "barriolbl";
            this.barriolbl.Size = new System.Drawing.Size(82, 30);
            this.barriolbl.TabIndex = 27;
            this.barriolbl.Text = "Barrio:";
            // 
            // txtbarrio
            // 
            this.txtbarrio.Location = new System.Drawing.Point(248, 337);
            this.txtbarrio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbarrio.Name = "txtbarrio";
            this.txtbarrio.Size = new System.Drawing.Size(271, 31);
            this.txtbarrio.TabIndex = 28;
            // 
            // chkactivo
            // 
            this.chkactivo.AutoSize = true;
            this.chkactivo.Location = new System.Drawing.Point(246, 398);
            this.chkactivo.Name = "chkactivo";
            this.chkactivo.Size = new System.Drawing.Size(85, 29);
            this.chkactivo.TabIndex = 29;
            this.chkactivo.Text = "activo";
            this.chkactivo.UseVisualStyleBackColor = true;
            // 
            // frmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 614);
            this.Controls.Add(this.chkactivo);
            this.Controls.Add(this.txtbarrio);
            this.Controls.Add(this.barriolbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnGuardarPersona);
            this.Controls.Add(this.txtNroCasa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAltaCliente";
            this.Text = "Nuevo cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private Label lblNroDoc;
        private MaskedTextBox txtNroDocumento;
        private TextBox txtNroCasa;
        private Label label2;
        private TextBox txtCalle;
        private Label label3;
        private Button btnGuardarPersona;
        private Button btncancelar;
        private Label label4;
        private Label barriolbl;
        private TextBox txtbarrio;
        private CheckBox chkactivo;
    }
}