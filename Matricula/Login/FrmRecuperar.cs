using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula.Login {
    public partial class FrmRecuperar : Form {
        public FrmRecuperar() {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            FormLogin obj = new FormLogin();
            obj.Show();
            this.Close();
        }

        private void FrmRecuperar_Load(object sender, EventArgs e) {

        }
    }
}
