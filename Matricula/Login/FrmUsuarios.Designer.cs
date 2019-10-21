namespace Matricula.Login {
    partial class FrmUsuarios {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GridUsuarios = new System.Windows.Forms.DataGridView();
            this.GridEmple = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmple)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // GridUsuarios
            // 
            this.GridUsuarios.AllowUserToAddRows = false;
            this.GridUsuarios.AllowUserToDeleteRows = false;
            this.GridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUsuarios.Location = new System.Drawing.Point(12, 40);
            this.GridUsuarios.Name = "GridUsuarios";
            this.GridUsuarios.ReadOnly = true;
            this.GridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUsuarios.Size = new System.Drawing.Size(299, 227);
            this.GridUsuarios.TabIndex = 17;
            this.GridUsuarios.DoubleClick += new System.EventHandler(this.GridUsuarios_DoubleClick);
            // 
            // GridEmple
            // 
            this.GridEmple.AllowUserToAddRows = false;
            this.GridEmple.AllowUserToDeleteRows = false;
            this.GridEmple.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridEmple.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridEmple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmple.Location = new System.Drawing.Point(12, 283);
            this.GridEmple.Name = "GridEmple";
            this.GridEmple.ReadOnly = true;
            this.GridEmple.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEmple.Size = new System.Drawing.Size(299, 227);
            this.GridEmple.TabIndex = 19;
            this.GridEmple.DoubleClick += new System.EventHandler(this.GridEmple_DoubleClick);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 526);
            this.Controls.Add(this.GridEmple);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GridUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmple)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView GridUsuarios;
        private System.Windows.Forms.DataGridView GridEmple;
    }
}