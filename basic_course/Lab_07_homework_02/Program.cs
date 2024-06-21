using System;

namespace Lab_07_homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManagement employeeManagement = new EmployeeManagement();

            Employee employee1 = new Employee("Krol", "Macius 1", 3);
            Employee employee2 = new Employee("Franek", "Dolas", 42);

            employeeManagement.AddEmployee(employee1);
            employeeManagement.AddEmployee(employee2);
        }
    }

    public class Employee
    {
        public string Firstname;
        public string Lastname;
        public int Age;

        public Employee(string firstname, string lastname, int age)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }
    }

    public class EmployeeManagement
    {
        public void AddEmployee(Employee employee)
        {
            try
            {
                if (employee.Age > 4)
                {
                    throw new UnacceptableException("Employee is to old for the sandbox!");
                }

                Console.WriteLine("Employee added.");
            }
            catch (UnacceptableException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    public class UnacceptableException : Exception
    {
        public UnacceptableException()
        {
        }

        public UnacceptableException(string? message) : base(message)
        {
        }

        public UnacceptableException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}