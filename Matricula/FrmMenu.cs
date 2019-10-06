﻿using System;
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
            Empleado.FrmEmpleado obj = new Empleado.FrmEmpleado();
            obj.Show();
        }

        private void ListarDocen_Click(object sender, EventArgs e) {
            Docente.FrmListarDocen obj = new Docente.FrmListarDocen();
            obj.ShowDialog();

        }

        private void Button1_Click(object sender, EventArgs e) {
            mostrar(new Alumno.FrmVistaAlum());
        }

        public void mostrar(object from) {
            if(pnMostrar.Controls.Count > 0) {
                pnMostrar.Controls.RemoveAt(0);
            } else {
                Form obj = from as Form;
                obj.TopLevel = false;
                obj.Dock = DockStyle.Fill;
                pnMostrar.Controls.Add(obj);
                pnMostrar.Tag = obj;
                obj.Show();
            }
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
    }
}
