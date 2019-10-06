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
    public partial class FrmIEAlumno : Form {
        CapaNegocio.CNAlumno obj = new CapaNegocio.CNAlumno();
        public FrmIEAlumno() {
            InitializeComponent();
        }

        private void FrmAlumno_Load(object sender, EventArgs e) {
            listarDis();
            if(lblOpe.Text == "Nuevo") {
                CapaNegocio.CNGeneral obj = new CapaNegocio.CNGeneral();
                DataTable tb = new DataTable();
                listarApoS();
                tb = obj.ultApode();
                cboApo.Text = tb.Rows[0]["NOM_APODE"].ToString();
            } else {
                DataTable tb = new DataTable();
              
                tb = obj.BuscarAlumID(lblCod.Text);
                lblid.Text = tb.Rows[0]["ID_PERSO"].ToString();
                txtNom.Text = tb.Rows[0]["NOM_PERSO"].ToString();
                txtApe.Text = tb.Rows[0]["APE_PERSO"].ToString();
                txtCel.Text = tb.Rows[0]["TELEFONO"].ToString();
                txtDni.Text = tb.Rows[0]["DNI"].ToString();
                txtDirrecion.Text = tb.Rows[0]["DIRRECION"].ToString();
                Fecha.Text = tb.Rows[0]["FECHA_NAC"].ToString();
                txtEmail.Text = tb.Rows[0]["EMAIL"].ToString();
                cboApo.Text = tb.Rows[0]["NOM_APODE"].ToString();
                cboDistrito.Text = tb.Rows[0]["NOM_DIS"].ToString();
                cboSexo.Text = tb.Rows[0]["SEXO"].ToString();
                cboApo.Enabled = false;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e) {
            if(lblOpe.Text == "Nuevo") {
                string sql = obj.IngresarPerso(txtNom.Text, txtApe.Text, txtCel.Text, txtDni.Text, txtEmail.Text, cboSexo.SelectedItem.ToString(), Fecha.Text, txtDirrecion.Text, Convert.ToInt16(cboDistrito.SelectedIndex));
                CapaNegocio.CNGeneral gen = new CapaNegocio.CNGeneral();
                int id_perso = Convert.ToInt16(gen.ultPerso().Rows[0]["ID_PERSO"]);
                string sql2 = obj.IngresarAlum(int.Parse(cboApo.SelectedValue.ToString()), id_perso);
                MessageBox.Show("Datos: " + cboApo.SelectedValue.ToString() + "||" + id_perso);
                this.Close();
            } else {
                string sql = obj.ModificarAlum(int.Parse(lblid.Text), txtNom.Text, txtApe.Text, txtCel.Text, txtDni.Text, txtEmail.Text, cboSexo.SelectedItem.ToString(), Fecha.Text, txtDirrecion.Text, Convert.ToInt16(cboDistrito.SelectedIndex));
                MessageBox.Show("Modificado Correctamente");
                this.Close();
            }
        }

        public void listarDis() {
            CapaNegocio.CNGeneral obj = new CapaNegocio.CNGeneral();
            cboDistrito.DisplayMember = "NOM_DIS";
            cboDistrito.ValueMember = "ID_DIS";
            cboDistrito.DataSource = obj.ListarDis();
            cboDistrito.SelectedIndex = 0;
        }

        public void listarApoS() {
            CapaNegocio.CNGeneral obj = new CapaNegocio.CNGeneral();
            cboApo.DisplayMember = "NOM_APODE";
            cboApo.ValueMember = "ID_APODE";
            cboApo.DataSource = obj.ListarApoS();
            cboDistrito.SelectedIndex = 1;
        }

        private void BtnSalir_Click_1(object sender, EventArgs e) {
            this.Close();
        }
    }
}
