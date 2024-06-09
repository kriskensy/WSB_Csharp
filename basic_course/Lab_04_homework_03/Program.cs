using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_04_homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            ILibrary library = new Library();

            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", new DateTime(1960, 7, 11), 14.99m,
                "A Pulitzer Prize-winning novel."));
            library.AddBook(new Book("1984", "George Orwell", new DateTime(1949, 6, 8), 12.50m, "A dystopian novel."));
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", new DateTime(1925, 4, 10), 11.99m,
                "A novel set in the Jazz Age."));
            library.AddBook(new Book("Pride and Prejudice", "Jane Austen", new DateTime(1813, 1, 28), 10.99m,
                "A romantic novel."));
            library.AddBook(new Book("To the Lighthouse", "Virginia Woolf", new DateTime(1927, 5, 5), 13.75m,
                "A stream-of-consciousness novel."));
            library.AddBook(new Book("Brave New World", "Aldous Huxley", new DateTime(1932, 6, 14), 9.25m,
                "A dystopian novel."));
            library.AddBook(new Book("The Lord of the Rings", "J.R.R. Tolkien", new DateTime(1954, 7, 29), 20.50m,
                "A high-fantasy novel."));
            library.AddBook(new Book("The Hobbit", "J.R.R. Tolkien", new DateTime(1937, 9, 21), 18.99m,
                "A fantasy novel for children."));
            library.AddBook(new Book("The Chronicles of Narnia", "C.S. Lewis", new DateTime(1950, 10, 16), 16.50m,
                "A series of high-fantasy novels."));
            library.AddBook(new Book("Moby-Dick", "Herman Melville", new DateTime(1851, 10, 18), 22.75m,
                "A novel about a man's obsessive quest for revenge against a white whale."));
            library.AddBook(new Book("War and Peace", "Leo Tolstoy", new DateTime(1869, 1, 1), 25.99m,
                "An epic novel set during the Napoleonic Wars."));
            library.AddBook(new Book("Crime and Punishment", "Fyodor Dostoevsky", new DateTime(1866, 11, 14), 21.25m,
                "A psychological thriller exploring morality and redemption."));
            library.AddBook(new Book("Frankenstein", "Mary Shelley", new DateTime(1818, 1, 1), 19.99m,
                "A Gothic science fiction novel."));


            Console.WriteLine("Books in Library:");
            Console.WriteLine(library.ToString());
            Console.WriteLine();

            Console.WriteLine("Books by Fyodor Dostoevsky:");
            var booksByDosoevsky = library.FindBooksByAuthor("Fyodor Dostoevsky");

            foreach (var book in booksByDosoevsky)
            {
                Console.WriteLine(book.ToString());
            }

            Console.WriteLine();

            var bookToUpdate = library.FindBooksByAuthor("Harper Lee").First();
            library.UpdateBook(bookToUpdate,
                new Book("The Picture of Dorian Gray", "Oscar Wilde", new DateTime(1890, 7, 20), 17.50m,
                    "A philosophical novel about vanity and hedonism."));


            Console.WriteLine("Books in Library after update:");
            Console.WriteLine(library.ToString());
            Console.WriteLine();

            var booksByTolkien = library.FindBooksByAuthor("J.R.R. Tolkien");
            foreach (var book in booksByTolkien)
            {
                library.RemoveBook(book);
            }

            Console.WriteLine("Books in Library after removal:");
            Console.WriteLine(library.ToString());
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

    public interface ILibrary
    {
        List<IBook> Books { get; }
        void AddBook(IBook book);
        void RemoveBook(IBook book);
        void UpdateBook(IBook oldBook, IBook newBook);
        List<IBook> FindBooksByAuthor(string author);
        List<IBook> FindBooksByTitle(string title);
        List<IBook> FindBooksByPublicationDate(DateTime publicationDate);
        List<IBook> FindBooksByPrice(decimal price);
        string ToString();
    }

    public class Book : IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Book(string title, string author, DateTime publicationDate, decimal price, string description)
        {
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
            Price = price;
            Description = description;
        }

        public override string ToString()
        {
            return
                $"{Title} by {Author}, Published: {PublicationDate.ToShortDateString()}, Price: {Price} PLN, Description: {Description}";
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

        public List<IBook> FindBooksByAuthor(string author)
        {
            return Books.Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<IBook> FindBooksByTitle(string title)
        {
            return Books.Where(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<IBook> FindBooksByPublicationDate(DateTime publicationDate)
        {
            return Books.Where(book => book.PublicationDate.Date == publicationDate.Date).ToList();
        }

        public List<IBook> FindBooksByPrice(decimal price)
        {
            return Books.Where(book => book.Price == price).ToList();
        }

        public override string ToString()
        {
            StringBuilder books = new StringBuilder();
            foreach (var book in Books)
            {
                books.AppendLine(
                    $"Title: {book.Title}, Author: {book.Author}, Publication Date: {book.PublicationDate.ToShortDateString()}, Price: {book.Price} PLN, Description: {book.Description}");
            }

            return books.ToString();
        }
    }
}