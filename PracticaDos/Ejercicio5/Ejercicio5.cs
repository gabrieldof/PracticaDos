using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Ejercicio5
{
    internal class Ejercicio5 : IPractica2
    {
        public void Ejecutar()
        {
            Coche auto = new Coche(0);
            auto.Conducir();

            Console.WriteLine("Ingrese la cantidad de combustible que desea cargar: ");
            int carga = int.Parse(Console.ReadLine());

            auto.CargarCombustible(carga);
            auto.Conducir();
        }
    }
}
