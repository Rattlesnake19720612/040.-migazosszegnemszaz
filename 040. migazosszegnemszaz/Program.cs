using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040.migazosszegnemszaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot!");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek még egy számot!");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            int i = szam1 + szam2;

            while (i < 101)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadKey();
        }
    }
}
