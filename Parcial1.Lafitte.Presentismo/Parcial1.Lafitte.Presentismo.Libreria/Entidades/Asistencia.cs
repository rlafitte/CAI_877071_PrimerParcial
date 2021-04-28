using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Lafitte.Presentismo.Libreria.Entidades
{
    public class Asistencia
    {
        private string _fechaAsistencia;
        private DateTime _fechaHoraReal;
        private Preceptor _preceptor;
        private Alumno _alumno;
        private bool _estaPresente;

        public string FechaAsistencia1 { get => _fechaAsistencia; set => _fechaAsistencia = value; }
        public DateTime FechaHoraReal { get => _fechaHoraReal; set => _fechaHoraReal = value; }
        public Preceptor Preceptor { get => _preceptor; set => _preceptor = value; }
        public Alumno Alumno { get => _alumno; set => _alumno = value; }
        public bool EstaPresente { get => _estaPresente; set => _estaPresente = value; }

        public string FechaAsistencia()
        {
            string msg = "";
            return msg;
        }
        public string ToString()
        {
            //            Asistencia "FECHAREFERENCIA {ALUMNO FORMATEADO} está " +
            //              "presente {SI o NO} por {PRECEPTOR FORMATEADO} registrado el {FECHAHORAREAL}"
            return $"FECHAREFERENCIA {Alumno.ToString()} está presente ... por {Preceptor.ToString()} registrado el {FechaHoraReal}"  /*(if (this.EstaPresente ==true))*/ ;


        }
    }
}
