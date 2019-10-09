namespace Matricula.Docente {
    partial class FrmIEDocente {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIEDocente));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOpe = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.txtDirrecion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(437, 570);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 30);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(192)))), ((int)(((byte)(106)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(172, 570);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(154, 30);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Ingresar Detalles";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnSuperior.Controls.Add(this.lblTitulo);
            this.pnSuperior.Controls.Add(this.pictureBox1);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(757, 136);
            this.pnSuperior.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(183, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(330, 41);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Datos del Docente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOpe);
            this.groupBox1.Controls.Add(this.d);
            this.groupBox1.Controls.Add(this.lblCod);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboDistrito);
            this.groupBox1.Controls.Add(this.txtDirrecion);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboSexo);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.Fecha);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtCel);
            this.groupBox1.Controls.Add(this.txtApe);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 388);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // txtOpe
            // 
            this.txtOpe.AutoSize = true;
            this.txtOpe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtOpe.Location = new System.Drawing.Point(523, 55);
            this.txtOpe.Name = "txtOpe";
            this.txtOpe.Size = new System.Drawing.Size(17, 23);
            this.txtOpe.TabIndex = 25;
            this.txtOpe.Text = "-";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.d.Location = new System.Drawing.Point(377, 57);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(98, 21);
            this.d.TabIndex = 24;
            this.d.Text = "Operación:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCod.Location = new System.Drawing.Point(156, 55);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(17, 23);
            this.lblCod.TabIndex = 23;
            this.lblCod.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label11.Location = new System.Drawing.Point(15, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "Codigo:";
            // 
            // cboDistrito
            // 
            this.cboDistrito.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(527, 272);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(139, 29);
            this.cboDistrito.TabIndex = 21;
            // 
            // txtDirrecion
            // 
            this.txtDirrecion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDirrecion.Location = new System.Drawing.Point(160, 335);
            this.txtDirrecion.Name = "txtDirrecion";
            this.txtDirrecion.Size = new System.Drawing.Size(136, 27);
            this.txtDirrecion.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label10.Location = new System.Drawing.Point(15, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "Dirrecion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label9.Location = new System.Drawing.Point(379, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Distrito";
            // 
            // cboSexo
            // 
            this.cboSexo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cboSexo.Location = new System.Drawing.Point(527, 102);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(139, 29);
            this.cboSexo.TabIndex = 15;
            this.cboSexo.Text = "Selecione...";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtEmail.Location = new System.Drawing.Point(527, 215);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(139, 27);
            this.txtEmail.TabIndex = 14;
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Fecha.Location = new System.Drawing.Point(527, 160);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(139, 27);
            this.Fecha.TabIndex = 13;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDni.Location = new System.Drawing.Point(160, 272);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(136, 27);
            this.txtDni.TabIndex = 11;
            // 
            // txtCel
            // 
            this.txtCel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCel.Location = new System.Drawing.Point(160, 215);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(136, 27);
            this.txtCel.TabIndex = 10;
            // 
            // txtApe
            // 
            this.txtApe.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtApe.Location = new System.Drawing.Point(160, 157);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(136, 27);
            this.txtApe.TabIndex = 9;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNom.Location = new System.Drawing.Point(160, 102);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(136, 27);
            this.txtNom.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(379, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(377, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Nac:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(377, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(15, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dni:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(15, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(13, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(13, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // FrmIEDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 612);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnSuperior);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmIEDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIEDocente";
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label txtOpe;
        private System.Windows.Forms.Label d;
        public System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.TextBox txtDirrecion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox Fecha;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}