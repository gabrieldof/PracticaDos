using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Ejercicio3
{
    internal class Persona
    {

        public int edad;

        public Persona() { }
        public void Saludar()
        {
            Console.WriteLine("Hola!");
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }


    }
}
