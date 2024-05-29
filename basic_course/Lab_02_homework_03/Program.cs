using System;

namespace Lab_03_homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize;
            do
            {
                Console.WriteLine("what size should array be? (10 to 20)");
            } while (!int.TryParse(Console.ReadLine(), out arraySize) || arraySize < 10 || arraySize > 20);

            int[] array = new int[arraySize];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 21);
            }

            Console.WriteLine("array before sorting: ");
            Console.WriteLine(string.Join(", ", array));

            Array.Sort(array);

            Console.WriteLine("array after sorting: ");
            Console.WriteLine(string.Join(", ", array));
        }
    }
}