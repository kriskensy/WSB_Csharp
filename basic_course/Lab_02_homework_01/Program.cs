using System;

namespace Lab_02_homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize;

            do
            {
                Console.WriteLine("what size should matrix be? (nxn)");
            } while (!int.TryParse(Console.ReadLine(), out matrixSize) || matrixSize < 1);


            int[,] matrixA = new int[matrixSize, matrixSize];
            int[,] matrixB = new int[matrixSize, matrixSize];
            int[,] matrixSumAB = new int[matrixSize, matrixSize];

            Console.WriteLine("give values for matrix A: ");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write($"element [{i},{j}]: ");
                    matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("give values for matrix B: ");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write($"element [{i},{j}]: ");
                    matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("matrix A+B sum: ");

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    matrixSumAB[i, j] = matrixA[i, j] + matrixB[i, j];
                    Console.Write(matrixSumAB[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}