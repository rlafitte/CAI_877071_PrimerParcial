using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Lafitte.Presentismo.Libreria.Entidades
{
    public abstract class Alumno : Persona
    {
        private int _registro;

        public int Registro { get => _registro; set => _registro = value; }

        internal override string Display()
        {
            return $"{this.Nombre} ({this.Registro})";
            //throw new NotImplementedException();
        }
        public string ToString()
        {
            return this.Display();
        }
    }
}
