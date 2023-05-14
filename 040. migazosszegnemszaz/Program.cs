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

/*Ez a kód egy egyszerű C# programot tartalmaz, amely két számot kér be a felhasználótól, majd ezeket összeadja. Ezután a program egy ciklusban kiírja az összeadás eredményét egészen addig, amíg az eredmény el nem éri vagy meghaladja a 101-et.

A program futását a Main függvény vezérli, amely a program belépési pontja. Először a program kiírja a konzolra a "Kérek egy számot!" szöveget, majd beolvassa a felhasználó által megadott számot (szam1). Ezután ugyanezt teszi a "Kérek még egy számot!" szöveggel és a második számmal (szam2).

Ezután az i változóba beállítjuk szam1 és szam2 összegét. Majd egy while ciklusban addig írjuk ki az i értékét a konzolra, amíg az kisebb, mint 101. Aztán minden iterációban növeljük az i értékét eggyel.

Végül a Console.ReadKey() függvény segítségével várunk egy billentyűlenyomást, mielőtt a program véget érne és kilépne.

Ez a program tehát két számot kér be, összeadja őket, majd kiírja az eredményt, majd folyamatosan kiírja az összeget egészen addig, amíg az el nem éri vagy meghaladja a 101-et.*/
