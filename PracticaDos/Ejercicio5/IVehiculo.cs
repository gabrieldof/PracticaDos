using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Ejercicio5
{
    public interface IVehiculo
    {
        public void Conducir();

        public bool CargarCombustible(int cantCombustible);
    }
}
