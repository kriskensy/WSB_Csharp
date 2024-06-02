using System;
using System.Collections.Generic;

// //======================zad 1
// namespace Lab_04
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Student student = new Student("Nowak", 23, 5468);
//             student.displayData();
//         }
//     }
//
//     public abstract class Person
//     {
//         public string name { get; set; }
//         public int age { get; set; }
//
//         protected Person(string name, int age)
//         {
//             this.name = name;
//             this.age = age;
//         }
//     }
//
//     public class Student : Person
//     {
//         public int StudentID { get; set; }
//
//         public void displayData() => Console.WriteLine($"Student: {name}, age: {age}, ID: {StudentID}");
//
//         public Student(string name, int age, int studentId) : base(name, age)
//         {
//             StudentID = studentId;
//         }
//     }
// }

// //======================zad 2
// namespace Lab_04
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Rectangle rectangle = new Rectangle(4, 5);
//             rectangle.CalculateArea();
//             Console.WriteLine($"Rectangle area: {rectangle.Area}");
//
//             Circle circle = new Circle(5);
//             circle.CalculateArea();
//             Console.WriteLine($"Circle area: {circle.Area}");
//         }
//     }
//
//     public abstract class Shape
//     {
//         public double Area { get; set; }
//
//         public abstract void CalculateArea();
//     }
//
//     public class Rectangle : Shape
//     {
//         private int lenght;
//         private int width;
//
//         public Rectangle(int lenght, int width)
//         {
//             this.lenght = lenght;
//             this.width = width;
//         }
//
//         public override void CalculateArea()
//         {
//             Area = width * lenght;
//         }
//     }
//
//     public class Circle : Shape
//     {
//         private int radius;
//
//         public Circle(int radius)
//         {
//             this.radius = radius;
//         }
//
//         public override void CalculateArea()
//         {
//             Area = Math.PI * radius * radius;
//         }
//     }
// }

//====================zad 7
namespace Lab_05
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface IBook
    {
        string Title { get; }
        string Author { get; }
        public DateTime PublicationDate { get; }
        public decimal Price { get; }
        public string Description { get; set; }
        public string ToString();
    }

    public class Book : IBook
    {
        public string Title { get; }
        public string Author { get; }
        public DateTime PublicationDate { get; }
        public decimal Price { get; }
        public string Description { get; set; }

        public Book(string title, string author, DateTime publicationDate, decimal price, string description)
        {
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
            Price = price;
            Description = description;
        }
    }

    public class OtherBook : IBook
    {
        public int NumberOfPages { get; }
        public string Title { get; }
        public string Author { get; }
        public DateTime PublicationDate { get; }
        public decimal Price { get; }
        public string Description { get; set; }

        public OtherBook(int numberOfPages, string title, string author, DateTime publicationDate, decimal price,
            string description)
        {
            NumberOfPages = numberOfPages;
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
            Price = price;
            Description = description;
        }
    }

    public class Library : ILibrary
    {
        public List<IBook> Books { get; }

        public Library()
        {
            Books = new List<IBook>();
        }

        public void AddBook(IBook book)
            => Books.Add(book);

        public void RemoveBook(IBook book)
            => Books.Remove(book);

        public void UpdateBook(IBook oldBook, IBook newBook)
        {
            var index = Books.IndexOf(oldBook);
            if (index >= 0)
                Books[index] = newBook;
        }
    }

    public interface ILibrary
    {
        List<IBook> Books { get; }
        void AddBook(IBook book);
        void RemoveBook(IBook book);
        void UpdateBook(IBook oldBook, IBook newBook);
        public string ToString();
    }
}