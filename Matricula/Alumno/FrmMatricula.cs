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
    public partial class FrmMatricula : Form {
        public FrmMatricula() {
            InitializeComponent();
        }

        private void FrmMatricula_Load(object sender, EventArgs e) {
            listarCiclo();
        }

        public void listarCiclo() {
            CapaNegocio.CNGeneral obj = new CapaNegocio.CNGeneral();
            cboCiclo.DisplayMember = "NOM_CICLO";
            cboCiclo.ValueMember = "ID_CICLO";
            cboCiclo.DataSource = obj.ListarCiclo();
        }

        private void Button1_Click(object sender, EventArgs e) {
            FrmSeccion obj = new FrmSeccion();
            obj.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e) {
            FrmAlumNoMatr obj = new FrmAlumNoMatr();
            obj.Show();
        }

        private void BtnSeccion_Click(object sender, EventArgs e) {
            FrmSeccion obj = new FrmSeccion();
            obj.Show();
        }

        private void BtnGuardar_Click(object sender, EventArgs e) {
            CapaNegocio.CNAlumno obj = new CapaNegocio.CNAlumno();
            try {
                string fecha = dateTimePicker1.Value.Date.ToShortDateString();
                obj.IngresarMatricula(Convert.ToInt16(lblId.Text), cboTurno.SelectedItem.ToString(), cboPeriodo.SelectedItem.ToString(), Convert.ToInt16(lblSec.Text), Convert.ToInt16(cboCiclo.SelectedValue), fecha);
                MessageBox.Show("Se Matriculo Satisfactoriamente");
                btnGuardar.Enabled = false;
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
