using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Ejercicio4
{
    internal class PersonajeDeMagia : Personaje
    {

        public PersonajeDeMagia(string nombre, int fuerza, int agilidad, int magia) 
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Agilidad = agilidad;
            Magia = magia;

        }

        public PersonajeDeMagia(string nombre, int fuerza, int agilidad)
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Agilidad = agilidad;
            Magia = 60;

        }



        public override double CalcularDanio()
        {
            //double danio = 0;
            return  Fuerza + Agilidad + Magia * 4;
            // danio;

        }
        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} hizo {CalcularDanio()} de daño gracias a su magia");
        }

    }
}
