using System;
using System.Linq;

namespace Lab_02_homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[11];
            int[] array2 = new int[10];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i + 10;
            }

            Random random = new Random();
            var randomElement = random.Next(10, 21);

            int j = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != randomElement)
                {
                    array2[j] = array1[i];
                    j++;
                }
            }

            int missingElement = array1.Sum() - array2.Sum();

            Console.WriteLine("array 1: " + string.Join(", ", array1));
            Console.WriteLine("array 2: " + string.Join(", ", array2));
            Console.WriteLine("missing element: " + missingElement);
        }
    }
}