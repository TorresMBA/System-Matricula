﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio {
    public class CNAlumno {
        CapaData.DataAlumno obj = new CapaData.DataAlumno();
        public DataTable ListarAlum() {
            return obj.ListarAlum();
        }

        public string IngresarPerso(string nom, string ape, string telef, string dni, string email, string sexo, string fech, string dirrecion, int distri) {
            return obj.IngresarPerso(nom, ape, telef, dni, email, sexo, fech, dirrecion, distri);
        }

        public string IngresarAlum(int id_apode, int id_perso) {
            return obj.IngresarAlum(id_apode, id_perso);
        }

        public DataTable BuscarAlumID(string cod) {
            return obj.BuscarAlumID(cod);
        }

        public DataTable BuscarAlum(int num, string cod_a, string ape) {
            return obj.BuscarAlum(num, cod_a, ape);
        }

        public string ModificarAlum(int id, string nom, string ape, string telef, string dni, string email, string sexo, string fech, string dirrecion, int distri) {
            return obj.ModificarAlum(id, nom, ape, telef, dni, email, sexo, fech, dirrecion, distri);
        }

        public string EliminarAlum() {
            return "#";     
        }
    }
}
