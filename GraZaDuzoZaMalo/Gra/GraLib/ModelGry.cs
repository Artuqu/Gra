using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraLib
{
    public partial class ModelGry
    {
        readonly private int wylosowana;   //readonly oznacza, że nie można zmienić wartości poza konstruktorem    /*int wylosowana: 72 zakresOd 0 do 100 historia gry -> czas, propozycja, odpowiedź komputera*/
        public int ZakresOd { get; private set; }
        public int ZakresDo { get; private set; }
        public enum Stan { Trwa, Poddana, Odgadnieta }
        public Stan StanGry { get; private set; }

        public List<Ruch> Historia { get; private set; }


        //konstruktor
        public ModelGry(int zakresOd = 1, int zakresDo = 100)
        {
            ZakresOd = Math.Min( zakresOd, ZakresDo ); //duże litery unikają funkcji this, funkcja będzie dla tych liczb publiczna
            ZakresDo = Math.Max( zakresOd, ZakresDo );
            Random los = new Random();
            wylosowana = los.Next(ZakresOd, ZakresDo + 1);
            StanGry = Stan.Trwa;
            Historia = new List<Ruch>();

        }

        //Metody
        public enum Odp { ZaMalo = -1, Trafione = 0, ZaDuzo = 1 };

        public Odp Ocena(int propozycja)
        {
            if (propozycja < wylosowana)
            {
                //Ruch r = new Ruch(propozycja, Odp.ZaMalo);
                //Historia.Add(r);
                Historia.Add(new Ruch(propozycja, Odp.ZaMalo));
                return Odp.ZaMalo;
            }
            else if (propozycja > wylosowana)
            {
                Historia.Add(new Ruch(propozycja, Odp.ZaDuzo));
                return Odp.ZaDuzo;
            }
            else
            {
                Historia.Add(new Ruch(propozycja, Odp.Trafione));
                StanGry = Stan.Odgadnieta;
                return Odp.Trafione;
            }
        }

        public void Poddaj() // void procedura
        {
            StanGry = Stan.Poddana;
        }
        public int Wylosowana
        {
            get
            {
                if (StanGry == Stan.Poddana || StanGry == Stan.Odgadnieta)
                    return wylosowana;
                else
                    throw new NotSupportedException("Nie wolno teraz Ci tej wartości udostępnić");
            }
        }
    }
}
