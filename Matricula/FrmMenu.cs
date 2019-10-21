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

namespace Matricula {
    public partial class FrmMenu : Form {
        public FrmMenu() {
            InitializeComponent();
        }

        private void IngresarEmpleadoToolStripMenuItem1_Click(object sender, EventArgs e) {
            Empleado.FrmIEEmpleado obj = new Empleado.FrmIEEmpleado();
            obj.Show();
        }

        private void ListarDocen_Click(object sender, EventArgs e) {
            Docente.FrmListarDocen obj = new Docente.FrmListarDocen();
            obj.Show();

        }

        private void Button1_Click(object sender, EventArgs e) {
            mostrar(new Alumno.FrmVistaAlum());
        }

        public void mostrar(object frm) {
            if(pnMostrar.Controls.Count > 0) {
                pnMostrar.Controls.RemoveAt(0);
            }
            Form obj = frm as Form;
            //Form obj = new Alumno.FrmIEAlumno() as Form;
            obj.TopLevel = false;
            obj.Dock = DockStyle.Fill;
            pnMostrar.Controls.Add(obj);
            pnMostrar.Tag = obj;
            obj.Show();
        }

        private void BtnDocen_Click(object sender, EventArgs e) {
            mostrar(new Docente.FrmVistaDocen());
        }

        private void Button5_Click(object sender, EventArgs e) {
            if(MessageBox.Show("¿Desea Cerrar Sesion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)  == DialogResult.Yes) {
                this.Close();
            }
        }

        private void Button4_Click(object sender, EventArgs e) {
            if(MessageBox.Show("¿Desea Cerrar la Aplicacion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void LoadDAtoUser() {
            lblCod.Text = CacheLogin.NomUsu;
            lblPosicio.Text = CacheLogin.Posiicion.ToString();
        }

        private void FrmMenu_Load(object sender, EventArgs e) {
            LoadDAtoUser();    
        }

        private void BtnEmple_Click(object sender, EventArgs e) {
            mostrar(new Empleado.FrmVistaEmple());
        }

        private void BackUpsToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }

        private void ClasesToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursos.FrmCursos curso = new Cursos.FrmCursos();
            curso.Show();
        }

        private void BtnUsu_Click(object sender, EventArgs e) {
            mostrar(new Login.FrmVistaUsu());
        }

        private void RegistroDeMatriculasToolStripMenuItem_Click(object sender, EventArgs e) {
            Alumno.FrmMatricula mat = new Alumno.FrmMatricula();
            mat.Show();
        }

        private void SalisToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void CrearUnBackUpToolStripMenuItem_Click(object sender, EventArgs e) {
            Empleado.FrmBackUp bac = new Empleado.FrmBackUp();
            bac.Show();
        }

        private void RestaurarDBToolStripMenuItem_Click(object sender, EventArgs e) {
            Empleado.FrmRestoreBackUp obj = new Empleado.FrmRestoreBackUp();
            obj.Show();
        }

        private void RegistrarEmp_Click(object sender, EventArgs e) {
            Empleado.FrmIEEmpleado obj = new Empleado.FrmIEEmpleado();
            obj.Show();
        }

        private void RegistrarDocenteToolStripMenuItem_Click(object sender, EventArgs e) {
            Docente.FrmIEDocente obj = new Docente.FrmIEDocente();
            obj.lblOpe.Text = "Nuevo";
            obj.Show();
        }

        private void IngresarPersonalToolStripMenuItem_Click(object sender, EventArgs e) {
            Login.FrmIEUsuario obj = new Login.FrmIEUsuario();
            obj.Show();
        }
    }
}
