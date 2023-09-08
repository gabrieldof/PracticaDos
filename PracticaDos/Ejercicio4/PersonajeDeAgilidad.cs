using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Ejercicio4
{
    internal class PersonajeDeAgilidad : Personaje
    {
        public PersonajeDeAgilidad(string nombre, int fuerza, int agilidad, int magia)
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Agilidad = agilidad;
            Magia = magia;

        }

        public override double CalcularDanio()
        {
            double danio = 0;
            danio = (Fuerza/2) * Agilidad * (Magia / 2);
            return danio;

        }

    }
}
