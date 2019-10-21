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
    public partial class FrmIEUsuario : Form {
        public FrmIEUsuario() {
            InitializeComponent();
        }

        private void LblCod_Click(object sender, EventArgs e) {

        }

        private void BtnUsu_Click(object sender, EventArgs e) {
            FrmUsuarios obj = new FrmUsuarios();
            obj.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e) {
            CapaNegocio.CNUsuario obj = new CapaNegocio.CNUsuario();
            try {
                obj.IngresarUsuario(lblCod.Text, lblPass.Text, lblPosi.Text);
                MessageBox.Show("Usuario Creado Correctamente");
                this.Close();
            }catch(Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
