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
    public partial class FrmUsuarios : Form {
        public FrmUsuarios() {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e) {
            CapaNegocio.CNGeneral obj = new CapaNegocio.CNGeneral();
            GridEmple.DataSource = obj.ListarEmpleados();
            asd();
        }

        public void asd() {
            CapaNegocio.CNGeneral obj = new CapaNegocio.CNGeneral();
            GridUsuarios.DataSource = obj.ListarPersonas();
        }

        private void PictureBox1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void GridEmple_DoubleClick(object sender, EventArgs e) {
            FrmIEUsuario f1 = Application.OpenForms.OfType<FrmIEUsuario>().SingleOrDefault();
            if(f1 != null) {
                //Donde Cells[0] = Columna 1, posición 0
                //GridNoMatric.CurrentRow.Cells[0].Value.ToString();
                f1.lblCod.Text = GridEmple.CurrentRow.Cells[0].Value.ToString();
                f1.lblPass.Text = GridEmple.CurrentRow.Cells[2].Value.ToString();
                f1.lblPosi.Text = GridEmple.CurrentRow.Cells[3].Value.ToString();
                this.Close();
            }
        }

        private void GridUsuarios_DoubleClick(object sender, EventArgs e) {
            FrmIEUsuario f1 = Application.OpenForms.OfType<FrmIEUsuario>().SingleOrDefault();
            if(f1 != null) {
                //Donde Cells[0] = Columna 1, posición 0
                //GridNoMatric.CurrentRow.Cells[0].Value.ToString();
                f1.lblCod.Text = GridUsuarios.CurrentRow.Cells[0].Value.ToString();
                f1.lblPass.Text = GridUsuarios.CurrentRow.Cells[2].Value.ToString();
                f1.lblPosi.Text = GridUsuarios.CurrentRow.Cells[3].Value.ToString();
                this.Close();
            }
        }
    }
}
