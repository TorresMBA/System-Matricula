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
    public partial class FrmEmpleado : Form {
        public FrmEmpleado() {
            InitializeComponent();
        }
        CapaMatricula.CNEmpleado obj = new CapaMatricula.CNEmpleado();

        private void FrmEmpleado_Load(object sender, EventArgs e) {
            dtgEmple.DataSource = obj.ListarEmple();
            mostrar_datos();
        }

        public void mostrar_datos() {
            dtgEmple.Columns[0].Width = 25;
            dtgEmple.Columns[1].Width = 45;
            dtgEmple.Columns[12].Width = 45;
            dtgEmple.Columns[8].Width = 35;
        }
    }
}
