namespace Matricula.Empleado {
    partial class FrmBackUp {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDif = new System.Windows.Forms.RadioButton();
            this.rbCom = new System.Windows.Forms.RadioButton();
            this.btnCopia = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEtiq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.wbE = new System.Windows.Forms.WebBrowser();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNomUsu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnSuperior.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnCopia);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 747);
            this.panel1.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupBox2.Controls.Add(this.rbDif);
            this.groupBox2.Controls.Add(this.rbCom);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(12, 440);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 125);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de BackUp";
            // 
            // rbDif
            // 
            this.rbDif.AutoSize = true;
            this.rbDif.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDif.Location = new System.Drawing.Point(13, 82);
            this.rbDif.Name = "rbDif";
            this.rbDif.Size = new System.Drawing.Size(168, 24);
            this.rbDif.TabIndex = 1;
            this.rbDif.TabStop = true;
            this.rbDif.Text = "BackUp Diferencial";
            this.rbDif.UseVisualStyleBackColor = true;
            // 
            // rbCom
            // 
            this.rbCom.AutoSize = true;
            this.rbCom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCom.Location = new System.Drawing.Point(13, 43);
            this.rbCom.Name = "rbCom";
            this.rbCom.Size = new System.Drawing.Size(162, 24);
            this.rbCom.TabIndex = 0;
            this.rbCom.TabStop = true;
            this.rbCom.Text = "BackUp Completo";
            this.rbCom.UseVisualStyleBackColor = true;
            // 
            // btnCopia
            // 
            this.btnCopia.FlatAppearance.BorderSize = 0;
            this.btnCopia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCopia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopia.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCopia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCopia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopia.Location = new System.Drawing.Point(18, 591);
            this.btnCopia.Name = "btnCopia";
            this.btnCopia.Size = new System.Drawing.Size(175, 52);
            this.btnCopia.TabIndex = 2;
            this.btnCopia.Text = "Generar Copia de Seguridad";
            this.btnCopia.UseVisualStyleBackColor = true;
            this.btnCopia.Click += new System.EventHandler(this.BtnCopia_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Firebrick;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(12, 690);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 35);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.groupBox1.Controls.Add(this.txtEtiq);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboDB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 230);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DB - Etiqueta";
            // 
            // txtEtiq
            // 
            this.txtEtiq.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEtiq.Location = new System.Drawing.Point(28, 181);
            this.txtEtiq.Name = "txtEtiq";
            this.txtEtiq.Size = new System.Drawing.Size(121, 26);
            this.txtEtiq.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Etiqueta al BackUp:";
            // 
            // cboDB
            // 
            this.cboDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDB.FormattingEnabled = true;
            this.cboDB.Location = new System.Drawing.Point(28, 87);
            this.cboDB.Name = "cboDB";
            this.cboDB.Size = new System.Drawing.Size(121, 28);
            this.cboDB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione DB:";
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnSuperior.Controls.Add(this.lblTitulo);
            this.pnSuperior.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnSuperior.Location = new System.Drawing.Point(207, 1);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(703, 161);
            this.pnSuperior.TabIndex = 11;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 27.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(28, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(380, 44);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Copia de Seguridad";
            // 
            // wbE
            // 
            this.wbE.Location = new System.Drawing.Point(218, 168);
            this.wbE.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbE.Name = "wbE";
            this.wbE.Size = new System.Drawing.Size(689, 506);
            this.wbE.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblNomUsu);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.panel3.Location = new System.Drawing.Point(215, 680);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 55);
            this.panel3.TabIndex = 17;
            // 
            // lblNomUsu
            // 
            this.lblNomUsu.AutoSize = true;
            this.lblNomUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNomUsu.Location = new System.Drawing.Point(3, 20);
            this.lblNomUsu.Name = "lblNomUsu";
            this.lblNomUsu.Size = new System.Drawing.Size(323, 17);
            this.lblNomUsu.TabIndex = 17;
            this.lblNomUsu.Text = "Desarrollado por: Torres Menacho, Brian Anthony";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(605, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Version: 0.1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(910, 747);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.wbE);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnSuperior);
            this.Name = "FrmBackUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBackUp";
            this.Load += new System.EventHandler(this.FrmBackUp_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCopia;
        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDif;
        private System.Windows.Forms.RadioButton rbCom;
        private System.Windows.Forms.TextBox txtEtiq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser wbE;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNomUsu;
        private System.Windows.Forms.Label label4;
    }
}