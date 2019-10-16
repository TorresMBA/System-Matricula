using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula.Login {
    public partial class FrmVistaUsu : Form {
        public FrmVistaUsu() {
            InitializeComponent();
        }
        CapaNegocio.CNUsuario usu = new CapaNegocio.CNUsuario();
        private void BtnMenu_Click(object sender, EventArgs e) {
            FrmListarUsuario obj = new FrmListarUsuario();
            obj.Show();
        }

        private void FrmVistaUsu_Load(object sender, EventArgs e) {
            GridUsu.DataSource = usu.ListarUsu();
        }
    }
}
