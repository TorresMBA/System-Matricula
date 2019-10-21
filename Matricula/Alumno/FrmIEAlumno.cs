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
            listarCarrera();
            listarDis();
            if(lblOpe.Text == "Nuevo") {
                listarApoS();
                /*tb = obj.ultApode();
                cboApo.Text = tb.Rows[0]["NOM_APODE"].ToString();*/
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
                if(cboSexo.Text == "M") {
                    cboSexo.Text = "Masculino";
                } else {
                    cboSexo.Text = "Femenino";
                }
                byte[] foto = (byte[])tb.Rows[0]["FOTO"];
                cboApo.Enabled = false;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(foto);
                pbFoto.Image = Image.FromStream(ms);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e) {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pbFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            if(lblOpe.Text == "Nuevo") {
                int idper = obj.IngresarPerso(0, txtNom.Text, txtApe.Text, txtCel.Text, txtDni.Text, txtEmail.Text, cboSexo.SelectedItem.ToString(), Fecha.Text, txtDirrecion.Text, Convert.ToInt16(cboDistrito.SelectedValue), ms.GetBuffer());
                obj.IngresarAlum(Convert.ToInt16(cboCarrera.SelectedValue), idper);

                MessageBox.Show("Registrado Correctamente");
                this.Close();
            } else {
                string sql = obj.ModificarAlum(int.Parse(lblid.Text), txtNom.Text, txtApe.Text, txtCel.Text, txtDni.Text, txtEmail.Text, cboSexo.SelectedItem.ToString(), Fecha.Text, txtDirrecion.Text, Convert.ToInt16(cboDistrito.SelectedValue), ms.GetBuffer());
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
        }

        public void listarCarrera() {
            CapaNegocio.CNGeneral obj = new CapaNegocio.CNGeneral();
            cboCarrera.DisplayMember = "NOM_CARRERA";
            cboCarrera.ValueMember = "ID_CARRERA";
            cboCarrera.DataSource = obj.ListarCarrera();
            cboCarrera.SelectedIndex = 0;
        }

        private void BtnSalir_Click_1(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnFoto_Click(object sender, EventArgs e) {
            OpenFileDialog abrir = new OpenFileDialog();
            DialogResult resul = abrir.ShowDialog();
            if(resul == DialogResult.OK) {
                pbFoto.Image = Image.FromFile(abrir.FileName);
            }

        }

        private void CboApo_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
