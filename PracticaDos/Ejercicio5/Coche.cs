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
            return true;
        }

        public void Conducir()
        { }


    }
}
