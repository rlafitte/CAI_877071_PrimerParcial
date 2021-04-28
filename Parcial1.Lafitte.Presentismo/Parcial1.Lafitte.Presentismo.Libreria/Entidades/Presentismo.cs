using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Lafitte.Presentismo.Libreria.Entidades
{
    public class Presentismo
    {
        List<Alumno> _alumnos;
        List<Asistencia> _asistencias;
        List<Preceptor> _preceptores;
        public Presentismo()
        {
            _alumnos = new List<Alumno>();
            _asistencias = new List<Asistencia>();
            _preceptores = new List<Preceptor>();

            _preceptores.Add(new Preceptor(5, "Jorgelina", "Ramos", true));
            _preceptores.Add(new Preceptor(6, "Juan", "Gutierrez", false));

            _alumnos.Add(new AlumnoRegular(123, "Carlos", "Juárez", "cj@gmail.com"));
            _alumnos.Add(new AlumnoRegular(124, "Carla", "Jaime", "carla@gmail.com"));
            _alumnos.Add(new AlumnoOyente(320, "Ramona", "Vals"));
            _alumnos.Add(new AlumnoOyente(321, "Alejandro", "Medina"));
        }
        public bool AsistenciaRegistrada(string fecha)
        {
            return true;
        }
        public int GetCantidadAlumnosRegulares()
        {
            return _alumnos.Count(); //pendiente tomar solo los regulares
        }
        public Preceptor GetPreceptorActivo()
        {
            Preceptor aux = new Preceptor();
            aux = _preceptores.FirstOrDefault(o => o.Activo == true);
            return aux;
        } 
        public List<Alumno> GetListaAlumnos()
        {
            return _alumnos; //revisar
        }
        public void AgregarAsistencia(List<Asistencia> _asist)
        {

        }
        public List<Asistencia> GetAsistenciasPorFecha(string fecha)
        {
            return _asistencias; //revisar
        }

    }
}
