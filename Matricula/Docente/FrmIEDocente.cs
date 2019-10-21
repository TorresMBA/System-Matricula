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

namespace Matricula.Docente {
    public partial class FrmIEDocente : Form {
        public FrmIEDocente() {
            InitializeComponent();
        }

        CNDocente obj = new CNDocente();

        private void BtnGuardar_Click(object sender, EventArgs e) {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pbFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            if(lblOpe.Text == "Nuevo") {
                int idper = obj.IngresarPerso(0, txtNom.Text, txtApe.Text, txtCel.Text, txtDni.Text, txtEmail.Text, cboSexo.SelectedItem.ToString(), Fecha.Text, txtDirrecion.Text, Convert.ToInt16(cboDistrito.SelectedValue), ms.GetBuffer());
                int idempl = obj.IngresarEmple(float.Parse(txtSueldo.Text), txtHora.Text, idper);
                string sql = obj.IngresarDocente(idempl, txtArea.Text);
                MessageBox.Show("Registrado Correctamente");
                this.Close();
            } else {
                string sql = obj.ModificarEmple(int.Parse(lblCod.Text), txtNom.Text, txtApe.Text, txtCel.Text, txtDni.Text, txtEmail.Text, cboSexo.SelectedItem.ToString(), Fecha.Text, txtDirrecion.Text, Convert.ToInt16(cboDistrito.SelectedValue), ms.GetBuffer());
                MessageBox.Show("Modificado Correctamente");
                this.Close();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void GroupBox1_Enter(object sender, EventArgs e) {

        }

        public void listarDis() {
            CapaNegocio.CNGeneral obj = new CapaNegocio.CNGeneral();
            cboDistrito.DisplayMember = "NOM_DIS";
            cboDistrito.ValueMember = "ID_DIS";
            cboDistrito.DataSource = obj.ListarDis();
            cboDistrito.SelectedIndex = 0;
        }

        private void FrmIEDocente_Load(object sender, EventArgs e) {
            listarDis();
            if(lblOpe.Text == "Nuevo") {
               
            } else {
                DataTable tb;
                tb = obj.BuscarEmpleID(lblCod.Text);
                lblId.Text = tb.Rows[0]["ID_PERSO"].ToString();
                lblCod.Text = tb.Rows[0]["COD_EMPLE"].ToString();
                txtNom.Text = tb.Rows[0]["NOM_PERSO"].ToString();
                txtApe.Text = tb.Rows[0]["APE_PERSO"].ToString();
                txtCel.Text = tb.Rows[0]["TELEFONO"].ToString();
                txtDni.Text = tb.Rows[0]["DNI"].ToString();
                txtEmail.Text = tb.Rows[0]["EMAIL"].ToString();
                cboSexo.Text = tb.Rows[0]["SEXO"].ToString();
                Fecha.Text = tb.Rows[0]["FECHA_NAC"].ToString();
                txtDirrecion.Text = tb.Rows[0]["DIRRECION"].ToString();
                cboDistrito.Text = tb.Rows[0]["NOM_DIS"].ToString();
                txtSueldo.Text = tb.Rows[0]["SUELDO_BASE"].ToString();
                txtHora.Text = tb.Rows[0]["HORAS_TRABAJO"].ToString();
                if(cboSexo.Text == "M") {
                    cboSexo.Text = "Masculino";
                } else {
                    cboSexo.Text = "Femenino";
                }
                byte[] foto = (byte[])tb.Rows[0]["FOTO"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(foto);
                pbFoto.Image = Image.FromStream(ms);
            }
        }
    }
}
