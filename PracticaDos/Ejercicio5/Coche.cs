using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Ejercicio5
{
    
    public class Coche : IVehiculo
    {
        public int gasolina;
        public Coche(int gasolinaInicial)
        {
            gasolina = gasolinaInicial;
        }

        public bool CargarCombustible(int cantCombustible)
        {
            if (cantCombustible > 0)
            {
                gasolina = +cantCombustible;
                Console.WriteLine($"se cargo  {cantCombustible} de nafta. El tanque tiene {gasolina}");
                return true;
            }
            else
            {
                Console.WriteLine("no se cargo");
                return false;
            }
        }

        public void Conducir()
        {
            if (gasolina > 0)
            {
                Console.WriteLine("El Coche esta Conduciendo");
            }
            else
            {
                Console.WriteLine("No tiene Nafta");
            }

        }


    }
}
