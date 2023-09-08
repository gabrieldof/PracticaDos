using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Ejercicio4
{
    public class Enemigo : IMoverse
    {
        public int Vida { get; set; }

        public int Nivel { get; set; }

        public void MoverseEjeX() {
            Console.WriteLine("Enemigo se movió en el eje X");
        }
        public void MoverseEjeY() {
            Console.WriteLine("Enemigo se movió en el eje Y");
        }

    }
}
