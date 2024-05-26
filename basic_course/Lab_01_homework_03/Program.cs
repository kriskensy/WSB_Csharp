using System;
using System.Linq;

namespace Lab_01_homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Console.Write("give 5 numbers: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                var succeeded = int.TryParse(Console.ReadLine(), out int number); //flaga na dodanie liczby do tablicy jesli to faktycznie jest liczba
                if (succeeded)
                {
                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine("it is not a number! do it once again");
                    i--; //jesli zostala podana NIE-liczba to iteracja zostaje powtorzona
                }
            }

            foreach (int element in numbers) //wyswietlenie na sprawdzenie tylko
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
            Console.WriteLine("max number is: " + numbers.Max());
            Console.WriteLine("min number is: " + numbers.Min());
        }
    }
}