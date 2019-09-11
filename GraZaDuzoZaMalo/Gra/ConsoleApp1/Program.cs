using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Komputer losuje liczbę z podanego zakresu
            Random los = new Random();
            int wylosowana = los.Next(1,101);
#if DEBUG
            Console.WriteLine(wylosowana);   // do usnięcia w Release
#endif
            //powtarzaj wielokrotnie, aż odgadnie
            //2. Człowiek proponuje (odgaduje)

            //3. Komputer ocenia propzycję
            // koniec powtarzaj

            //4. Wypisz statystyki gry

        }
    }
}
