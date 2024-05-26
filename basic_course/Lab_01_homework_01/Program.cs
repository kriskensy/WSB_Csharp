using System;

namespace Lab_01_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how much money do you need? 10.000 - 100.000");
            var succeededLoan = (double.TryParse(Console.ReadLine(), out double loanAmount) && loanAmount >= 10000 &&
                                 loanAmount <= 100000);

            Console.WriteLine("in how many installments would you like to repay the loan? 6-96");
            var succceededInstallments = (int.TryParse(Console.ReadLine(), out int numberOfInstallments) &&
                                          numberOfInstallments >= 6 && numberOfInstallments <= 96);

            if (succeededLoan && succceededInstallments) //obliczenia wyrzucone do oddzielnej metody, zeby lepiej podzielic kod
            {
                Console.WriteLine(loanInstallmentAmount(loanAmount, numberOfInstallments) + " PLN.");
            }
            else
            {
                Console.WriteLine("the data you provided is incorrect");
            }
        }

        public static double loanInstallmentAmount(double loanAmount, double numberOfInstallments)
        {
            Console.WriteLine(
                $"the monthly installment for a {loanAmount} PLN loan with {numberOfInstallments} installments is: ");
            return ((loanAmount * 0.05 + loanAmount) / numberOfInstallments);
        }
    }
}