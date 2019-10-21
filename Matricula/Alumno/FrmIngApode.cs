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
    public partial class FrmIngApode : Form {
        public FrmIngApode() {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e) {
          
        }

        private void BtnAgrandar_Click(object sender, EventArgs e) {
            gbApode.Height = 700;
        }

        private void BtnGuardar_Click(object sender, EventArgs e) {
            CapaNegocio.CNApoderado obj = new CapaNegocio.CNApoderado();
            FrmIEAlumno al = new FrmIEAlumno();
            al.lblOpe.Text = "Nuevo";
            al.Show();
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e) {
            FrmIEAlumno obj = new FrmIEAlumno();
            CapaNegocio.CNApoderado apo = new CapaNegocio.CNApoderado();
            string sql = apo.IngApode(txtNom.Text, txtApe.Text, cboParen.SelectedItem.ToString(), txtDni.Text, Fecha.Text, txtCel.Text, cboEstado.SelectedItem.ToString(), txtDirrecion.Text, cboSexo.Text.Substring(0,1), Convert.ToInt32(cboDistrito.SelectedValue));
            obj.lblOpe.Text = "Nuevo";
            obj.Show();
            this.Hide();
        }

        private void FrmIngApode_Load(object sender, EventArgs e) {
            listarDis();
        }

        public void listarDis() {
            CapaNegocio.CNGeneral obj = new CapaNegocio.CNGeneral();
            cboDistrito.DisplayMember = "NOM_DIS";
            cboDistrito.ValueMember = "ID_DIS";
            cboDistrito.DataSource = obj.ListarDis();
            cboDistrito.SelectedIndex = 0;
        }

        private void BtnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
