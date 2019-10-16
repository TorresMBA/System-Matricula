using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula.Empleado {
    public partial class FrmVistaEmple : Form {
        public FrmVistaEmple() {
            InitializeComponent();
        }
        CapaNegocio.CNEmpleado emple = new CapaNegocio.CNEmpleado();

        private void BtnMenu_Click(object sender, EventArgs e) {
            FrmListarEmpleado obj = new FrmListarEmpleado();
            obj.Show();
        }

        private void FrmVistaEmple_Activated(object sender, EventArgs e) {
            GridEmple.DataSource = emple.ListarEmple();
        }

        private void GridAlum_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void GridAlum_DoubleClick(object sender, EventArgs e) {

        }

        private void FrmVistaEmple_Load(object sender, EventArgs e) {
            GridEmple.DataSource = emple.ListarEmple();
        }
    }
}
