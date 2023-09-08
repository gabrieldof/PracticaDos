using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Ejercicio3
{
    internal class Estudiante : Persona
    {
        public void Estudiar()
        {
            Console.WriteLine("Estoy estudiando.");
        }

        public void MostrarEdad()
        {
            Console.WriteLine($"Mi edad es: {edad} años.");
        }


    }
}
