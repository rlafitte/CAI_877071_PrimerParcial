using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Lafitte.Presentismo.Libreria.Entidades
{
    public class Preceptor : Persona
    {
        private int _legajo;
        private bool _activo;

        public int Legajo { get => _legajo; set => _legajo = value; }
        public bool Activo { get => _activo; set => _activo = value; }

        public override string Display()
        {
            throw new NotImplementedException();
        }
    }
}
