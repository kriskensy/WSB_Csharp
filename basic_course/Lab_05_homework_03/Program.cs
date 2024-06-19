using System;

namespace Lab_05_homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Franek", "Dolas", 29);
            Person person2 = new Person("Franek", "Dolas", 29);
            Person person3 = new Person("Franek", "Dolas", 44);

            Console.WriteLine("Person 1: " + person1);
            Console.WriteLine("Person 2: " + person2);
            Console.WriteLine("Person 3: " + person3);

            Console.WriteLine("P1==P2: " + (person1 == person2));
            Console.WriteLine("P1==P3: " + (person1 == person3));
            Console.WriteLine("P1 equals P2: " + person1.Equals(person2));
            Console.WriteLine("P1 equals P3: " + person1.Equals(person3));
        }
    }

    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Person personToCompare = (Person)obj;
            return FirstName == personToCompare.FirstName &&
                   LastName == personToCompare.LastName &&
                   Age == personToCompare.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName, Age);
        }

        public static bool operator ==(Person personA, Person personB)
        {
            if (ReferenceEquals(personA, personB))
                return true;

            if (personA is null || personB is null)
                return false;

            return personA.Equals(personB);
        }

        public static bool operator !=(Person personA, Person personB)
        {
            return !(personA == personB);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age}";
        }
    }
}