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
    public partial class FrmListarAlumno : Form {
        CapaNegocio.CNAlumno obj = new CapaNegocio.CNAlumno();
        public FrmListarAlumno() {
            InitializeComponent();
        }

        private void FrmListarAlumno_Load(object sender, EventArgs e) {         
            GridLisAlum.DataSource = obj.ListarAlum();
        }

        private void Button1_Click(object sender, EventArgs e) {
            /*FrmIEAlumno obj = new FrmIEAlumno();
            obj.txtOpe.Text = "Nuevo";
            obj.ShowDialog();*/
            FrmIngApode obj = new FrmIngApode();
            obj.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e) {
            FrmIEAlumno obj = new FrmIEAlumno();
            obj.lblTitulo.Text = "Editar Alumno";
            obj.lblOpe.Text = "Editar";
            obj.btnGuardar.Text = "Modificar";
            obj.lblCod.Text = GridLisAlum.CurrentRow.Cells[1].Value.ToString();
            obj.ShowDialog();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            FrmInfoAlum obj = new FrmInfoAlum();
            obj.lblAlum.Text = GridLisAlum.CurrentRow.Cells[1].Value.ToString();
            obj.Show();
        }

        private void TxtCod_TextChanged(object sender, EventArgs e) {
            string cod = txtCod.Text;
            CapaNegocio.CNAlumno obj = new CapaNegocio.CNAlumno();
            GridLisAlum.DataSource = obj.BuscarAlum(1, cod, "");
        }

        private void TxtApe_TextChanged(object sender, EventArgs e) {
            try {
                string ape = txtApe.Text;
                CapaNegocio.CNAlumno obj = new CapaNegocio.CNAlumno();
                GridLisAlum.DataSource = obj.BuscarAlum(2, "", ape);
            } catch(Exception ex) {

            }
        }

        private void FrmListarAlumno_Activated(object sender, EventArgs e) {
            GridLisAlum.DataSource = obj.ListarAlum();
        }

        private void BtnAlum_Click(object sender, EventArgs e) {
            Alumno.FrmIEAlumno obj = new Alumno.FrmIEAlumno();
            obj.lblOpe.Text = "Nuevo";
            obj.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e) {
            CapaNegocio.CNAlumno obj = new CapaNegocio.CNAlumno();
            
        }

        private void Button4_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Button1_Click_1(object sender, EventArgs e) {
            Alumno.FrmAlumNoMatr obj = new FrmAlumNoMatr();
            obj.Show();
        }
    }
}
