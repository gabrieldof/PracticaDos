using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Ejercicio1
{
    internal class Persona
    {
        public string Nombre { get; set; }

        public string Saludar()
        {
            return $"Hola! mi nombre es {Nombre}.";
        }


    }
}
