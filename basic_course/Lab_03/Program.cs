using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

// namespace Lab_03
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // var osoba = new Osoba("Jan");
//             // //var osoba1 = new Osoba(); //nie dziala bo konstruktor bezparametrowy jest prywatny
//             // var osoba2 = Osoba.createOsoba(); //skorzystanie z metody statycznej implementyujacej konstruktor prywatny
//             //
//             // var pracownik = new PracownikB();
//             // pracownik.Wiek = -10;
//
//             var pracownikC = new PracownikC();
//             Console.WriteLine(pracownikC[2]);
//         }
//     }
//
//     public class Osoba //klasa
//     {
//         private Osoba() //konstruktor bezparametrowy
//         {
//         }
//
//         public Osoba(string imie) //konstruktor z parametrem
//         {
//         }
//
//         public static Osoba
//             createOsoba() //metoda statyczna zawierajaca konstruktor. Przydatne jesli chcemy aby normalny
//             //konstruktor mial dostep prywatny
//         {
//             return new Osoba();
//         }
//     }
//
//     public class Osoba1
//     {
//     }
//
//     public sealed class Osoba2 //klasa zapieczetowana
//     {
//     }
//
//     public interface Osoba3 //interfejs
//     {
//     }
//
//     internal class PracownikA : Osoba1, Osoba3 //dziedziczenie oraz implementacja interfejsu
//     {
//         public string imie;
//         public string nazwisko;
//     }
//
//     public class PracownikB
//     {
//         private string _imie;
//         private string _nazwisko;
//         private int _wiek;
//         public int Wiek2 { get; set; } //sama definicja wlasciwosci, bez implementacji logiki
//
//         public int Wiek
//         {
//             //wlasciwosci: zapis starszy
//             // get { return _wiek; }
//             // set
//             // {
//             //     if (value < 0)
//             //         throw new ArgumentException("wiek nie moze byc wartoscia ujemna");
//             //     _wiek = value;
//             // }
//
//             //wlasciwosci: zapis uproszczony
//             get => _wiek;
//             set => _wiek = value;
//         }
//     }
//
//     public class PracownikC
//     {
//         private int[] liczby = { 1, 2, 3, 4, 5 };
//
//         public int this[int element] //indeksator
//         {
//             get => liczby[element];
//             set => liczby[element] = value;
//         }
//     }
// }
//=======================================================

// namespace Lab_03 //zad1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var osoba = new Osoba("Zenek", "Martyniuk");
//             Console.WriteLine(osoba.pelnaNazwa);
//         }
//     }
//
//     public class Osoba
//     {
//         private string imie;
//         private string nazwisko;
//
//         public Osoba(string imie, string nazwisko)
//         {
//             this.imie = imie;
//             this.nazwisko = nazwisko;
//         }
//
//         public string pelnaNazwa => $"{imie} {nazwisko}";
//     }
// }
//================================================
// namespace Lab_03 //zad2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var osoba = new Osoba("Zenek", "Martyniuk", 66);
//             Console.WriteLine(osoba.pelnaNazwa + " " + osoba.MozeGlosowac);
//
//             var osoba2 = new Osoba("Stasiu", "Michalski", 14);
//             Console.WriteLine(osoba2.pelnaNazwa + " " + osoba2.MozeGlosowac);
//         }
//     }
//
//     public class Osoba
//     {
//         private string imie;
//         private string nazwisko;
//         private int wiek;
//
//         public Osoba(string imie, string nazwisko, int wiek)
//         {
//             this.imie = imie;
//             this.nazwisko = nazwisko;
//             this.wiek = wiek;
//         }
//
//         public string pelnaNazwa => $"{imie} {nazwisko}";
//         public bool MozeGlosowac => wiek >= 18;
//     }
// }

