using System;
using System.Collections.Generic;

namespace Lab_03_homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            var addResult = calculator.addNumbers(2, 5, 6, 8, 6);
            var subResult = calculator.subNumbers(58, 4, 65, 2);
            var multiResult = calculator.mutliNumbers(4, 2, 6, 7, 9);
            var divResult = calculator.divNumbers(120, 3, 8, 2);

            Console.WriteLine($"Addition result: {addResult}");
            Console.WriteLine($"Subtraction result: {subResult}");
            Console.WriteLine($"Multiplication result: {multiResult}");
            Console.WriteLine($"Division result: {divResult}");

            calculator.addNumbers(12, 15, 16, 18, 16);
            calculator.subNumbers(158, 14, 165, 12);
            calculator.mutliNumbers(14, 12, 16, 17, 19);
            calculator.divNumbers(18, 0);

            Console.WriteLine();
            calculator.displayOperationsHistory();
        }
    }

    public class Calculator
    {
        private List<string> operationHistory;

        public Calculator()
        {
            operationHistory = new List<string>();
        }

        public int addNumbers(params int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }

            writeToHistory("addition", result);
            return result;
        }

        public int subNumbers(params int[] numbers)
        {
            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }

            writeToHistory("subtraction", result);
            return result;
        }

        public int mutliNumbers(params int[] numbers)
        {
            int result = 1;
            foreach (int number in numbers)
            {
                result = result * number;
            }

            writeToHistory("multiplication", result);
            return result;
        }

        public double divNumbers(params int[] numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    result = result / numbers[i];
                }
                else
                {
                    Console.WriteLine("Division by 0! The last operation was not performed.");
                    return -1;
                }
            }

            writeToHistory("division", result);
            return result;
        }

        private void writeToHistory(string operation, double result)
        {
            operationHistory.Add($"{operation} - {result}");
        }

        public void displayOperationsHistory()
        {
            Console.WriteLine("Operations history");
            foreach (var element in operationHistory)
            {
                Console.WriteLine(element);
            }
        }
    }
}