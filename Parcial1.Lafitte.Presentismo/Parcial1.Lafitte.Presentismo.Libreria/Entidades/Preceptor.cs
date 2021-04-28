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

        internal override string Display()
        {

            return $"{this.Apellido} - {this.Legajo}";
        }
        //_preceptores.Add(new Preceptor(5, "Jorgelina", "Ramos", true));
        public Preceptor()
        {

        }
        public Preceptor(int i, string s1, string s2, bool b)
        {
            Preceptor P = new Preceptor();
            P.Legajo = i;
            P.Nombre = s1;
            P.Apellido = s2;
            P.Activo = b;
        }

    }
}
