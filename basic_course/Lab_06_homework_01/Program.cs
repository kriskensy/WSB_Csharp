using System;
using System.Collections.Generic;

namespace Lab_06_homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDatabase employeeDatabase = new EmployeeDatabase();

            employeeDatabase.AddEmployee(1, "Franek", "Dolas", "Szeregowy");
            employeeDatabase.AddEmployee(2, "John", "Doe", "Developer");
            employeeDatabase.AddEmployee(3, "Jane", "Smith", "Designer");
            employeeDatabase.AddEmployee(4, "Anna", "Nowak", "Accountant");
            employeeDatabase.AddEmployee(5, "Marek", "Kowalski", "HR Specialist");
            employeeDatabase.AddEmployee(6, "Zofia", "Wiśniewska", "Project Manager");
            employeeDatabase.AddEmployee(7, "Piotr", "Wójcik", "Sales Representative");
            employeeDatabase.AddEmployee(8, "Katarzyna", "Kowalczyk", "Marketing Manager");
            employeeDatabase.AddEmployee(9, "Paweł", "Kamiński", "Customer Support");
            employeeDatabase.AddEmployee(10, "Agnieszka", "Lewandowska", "Data Analyst");

            employeeDatabase.DisplayEmployees();

            employeeDatabase.RemoveEmployee(10);
            employeeDatabase.RemoveEmployee(9);
            employeeDatabase.RemoveEmployee(8);
            employeeDatabase.RemoveEmployee(7);

            Console.WriteLine();
            employeeDatabase.DisplayEmployees();

            employeeDatabase.AddEmployee(7, "Agnieszka", "Lewandowska", "Data Analyst");

            Console.WriteLine();
            Employee employee = employeeDatabase.GetEmployee(7);

            if (employee != null)
            {
                Console.WriteLine(employee);
            }
        }
    }

    public class Employee
    {
        private int ID { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Position { get; set; }

        public Employee(int id, string firstName, string lastName, string position)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }

        public override string ToString()
        {
            return $"ID: {ID}, {FirstName} {LastName}, {Position}";
        }
    }

    public class EmployeeDatabase
    {
        private Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

        public void AddEmployee(int id, string firstName, string lastName, string position)
        {
            if (!employees.ContainsKey(id))
            {
                Employee employee = new Employee(id, firstName, lastName, position);
                employees.Add(id, employee);
            }
            else
            {
                Console.WriteLine("ID exists in Database");
            }
        }

        public void RemoveEmployee(int id)
        {
            if (employees.ContainsKey(id))
            {
                employees.Remove(id);
            }
            else
            {
                Console.WriteLine("ID doesn't exist ind database");
            }
        }

        public Employee GetEmployee(int id)
        {
            if (employees.ContainsKey(id))
            {
                return employees[id];
            }
            else
            {
                Console.WriteLine("Employee doesn't exists");
                return null;
            }
        }

        public void DisplayEmployees()
        {
            foreach (var employee in employees.Values)
            {
                Console.WriteLine(employee);
            }
        }
    }
}