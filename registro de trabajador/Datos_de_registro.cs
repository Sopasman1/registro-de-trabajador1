using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registro_de_trabajador
{
    internal class Datos_de_registro
    {
        private string curp;

        public string Curp
        {
            get { return curp; }
            set { curp = value; }
        }

        private string rfc;

        public string Rfc
        {
            get { return rfc; }
            set { rfc = value; }
        }

        private string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

       public void Datosderegistro(string curp,string rfc,string correo,string phone)
        {
            this.curp = curp;
            this.rfc = rfc;
            this.correo = correo;
            this.phone = phone;
        }
    }
}
