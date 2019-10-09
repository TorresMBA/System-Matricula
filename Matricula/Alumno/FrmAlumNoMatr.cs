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
    }
}
