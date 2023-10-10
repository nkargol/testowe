using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    internal class Zadania2
    {
        static void Main(string[] args)
        {
            Zadanie1();
        }
        static void Zadanie1()
        {
            int suma = 0;
            int ocena;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Podaj ocenę: ");
                ocena = Convert.ToInt32(Console.ReadLine());
                if(ocena >= 3)
                {
                    suma += ocena;
                }
            }
            double srednia = suma / (double)5;
            Console.WriteLine("Śrenia z ocen wynosi: {0:N}", srednia);
        }
    }
}
