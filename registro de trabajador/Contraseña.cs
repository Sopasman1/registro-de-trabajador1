using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registro_de_trabajador
{
    internal class Contraseña
    {
        private string digitos;

        public Contraseña(string digitos)
        {
            this.digitos = digitos;
        }

        public string Digitos
        {
            get { return digitos; }
        }

        public bool Verificar(string digitosingresados)
        {
            return digitos == digitosingresados;
        }
    }
}
