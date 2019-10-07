using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula.Alumno {
    public partial class FrmInfoAlum : Form {
        CapaNegocio.CNAlumno obj = new CapaNegocio.CNAlumno();
        public FrmInfoAlum() {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FrmInfoAlum_Load(object sender, EventArgs e) {
            DataTable tb = new DataTable();
            tb = obj.BuscarAlumID(lblAlum.Text);
            lblNom.Text = tb.Rows[0]["NOM_PERSO"].ToString();
            lblApe.Text = tb.Rows[0]["APE_PERSO"].ToString();
            lblCarrera.Text = tb.Rows[0]["NOM_CARRERA"].ToString();
            GridInfoAlum.DataSource = obj.BuscarCursosID(lblAlum.Text);
        }
    }
}
