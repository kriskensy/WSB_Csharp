using System;

namespace Lab_kol_1_zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.AddNumbers(5, 6);
            Calculator.AddNumbers(324, 678);
            Calculator.AddNumbers(8, -235);

            Console.WriteLine($"Number of calls for addition: {Calculator.NumberOfCallsAdd}");
            
            Calculator.SubNumbers(5, 5678);
            Calculator.SubNumbers(3456, 13);
            Calculator.SubNumbers(66, 66);
            Calculator.SubNumbers(34, 27);
            
            Console.WriteLine($"Number of calls for subtraction: {Calculator.NumberOfCallsSub}");
        }
    }

    public class Calculator
    {
        public static int NumberOfCallsAdd { get; private set; }
        public static int NumberOfCallsSub { get; private set; }

        public static int AddNumbers(int number1, int number2)
        {
            NumberOfCallsAdd++;
            return number1 + number2;
        }

        public static int SubNumbers(int number1, int number2)
        {
            NumberOfCallsSub++;
            return number1 - number2;
        }
    }
}

/*Utwórz klasę statyczną o nazwie "Kalkulator", która będzie zawierać dwie metody statyczne: "Dodaj" i "Odejmij".
 Metoda "Dodaj" powinna przyjmować dwie liczby jako argumenty i zwracać ich sumę. Metoda "Odejmij" powinna również 
 przyjmować dwie liczby jako argumenty i zwracać różnicę między nimi. Klasa powinna również zawierać dwie właściwości 
 statyczne: "LiczbaWywolanDodaj" i "LiczbaWywolanOdejmij", które będą przechowywać liczbę wywołań metod "Dodaj" i "Odejmij".*/