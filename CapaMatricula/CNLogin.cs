using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio {
    public class CNLogin {
        CapaData.DataLogin obj = new CapaData.DataLogin();

        public bool Login(string user, string pass) {
            return obj.Login(user, pass);
        }
    }
}
