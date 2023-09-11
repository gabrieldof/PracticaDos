using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Ejercicio4
{
    internal class Ejercicio4 : IPractica2
    {
        public void Ejecutar()
        {

            List<Personaje> list = new List<Personaje>();
            list.Add(new PersonajeDeAgilidad("Spiderman", 6, 10, 2));
            list.Add(new PersonajeDeFuerza("Hulk", 10, 2));
            list.Add(new PersonajeDeMagia("Dr. Strange", 2, 10));
            list.Add(new PersonajeDeAgilidad("Black Panther", 8, 10, 2));
            list.Add(new PersonajeDeFuerza("Thor", 10, 8));
            list.Add(new PersonajeDeMagia("Scarlet Witch ", 2, 10, 100));


            Enemigo enemigo= new();
            
            Turno.Atacarse(list);
            Turno.MoverFichas(enemigo);
            Turno.MoverFichas(list[2]);
            Turno.MoverFichas(list[5]);


        }
    }
}
