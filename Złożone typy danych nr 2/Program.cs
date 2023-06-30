using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Złożone_typy_danych_nr_2
{
    struct Student
{
    public string Imie;
    public string Nazwisko;
    public int NumerIndeksu;
    public string Kierunek;
}
struct Przedmiot
{
    public string Nazwa;
    public int NumerKatalogowy;
    public string Wykladowca;
    public int ECTS;
}
struct NauczycielAkademicki
{
    public string Imie;
    public string Nazwisko;
    public string TytulNaukowy;
    public string Katedra;
}


    internal class Program
    {
        static void Main(string[] args)
        { 
        }
    }
}
