using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Ejercicio1
{
    internal class Ejercicio1 : IPractica2
    {
        public void Ejecutar()
        {
            List<Persona> personas = new List<Persona>();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Ingrese el nombre de la persona {i}:");
                string nombre = Console.ReadLine();
                personas.Add(new Persona { Nombre = nombre });
            }

            Console.WriteLine("\nSaludos:");
            foreach (Persona persona in personas)
            {
                Console.WriteLine(persona.Saludar());
            }

            Console.ReadKey();
        }
    }


}

