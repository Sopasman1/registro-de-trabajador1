using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registro_de_trabajador
{
    internal class Datos_de_persona
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellidoPaterno;

        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }

        private string apellidomaterno;

        public string Apellidomaterno
        {
            get{ return apellidomaterno; }
            set { apellidomaterno = value; }
        }

        private DateTime cumple;

        public DateTime Cumple
        {
            get { return cumple; }
            set { cumple = value; }
        }

        private string edad;

        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public Datos_de_persona()
        {
            edad ="";
            apellidoPaterno = "";
            apellidomaterno = "";
            cumple = DateTime.MinValue;
        }

        public override string ToString()
        {
            return nombre.ToString()+apellidoPaterno.ToString()+apellidomaterno.ToString()+cumple.ToString()+edad.ToString();
        }
    }
}
