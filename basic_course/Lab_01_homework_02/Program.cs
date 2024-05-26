using System;

namespace Lab_01_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your weight (in kg)?");
            var succeededWeight = double.TryParse(Console.ReadLine(), out double weight); //flaga na sprawdzenie wprowadzanej wagi

            Console.WriteLine("what is your height (in m)?");
            var succeedeedHeight = double.TryParse(Console.ReadLine(), out double height); //flaga na sprawdzenie wprowadzanego wzrostu

            if (succeededWeight && succeedeedHeight)
            {
                commentsBMI(resultBMI(height, weight)); //wywolanie metod statycznych na podanych argumentach
            }
            else
            {
                Console.WriteLine("give correct weight and height values!");
            }
        }

        public static double resultBMI(double height, double weight)
        {
            double bmi = weight / (height * height);
            return Math.Round(bmi * 100) / 100.0;
        }

        public static void commentsBMI(double bmi)
        {
            Console.WriteLine("your bmi is: " + bmi);
            if (bmi < 16)
            {
                Console.WriteLine("starvation");
            }
            else if (bmi >= 16 && bmi <= 16.99)
            {
                Console.WriteLine("emaciation");
            }
            else if (bmi >= 17 && bmi <= 18.49)
            {
                Console.WriteLine("underweight");
            }
            else if (bmi >= 18.5 && bmi <= 24.99)
            {
                Console.WriteLine("correct value");
            }
            else if (bmi >= 25 && bmi <= 29.99)
            {
                Console.WriteLine("overweight");
            }
            else if (bmi >= 30 && bmi <= 34.99)
            {
                Console.WriteLine("1. degree of obesity");
            }
            else if (bmi >= 35 && bmi <= 39.99)
            {
                Console.WriteLine("2. degree of obesity");
            }
            else if (bmi >= 40)
            {
                Console.WriteLine("extreme obesity");
            }
        }
    }
}