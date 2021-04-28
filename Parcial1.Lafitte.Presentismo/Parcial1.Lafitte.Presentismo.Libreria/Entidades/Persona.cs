using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Lafitte.Presentismo.Libreria.Entidades
{
    public abstract class Persona
    {
        private string _nombre;
        private string _apellido;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }

        public abstract string Display();
        public string ToString()
        {
            string msg = "";
            return msg;
        }
    }
}
