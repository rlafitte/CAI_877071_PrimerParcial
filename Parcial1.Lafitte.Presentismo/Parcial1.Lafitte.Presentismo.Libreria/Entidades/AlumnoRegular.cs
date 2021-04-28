using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Lafitte.Presentismo.Libreria.Entidades
{
    public class AlumnoRegular : Alumno
    {
        private string _email;
        public AlumnoRegular(int i, string s1, string s2, string s3)
        {

        }

        public string Email { get => _email; set => _email = value; }
    }
}
