using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Matricula.Alumno {
    public partial class FrmAlumNoMatr : Form {
        public FrmAlumNoMatr() {
            InitializeComponent();
        }
        CapaNegocio.CNAlumno obj = new CapaNegocio.CNAlumno();
        private void FrmAlumNoMatr_Load(object sender, EventArgs e) {
            GridNoMatric.DataSource = obj.ListarAlumNoMatric();
        }

        private void PictureBox1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void GridNoMatric_DoubleClick(object sender, EventArgs e) {
            //FrmMatricula obj = new FrmMatricula();
            FrmMatricula f1 = Application.OpenForms.OfType<FrmMatricula>().SingleOrDefault();
            if(f1 != null) {
                //Donde Cells[0] = Columna 1, posición 0
                //GridNoMatric.CurrentRow.Cells[0].Value.ToString();
                f1.lblId.Text = GridNoMatric.CurrentRow.Cells[0].Value.ToString();
                f1.txtCod.Text = GridNoMatric.CurrentRow.Cells[1].Value.ToString();
                f1.txtNom.Text = GridNoMatric.CurrentRow.Cells[2].Value.ToString();
                f1.txtDni.Text = GridNoMatric.CurrentRow.Cells[5].Value.ToString();
                f1.txtCarrera.Text = GridNoMatric.CurrentRow.Cells[4].Value.ToString();
                this.Close(); 
            }
        }
    }
}