//=============================================================
// namespace Lab_03 //zad3
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("podaj dlugosc boku prostokata: ");
//             var dlugoscWczytana = int.TryParse(Console.ReadLine(), out int dlugosc);
//
//             if (!dlugoscWczytana)
//             {
//                 Console.WriteLine("niepoprawna dlugosc");
//             }
//
//             Console.WriteLine("podaj szerokosc boku prostokata: ");
//             var szerokoscWczytana = int.TryParse(Console.ReadLine(), out int szerokosc);
//
//             if (!szerokoscWczytana)
//             {
//                 Console.WriteLine("niepoprawna szerokosc");
//             }
//
//             Prostokat prostokat = new Prostokat(dlugosc, szerokosc);
//             Console.WriteLine($"Pole prostokata: {prostokat.ObliczonePole}");
//         }
//     }
//
//     public class Prostokat
//     {
//         private int dlugosc;
//         private int szerokosc;
//
//         public Prostokat(int dlugosc, int szerokosc)
//         {
//             this.dlugosc = dlugosc;
//             this.szerokosc = szerokosc;
//         }
//
//         private int ObliczPole(int dlugosc, int szerokosc)
//         {
//             return dlugosc * szerokosc;
//         }
//
//         public int ObliczonePole => ObliczPole(dlugosc, szerokosc);
//     }
// }

//===================================================================
namespace Lab_03 //zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank("Bank1", "Adres");
            var kontoBankowe = new KontoBankowe("12345", "Kowalski");
            var kontoBankowe1 = new KontoBankowe("12345", "Kowalski");
            var kontoBankowe2 = new KontoBankowe("67890", "Nowak");

            var wynik = bank.UtworzKonto(kontoBankowe);
            var wynik1 = bank.UtworzKonto(kontoBankowe1);
            var wynik2 = bank.UtworzKonto(kontoBankowe2);

            Console.WriteLine("Konta przed transakcjami");
            bank.WyswietlKonta();

            var wplataWynik = kontoBankowe.Wplata(100);
            var wyplataWynik1 = kontoBankowe.Wyplata(500);
            var wyplataWynik2 = kontoBankowe.Wyplata(50);
            var wyplataWynik3 = kontoBankowe2.Wplata(999);

            Console.WriteLine();
            Console.WriteLine("Konta po transakcjach");
            bank.WyswietlKonta();
        }
    }

    public class Bank
    {
        private KontoBankowe[] _konta;
        private string _nazwa;
        private string _adres;

        public Bank(string nazwa, string adres)
        {
            this._nazwa = nazwa;
            this._adres = adres;

            _konta = new List<KontoBankowe>().ToArray();
        }

        public bool UtworzKonto(KontoBankowe konto)
        {
            if (_konta?.Any(x => x.Numer == konto.Numer) is true)
                return false;
        
            var konta = new KontoBankowe[_konta.Length + 1];
            konta[konta.Length - 1] = konto;
            Array.Copy(_konta, konta, _konta.Length);
            _konta = konta;
            return true;
        }

        public void WyswietlKonta()
        {
            Console.WriteLine("Konta bankowe: ");
            foreach (var konto in _konta)
            {
                Console.WriteLine($"Numer: {konto.Numer}, Nazwisko: {konto.Nazwisko}, saldo: {konto.Saldo}");
            }
        }
    }

    public class KontoBankowe
    {
        public string Numer { get; private set; }
        public string Nazwisko { get; private set; }
        public decimal Saldo { get; private set; }

        public KontoBankowe(string numer, string nazwisko, decimal saldo = 0)
        {
            this.Numer = numer;
            this.Nazwisko = nazwisko;
            this.Saldo = saldo;
        }

        public bool Wplata(decimal kwota)
        {
            if (kwota < 0)
                return false;

            Saldo += kwota;
            return true;
        }

        public bool Wyplata(decimal kwota)
        {
            if (kwota < 0)
                return false;

            if (Saldo < kwota)
                return false;

            Saldo -= kwota;
            return true;
        }
    }
}

// namespace Lab_03 //zad5
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//         }
//     }
// }