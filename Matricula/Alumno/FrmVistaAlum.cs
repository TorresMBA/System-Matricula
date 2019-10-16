using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula.Alumno {
    public partial class FrmVistaAlum : Form {
        CapaNegocio.CNAlumno obj = new CapaNegocio.CNAlumno();
        public FrmVistaAlum() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            GridAlum.DataSource = obj.ListarAlum();
        }

        private void BtnMenuAlum_Click(object sender, EventArgs e) {
            FrmListarAlumno obj = new FrmListarAlumno();
            obj.Show();
        }

        private void View1_DoubleClick(object sender, EventArgs e) {
            Alumno.FrmInfoAlum obj = new Alumno.FrmInfoAlum();
            obj.lblAlum.Text = GridAlum.CurrentRow.Cells[1].Value.ToString();
            obj.Show();
        }

        private void BtnMenu_Click(object sender, EventArgs e) {
            FrmListarAlumno obj = new FrmListarAlumno();
            obj.Show();
        }

        private void FrmVistaAlum_Activated(object sender, EventArgs e) {
            GridAlum.DataSource = obj.ListarAlum();  
        }

        private void Txtape_TextChanged(object sender, EventArgs e) {

        }

        private void GroupBox1_Enter(object sender, EventArgs e) {

        }

        private void GridAlum_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
