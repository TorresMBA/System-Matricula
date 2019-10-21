using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun.Cache;

namespace Matricula.Alumno {
    public partial class FrmMenuAlumno : Form {
        public FrmMenuAlumno() {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e) {
            if(MessageBox.Show("¿Desea Cerrar la Aplicacion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e) {
            if(MessageBox.Show("¿Desea Cerrar Sesion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                this.Close();
            }
        }

        private void BtnDocen_Click(object sender, EventArgs e) {
           
        }

        private void FrmMenuAlumno_Load(object sender, EventArgs e) {
         
        }

        private void BtnEmple_Click(object sender, EventArgs e) {

        }
    }
}
