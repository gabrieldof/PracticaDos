using PracticaDos.Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Ejercicio2
{
    internal class Ejercicio2: IPractica2
    {
        public void Ejecutar()
        {
            PhotoBook book1 = new PhotoBook();
            Console.WriteLine($"Número de páginas del álbum 1: {book1.GetNumberPages()}");

            PhotoBook book2 = new PhotoBook(24);
            Console.WriteLine($"Número de páginas del álbum 2: {book2.GetNumberPages()}");

            BigPhotoBook bigBook = new BigPhotoBook();
            Console.WriteLine($"Número de páginas del álbum grande: {bigBook.GetNumberPages()}");

            Console.ReadKey();

        }

    }
}
