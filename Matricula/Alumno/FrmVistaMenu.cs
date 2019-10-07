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
    public partial class FrmVistaMenu : Form {
        public FrmVistaMenu() {
            InitializeComponent();
        }

        private void FrnVistaMenu_Load(object sender, EventArgs e) {
            lblCod.Text = CacheLogin.NomUsu;
        }
    }
}
