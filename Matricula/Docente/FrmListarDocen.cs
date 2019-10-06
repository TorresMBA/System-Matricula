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
    public partial class FrmListarDocen : Form {
        public FrmListarDocen() {
            InitializeComponent();
        }

        private void FrmListarDocen_Load(object sender, EventArgs e) {
            CapaNegocio.CNDocente obj = new CapaNegocio.CNDocente();
            GridDocen.DataSource = obj.ListarDocen();
        }

        private void BtnSalir_Click(object sender, EventArgs e) {

        }

        private void BtnNuevo_Click(object sender, EventArgs e) {
            FrmIEDocente obj = new FrmIEDocente();
            obj.ShowDialog();
        }
    }
}
