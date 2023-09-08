using PracticaDos.Ejercicio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Ejercicio3
{
    internal class Ejercicio3 :  IPractica2
    {
        public void Ejecutar()
        {
            Persona persona = new Persona();
            persona.Saludar();

            Estudiante estudiante = new Estudiante();
            estudiante.SetEdad(20);
            estudiante.Saludar();
            estudiante.MostrarEdad();
            estudiante.Estudiar();

            Profesor profesor = new Profesor();
            profesor.SetEdad(40);
            profesor.Saludar();
            profesor.Explicar();

            Console.ReadKey();

        }
    }
}
