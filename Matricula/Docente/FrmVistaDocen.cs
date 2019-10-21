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
    public partial class FrmVistaDocen : Form {
        public FrmVistaDocen() {
            InitializeComponent();
        }
        

        private void BtnMenu_Click(object sender, EventArgs e) {
            FrmListarDocen obj = new FrmListarDocen();
            obj.ShowDialog();
        }

        private void FrmVistaDocen_Load(object sender, EventArgs e) {
            CapaNegocio.CNDocente obj = new CapaNegocio.CNDocente();
            GridDocen.DataSource = obj.ListarDocen();
        }

        private void FrmVistaDocen_Activated(object sender, EventArgs e) {
            CapaNegocio.CNDocente obj = new CapaNegocio.CNDocente();
            GridDocen.DataSource = obj.ListarDocen();
        }

        private void GridDocen_DoubleClick(object sender, EventArgs e) {
            FrmInfoDocente info = new FrmInfoDocente();
            info.lblDocente.Text = GridDocen.CurrentRow.Cells[0].Value.ToString();
            info.Show();
        }
    }
}
