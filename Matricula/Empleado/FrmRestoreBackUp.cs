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
    public partial class FrmRestoreBackUp : Form {
        public FrmRestoreBackUp() {
            InitializeComponent();
        }
        CapaNegocio.CNUtilitario obj = new CapaNegocio.CNUtilitario();

        private void BtnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnCopia_Click(object sender, EventArgs e) {        
            obj.Restaurar(txtNomDB.Text, txtNomCopia.Text);
            Resutaracion.BalloonTipText = "Backup Restaurado:" + txtNomCopia.Text;
            Resutaracion.ShowBalloonTip(100);
            GridDB.DataSource = obj.DBLis();
        }

        private void FrmRestoreBackUp_Load(object sender, EventArgs e) {
            wbE.Navigate("D:\\DB");
        }
    }
}
