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
    public partial class FrmSeccion : Form {
        public FrmSeccion() {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FrmSeccion_Load(object sender, EventArgs e) {
            CapaNegocio.CNGeneral obj = new CapaNegocio.CNGeneral();
            GridSeccion.DataSource = obj.ListarSeccion();
        }

        private void GridSeccion_DoubleClick(object sender, EventArgs e) {
            FrmMatricula f1 = Application.OpenForms.OfType<FrmMatricula>().SingleOrDefault();
            if(f1 != null) {
                //Donde Cells[0] = Columna 1, posición 0
                f1.lblSec.Text = GridSeccion.CurrentRow.Cells[0].Value.ToString();
                f1.txtSeccion.Text = GridSeccion.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
        }

        private void GridSeccion_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
