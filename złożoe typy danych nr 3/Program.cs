using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace złożoe_typy_danych_nr_3
{
    enum KlasaRzadkosci
    {
        Powszechny,
        Rzadki,
        Unikalny,
        Epicki
    }

    enum TypPrzedmiotu
    {
        Bron,
        Zbroja,
        Amulet,
        Pierscien,
        Helm,
        Tarcza,
        Buty
    }

    struct Przedmiot
    {
        public float Waga;
        public int Wartosc;
        public KlasaRzadkosci Rzadkosc;
        public TypPrzedmiotu Typ;
        public string NazwaWlasna;

        public void WypelnijPrzedmiot(float waga, int wartosc, KlasaRzadkosci rzadkosc, TypPrzedmiotu typ, string nazwaWlasna)
        {
            Waga = waga;
            Wartosc = wartosc;
            Rzadkosc = rzadkosc;
            Typ = typ;
            NazwaWlasna = nazwaWlasna;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine("Przedmiot:");
            Console.WriteLine("Nazwa: " + NazwaWlasna);
            Console.WriteLine("Typ: " + Typ);
            Console.WriteLine("Rzadkosc: " + Rzadkosc);
            Console.WriteLine("Waga: " + Waga);
            Console.WriteLine("Wartosc: " + Wartosc);
            Console.WriteLine();
        }
    }

    class Program
    {
        static Random random = new Random();

        static Przedmiot LosujPrzedmiot(Przedmiot[] przedmioty)
        {
            int indeks = random.Next(przedmioty.Length);
            int rzadkosc = (int)przedmioty[indeks].Rzadkosc;

            int losowaLiczba = random.Next(1, 1 + 4 + 3 + 2);

            if (losowaLiczba <= 4)
                rzadkosc = (int)KlasaRzadkosci.Powszechny;
            else if (losowaLiczba <= 4 + 3)
                rzadkosc = (int)KlasaRzadkosci.Rzadki;
            else if (losowaLiczba <= 4 + 3 + 2) 
                rzadkosc = (int)KlasaRzadkosci.Unikalny;
            else 
                rzadkosc = (int)KlasaRzadkosci.Epicki;

           
            Przedmiot wylosowanyPrzedmiot;
            do
            {
                indeks = random.Next(przedmioty.Length);
                wylosowanyPrzedmiot = przedmioty[indeks];
            } while ((int)wylosowanyPrzedmiot.Rzadkosc != rzadkosc);

            return wylosowanyPrzedmiot;
        }

        static void Main(string[] args)
        {
          
            Przedmiot[] przedmioty = new Przedmiot[5];

            przedmioty[0].WypelnijPrzedmiot(2.5f, 10, KlasaRzadkosci.Powszechny, TypPrzedmiotu.Bron, "Miecz");
            przedmioty[1].WypelnijPrzedmiot(1.0f, 50, KlasaRzadkosci.Rzadki, TypPrzedmiotu.Zbroja, "Pancerz");
            przedmioty[2].WypelnijPrzedmiot(0.2f, 100, KlasaRzadkosci.Unikalny, TypPrzedmiotu.Amulet, "Amulet Mocy");
            przedmioty[3].WypelnijPrzedmiot(0.5f, 200, KlasaRzadkosci.Epicki, TypPrzedmiotu.Pierscien, "Pierscien Wladcy");
            przedmioty[4].WypelnijPrzedmiot(0.8f, 30, KlasaRzadkosci.Powszechny, TypPrzedmiotu.Helm, "Helm Rycerza");

            foreach (Przedmiot przedmiot in przedmioty)
            {
                przedmiot.WyswietlInformacje();
            }

           
            Przedmiot wylosowanyPrzedmiot = LosujPrzedmiot(przedmioty);

            Console.WriteLine("Wylosowany przedmiot:");
            wylosowanyPrzedmiot.WyswietlInformacje();

            Console.ReadKey();
        }
    }
}
