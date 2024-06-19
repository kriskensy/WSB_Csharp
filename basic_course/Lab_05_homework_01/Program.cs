using System;
using System.Drawing;

namespace Lab_05_homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(3);
            matrix1[0, 0] = 4;
            matrix1[0, 1] = 5;
            matrix1[0, 2] = 6;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 7;
            matrix1[1, 2] = 8;
            matrix1[2, 0] = 2;
            matrix1[2, 1] = 1;
            matrix1[2, 2] = 9;

            Matrix matrix2 = new Matrix(3);
            matrix2[0, 0] = 1;
            matrix2[0, 1] = 3;
            matrix2[0, 2] = 4;
            matrix2[1, 0] = 6;
            matrix2[1, 1] = 2;
            matrix2[1, 2] = 8;
            matrix2[2, 0] = 7;
            matrix2[2, 1] = 7;
            matrix2[2, 2] = 8;

            Matrix resultMatrix = matrix1 + matrix2;

            Console.WriteLine(matrix1);
            Console.WriteLine(matrix2);
            Console.WriteLine(resultMatrix);
        }
    }

    public class Matrix
    {
        private int[,] matrix;

        public int Size { get; }

        public Matrix(int size)
        {
            Size = size;
            matrix = new int[size, size];
        }

        public int this[int row, int col]
        {
            get { return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.Size != b.Size)
            {
                throw new ArgumentException("Size must be the same.");
            }

            Matrix result = new Matrix(a.Size);

            for (int i = 0; i < a.Size; i++)
            {
                for (int j = 0; j < a.Size; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }

            return result;
        }

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    result += matrix[i, j] + " ";
                }

                result += "\n";
            }

            return result;
        }
    }
}