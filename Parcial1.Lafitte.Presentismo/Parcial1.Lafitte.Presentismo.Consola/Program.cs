﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1.Lafitte.Presentismo.Libreria.Entidades;

namespace Parcial1.Lafitte.Presentismo.Consola
{

        public class Program
        {
            private static Presentismo _presentismo;

            static Program()
            {
                _presentismo = new Presentismo();
            }
            // modificar lo que corresponda para que solo finalice el
            // programa si el usuario presiona X en el menú
            static void Main(string[] args)
            {
                Preceptor preceptorActivo = _presentismo.GetPreceptorActivo();

                DesplegarOpcionesMenu();
                string opcionMenu = ""; // pedir el valor
                switch (opcionMenu)
                {
                    case "1":
                        TomarAsistencia(preceptorActivo);
                        break;
                    case "2":
                        MostrarAsistencia();
                        break;
                    case "X":
                        // SALIR
                        break;
                    default:
                        break;
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
                // Ingreso fecha
                // Listar los alumnos
                // para cada alumno solo preguntar si está presente
                // agrego la lista de asistencia
                // Error: mostrar el error y que luego muestre el menú nuevamente
            }
            static void MostrarAsistencia()
            {
                // ingreso fecha
                // muestro el toString de cada asistencia
            }
        }

        static void Main(string[] args)
        {
        }
    
}
