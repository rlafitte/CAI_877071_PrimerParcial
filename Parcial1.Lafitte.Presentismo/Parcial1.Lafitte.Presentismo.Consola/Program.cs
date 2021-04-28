using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1.Lafitte.Presentismo.Libreria.Entidades;

namespace Parcial1.Lafitte.Presentismo.Consola
{

        public class Program
        {
            private static Parcial1.Lafitte.Presentismo.Libreria.Entidades.Presentismo _presentismo;

            static Program()
            {
                _presentismo = new Parcial1.Lafitte.Presentismo.Libreria.Entidades.Presentismo();
            }
            // modificar lo que corresponda para que solo finalice el
            // programa si el usuario presiona X en el menú
            static void Main(string[] args)
            {
                Preceptor preceptorActivo = _presentismo.GetPreceptorActivo();
                Controlador C = new Controlador();

            while (_presentismo.Ejecuta)
            {

                DesplegarOpcionesMenu();
                string opcionMenu = ""; // pedir el valor
                try
                {
                    C.IngresoValido(Console.ReadLine(), out opcionMenu);
                }
                catch (OperacionInvalida op)
                {
                    Console.WriteLine(op.Message);

                }
                catch(ValorNoNumerico va)
                {
                    Console.WriteLine(va.Message);
                }
                
                switch (opcionMenu)
                {
                    case "1":
                        TomarAsistencia(preceptorActivo);
                        break;
                    case "2":
                        MostrarAsistencia();
                        break;
                    case "X":
                        Salir();
                        break;
                    default:
                        break;
                }
            }

            }
            static void DesplegarOpcionesMenu()
            {
                Console.WriteLine("1) Tomar Asistencia");
                Console.WriteLine("2) Mostrar Asistencia");
                Console.WriteLine("X: Terminar");
            }
            static void TomarAsistencia(Preceptor p)
            {

            Console.WriteLine("Ingrese fecha a chequear");
            //Ingreso fecha
            string s = Console.ReadLine();

            //Console.WriteLine(_presentismo.GetListaAlumnos());
            // Listar los alumnos
            foreach (Alumno a in _presentismo.GetListaAlumnos())
            {

                if (a is AlumnoRegular)
                {
                Console.WriteLine(a.Apellido + "está presente?");

                }

            }
            // para cada alumno solo preguntar si está presente
                // agrego la lista de asistencia
                // Error: mostrar el error y que luego muestre el menú nuevamente
            }
            static void MostrarAsistencia()
            {
            // ingreso fecha
            // muestro el toString de cada asistencia
            Console.WriteLine("Ingrese fecha a buscar");
            string s = Console.ReadLine();
            _presentismo.GetAsistenciasPorFecha(s);

            }
        static void Salir()
        {
            _presentismo.Ejecuta = false;
        }
        }
    
}
