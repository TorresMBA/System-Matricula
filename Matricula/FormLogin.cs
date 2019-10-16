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
    public partial class FormLogin : Form {
        public FormLogin() {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Login.FrmRecuperar obj = new Login.FrmRecuperar();
            obj.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e) {
            FrmMenu obj = new FrmMenu();
            obj.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e) {
            if(txtUsu.Text != "Usuario" ) {
                if(txtPass.Text != "Password") {
                    CapaNegocio.CNLogin obj = new CapaNegocio.CNLogin();
                    var validlogin = obj.Login(txtUsu.Text, txtPass.Text);
                    if(validlogin) {
                        if(CacheLogin.Posiicion == CachePosicion.Administrativo) {
                            FrmMenu menu = new FrmMenu();
                            menu.Show();
                            menu.FormClosed += CerrarSesion;
                            notifi1.ShowBalloonTip(200);
                            this.Hide();
                        }
                        if(CacheLogin.Posiicion == CachePosicion.Docente) {
                            Docente.FrmMenuDocente docente = new Docente.FrmMenuDocente();
                            docente.Show();
                            docente.FormClosed += CerrarSesion;
                            notifi1.ShowBalloonTip(200);
                            this.Hide();
                        }
                        if(CacheLogin.Posiicion == CachePosicion.Alumno) {
                            Alumno.FrmMenuAlumno alumno = new Alumno.FrmMenuAlumno();
                            alumno.Show();
                            alumno.FormClosed += CerrarSesion;
                            notifi1.ShowBalloonTip(200);
                            this.Hide();
                        }                      
                    } else {
                        mensaje("Usuario o Contraseaña Incorrecto, Intente Nuevamente");
                        txtPass.Text = "Password";
                        txtUsu.Focus();
                    }
                } else {
                    mensaje("Ingrese su Contraseña");
                }
            } else {
                mensaje("Ingrese su Usuario");
            }          
        }

        private void TxtUsu_Enter(object sender, EventArgs e) {
            if(txtUsu.Text == "Usuario") {
                txtUsu.Text = "";
                txtUsu.ForeColor = Color.LightGray;
            }
        }

        private void TxtUsu_Leave(object sender, EventArgs e) {
            if(txtUsu.Text == "") {
                txtUsu.Text = "Usuario";
                txtUsu.ForeColor = Color.LightGray;
            }
        }

        private void TxtPass_Enter(object sender, EventArgs e) {
            if(txtPass.Text == "Password") {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void TxtPass_Leave(object sender, EventArgs e) {
            if(txtPass.Text == "") {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void mensaje(string msg) {
            lblErrorSesion.Text = " " + msg;
            lblErrorSesion.Visible = true;
        }

        private void LinkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e) {
            Login.FrmRecuperar obj = new Login.FrmRecuperar();
            obj.Show();
            this.Hide();
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e) {
            txtPass.Text = "Password";
            txtPass.UseSystemPasswordChar = false;
            txtUsu.Text = "Usuario";
            lblErrorSesion.Visible = false;
            this.Show();
            txtUsu.Focus();
        }
    }
}
