using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zlozone_typy_danych_nr_4
{
    enum Plec
    {
        Mezczyzna,
        Kobieta
    }

    struct Student
    {
        public string Nazwisko;
        public int NrAlbumu;
        public double Ocena;
        public Plec Plec;

        public void WypelnijStudenta(string nazwisko, int nrAlbumu, double ocena, Plec plec)
        {
            Nazwisko = nazwisko;
            NrAlbumu = nrAlbumu;
            Ocena = Math.Max(2.0, Math.Min(5.0, ocena));
            Plec = plec;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Student: {Nazwisko}, Nr albumu: {NrAlbumu}, Ocena: {Ocena}, Płeć: {Plec}");
        }
    }

    class Program
    {
        static double ObliczSrednia(Student[] grupa)
        {
            double sumaOcen = 0;
            foreach (Student student in grupa)
            {
                sumaOcen += student.Ocena;
            }
            return sumaOcen / grupa.Length;
        }

        static void Main(string[] args)
        {
            Student[] grupa = new Student[5];

            grupa[0].WypelnijStudenta("Kowalski", 12345, 4.5, Plec.Mezczyzna);
            grupa[1].WypelnijStudenta("Nowak", 23456, 3.0, Plec.Kobieta);
            grupa[2].WypelnijStudenta("Wójcik", 34567, 4.8, Plec.Kobieta);
            grupa[3].WypelnijStudenta("Kaczmarek", 45678, 2.5, Plec.Mezczyzna);
            grupa[4].WypelnijStudenta("Lewandowski", 56789, 5.5, Plec.Mezczyzna);

            foreach (Student student in grupa)
            {
                student.WyswietlInformacje();
            }

            double srednia = ObliczSrednia(grupa);
            Console.WriteLine($"Średnia ocen w grupie: {srednia}");

            Console.ReadKey();
        }
    }
}
