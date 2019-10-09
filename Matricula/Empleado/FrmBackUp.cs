using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Matricula.Empleado {
    public partial class FrmBackUp : Form {
        public FrmBackUp() {
            InitializeComponent();
        }
        CNUtilitario util = new CNUtilitario();

        private void FrmBackUp_Load(object sender, EventArgs e) {
            llenarDB();
            wbE.Navigate("D:/DB/");
        }

        private void BtnCopia_Click(object sender, EventArgs e) {
            try {
                util.BackUp(cboDB.Text, txtEtiq.Text, (rbDif.Checked) ? (byte)1 : (byte)0);
            } catch(Exception ex) {
                MessageBox.Show("Primero debes hacer un Backup Completo. Error: " + ex.Message);
            } finally {
                string msj;
                if(rbDif.Checked) {
                    msj = "Diferencial";
                } else {
                    msj = "Completo";
                }
                MessageBox.Show("Se realizo el BackUp " + msj + " satisfactoriamente");
            }
        }

        public void llenarDB() {
            cboDB.DataSource = util.DBLis();
            cboDB.DisplayMember = "NAME";
            cboDB.ValueMember = "DBID";
        }
    }
}
