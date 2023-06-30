using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Złożone_typy_danych_nr_1
{
    internal class Program
    {
        enum DniTygodnia
        {
            Poniedzialek,
            Wtorek,
            Sroda,
            Czwartek,
            Piatek,
            Sobota,
            Niedziela
        }

        enum EtapyPrania
        {
            Namaczanie,
            Pranie,
            Płukanie,
            Wirowanie,
            Suszenie
        }

        enum Posilki
        {
            Sniadanie,
            DrugieSniadanie,
            Obiad,
            Podwieczorek,
            Kolacja
        }

        enum BiereczkiSzachowe
        {
            Wieza,
            Skoczek,
            Goniec,
            Hetman,
            Krol,
            Pionek
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dni tygodnia:");
            foreach (DniTygodnia dzien in Enum.GetValues(typeof(DniTygodnia)))
            {
                Console.WriteLine(dzien);
            }

            Console.WriteLine("\nEtapu prania:");
            foreach (EtapyPrania etap in Enum.GetValues(typeof(EtapyPrania)))
            {
                Console.WriteLine(etap);
            }

            Console.WriteLine("\nPosiłki:");
            foreach (Posilki posilek in Enum.GetValues(typeof(Posilki)))
            {
                Console.WriteLine(posilek);
            }

            Console.WriteLine("\nBiereczki szachowe:");
            foreach (BiereczkiSzachowe biereczka in Enum.GetValues(typeof(BiereczkiSzachowe)))
            {
                Console.WriteLine(biereczka);
            }
        }
    }
}
