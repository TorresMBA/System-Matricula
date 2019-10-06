using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula.Docente {
    public partial class FrmIEDocente : Form {
        public FrmIEDocente() {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e) {
            FrmSueldoDocen obj = new FrmSueldoDocen();
            obj.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e) {

        }

        private void GroupBox1_Enter(object sender, EventArgs e) {

        }
    }
}
