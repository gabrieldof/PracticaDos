using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Ejercicio4
{
    public class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza(string nombre, int agilidad, int magia)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = magia;
            Fuerza = 100;
        }

        public override double CalcularDanio()
        {
            return Agilidad + (Fuerza*2) + Magia;
       
        }
    }
}
