using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraLib
{
    public class ModelGry
    {
        private int wylosowana;                         /*int wylosowana: 72 zakresOd 0 do 100 historia gry -> czas, propozycja, odpowiedź komputera*/
        public int ZakresOd { get; private set; }
        public int ZakresDo { get; private set; }

        public ModelGry(int zakresOd, int zakresDo)
        {
            ZakresOd = zakresOd; //duże litery unikają funkcji this, funkcja będzie dla tych liczb publiczna
            ZakresDo = zakresDo;
            Random los = new Random();
            wylosowana = los.Next(ZakresOd, ZakresDo + 1);

        }
        
    }
}
