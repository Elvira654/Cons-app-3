using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*n predavača u centru za talente drži predavanja po cijeni časa c. Napisati program kojim se
za svakog predavača učitava koliko je održao časova u toku mjeseca i ispisuje njegova
zarada. Takođe, odrediti i ukupan iznos za isplatu za sve predavače.*/
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c, x = 0;
            Console.WriteLine("Broj predavaca: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cijena casa: ");
            c = int.Parse(Console.ReadLine());
            int[] pred = new int[n];
            for (int i = 0; i < n; i++)
            {
               Console.WriteLine("Kolicina casova predavaca broj " + (i + 1) + ": ");
               pred[i] = int.Parse(Console.ReadLine());
               Console.WriteLine("Predavac broj " + (i + 1) + " je zaradio " + (pred[i] * c));
               x += pred[i] * c;
            }

            Console.WriteLine("Ukupna isplata: " + x);
            Console.ReadKey();
        }
    }
}
