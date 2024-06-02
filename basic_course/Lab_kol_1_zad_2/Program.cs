using System;

namespace Lab_kol_1_zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new Employee("Bob", "Budowniczy", 1900),
                new Employee("Zenek", "Bebenek", 1300),
                new Employee("Kazia", "Szczuka", 900),
                new Employee("Franek", "Dolas", 6000)
            };

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Employee: {employees[i].Name} {employees[i].Surname} {employees[i].Salary} PLN");
            }

            decimal averageSalary = Program.AverageSalary(employees);
            Console.WriteLine($"Average salary is: {averageSalary} PLN");
        }

        private static decimal AverageSalary(Employee[] employees)
        {
            decimal result = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                result += employees[i].Salary;
            }

            return result;
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string surname, decimal salary)
        {
            this.Name = name;
            this.Surname = surname;
            this.Salary = salary;
        }
    }
}

/*Napisz program w C#, który tworzy klasę Pracownik z polami imię, nazwisko i wynagrodzenie. Następnie program powinien
 utworzyć tablicę obiektów typu Pracownik i przypisać do niej kilka instancji klasy. Program powinien wykorzystać
 pętlę for do wyświetlenia informacji o każdym pracowniku (imię, nazwisko i wynagrodzenie), a także obliczyć średnie
 wynagrodzenie wszystkich pracowników.*/