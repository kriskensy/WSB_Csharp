using System;

namespace Lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // //exer 1
            // const double PI = Double.Pi;
            // //Console.WriteLine("{0:#.#####}", PI);
            // Console.WriteLine("{0:F5}", PI);

            // //exer 2
            // double radius;
            //
            // Console.WriteLine("what is sphere radius?");
            //
            // var succeeded = double.TryParse(Console.ReadLine(), out radius );
            // if (succeeded)
            // {
            //     double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            //     Console.WriteLine("Volume: {0:F2}", volume);
            // }
            // else
            // {
            //     Console.WriteLine("Radius must be a number!");
            // }

            // //exer 3
            // decimal number1 = 13;
            // decimal number2 = 4;
            //
            // decimal result = number1 / number2;
            //
            // //Console.WriteLine("Result: " + result);
            // Console.WriteLine("Result: " + Math.Round(result, 0, MidpointRounding.ToZero));

            // //exer 4
            // int number1 = 11;
            // int number2 = 4;
            //
            // int result = number1 % number2;
            //
            // Console.WriteLine("Result, modulo: " + result);

            // //exer 5
            // string word, sentence;
            // Console.Write("give a word: ");
            // word = Console.ReadLine();
            //
            // Console.Write("\n give a sentence: ");
            // sentence = Console.ReadLine();
            //
            // bool dasItContains = sentence.Contains(word, StringComparison.OrdinalIgnoreCase);
            //
            // Console.WriteLine(dasItContains);

            // //exer 6
            // int number1, number2;
            // Console.Write("give 1. number: ");
            // var succeeded1 = int.TryParse(Console.ReadLine(), out number1);
            //
            // Console.Write("give 2. number: ");
            // var succeeded2 = int.TryParse(Console.ReadLine(), out number2);
            //
            // bool isBetween = (number1 >= -20 && number1 <= 10) || (number2 >= -20 && number2 <= 10);
            //
            // if (succeeded1 && succeeded2 && isBetween)
            // {
            //     Console.Write("At least one number is between -20 and 10.");
            // }
            // else if (succeeded1 && succeeded2 && !isBetween)
            // {
            //     Console.Write("there isn't any number between -20 and 10.");
            // }
            // else
            // {
            //     Console.Write("Number 1 and number 2 should be numbers!");
            // }

            //exer 7
            const double milesToKilometers = 1.609344;
            const double kilometersToMiles = 0.621371192;

            Console.Write("give a km number: ");
            if (double.TryParse(Console.ReadLine(), out var km))
            {
                var miles = km * milesToKilometers;
                Console.WriteLine($"{miles:F2}");
            }
            else
            {
                Console.Write("it isn't a number!");
            }

            Console.Write("give a miles number: ");
            if (double.TryParse(Console.ReadLine(), out var mi))
            {
                var kilometers = mi * kilometersToMiles;
                Console.WriteLine($"{kilometers:F2}");
            }
            else
            {
                Console.Write("it isn't a number");
            }
            
            //exer 8
        }
    }
}