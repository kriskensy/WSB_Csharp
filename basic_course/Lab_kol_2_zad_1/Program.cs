using System;
using System.Collections.Generic;

namespace Lab_kol_2_zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();

            IProduct notebookDell = new Product("Notebook Dell", 1799.00m);
            IProduct monitorMSI = new Product("Monitor MSI", 249.00m);
            IProduct headsetJabra = new Product("Headset Jabra", 219.00m);

            cart.AddProduct(notebookDell);
            cart.AddProduct(monitorMSI);
            cart.AddProduct(headsetJabra);

            Console.WriteLine(cart);
            Console.WriteLine($"-> Total price: {cart.CalculateTotal()}");

            IProduct tabletSurface = new Product("Tablet Surface", 1299.00m);
            IProduct mouseLogi = new Product("Mouse Logi", 99.00m);
            IProduct keyboardLogi = new Product("Keyboard Logi", 79.00m);

            cart = cart + tabletSurface;
            cart = cart + mouseLogi;
            cart = cart + keyboardLogi;
            cart = cart - headsetJabra;

            Console.WriteLine();

            Console.WriteLine(cart);
            Console.WriteLine($"-> Total price: {cart.CalculateTotal()}");
        }
    }

    public interface IProduct
    {
        string Name { get; }
        decimal Price { get; }
    }

    public interface ICart
    {
        void AddProduct(IProduct product);
        void RemoveProduct(IProduct product);
        decimal CalculateTotal();
    }

    public class Product : IProduct
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1:C}", Name, Price);
        }
    }

    public class Cart : ICart
    {
        private List<IProduct> cartProducts = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            cartProducts.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            cartProducts.Remove(product);
        }

        public decimal CalculateTotal()
        {
            decimal totalPrice = 0;
            foreach (var product in cartProducts)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
        }


        public static Cart operator +(Cart cart, IProduct product)
        {
            cart.AddProduct(product);
            return cart;
        }

        public static Cart operator -(Cart cart, IProduct product)
        {
            cart.RemoveProduct(product);
            return cart;
        }

        public override string ToString()
        {
            return string.Join("\n", cartProducts);
        }
    }
}


/*
 * Stwórz aplikację do obsługi sklepu internetowego, która zawiera funkcjonalność dla produktów oraz koszyka zakupowego.
 * Zadanie polega na zaprojektowaniu interfejsów oraz przeciążeniu operatorów dla klas związanych z produktami i koszykiem.

Zdefiniuj interfejs "IProduct" z następującymi składowymi:
◦ Właściwość "Name" (typ string) - przechowuje nazwę produktu
◦ Właściwość "Price" (typ decimal) - przechowuje cenę produktu
Następnie, zdefiniuj interfejs "ICart" z następującymi składowymi:
◦ Metoda "AddProduct" - przyjmuje obiekt typu "IProduct" i dodaje go do koszyka
◦ Metoda "RemoveProduct" - przyjmuje obiekt typu "IProduct" i usuwa go z koszyka
◦ Metoda "CalculateTotal" - zwraca sumę cen wszystkich produktów w koszyku
Stwórz klasę "Product", która implementuje interfejs "IProduct". Klasa powinna zawierać odpowiednie właściwości oraz konstruktor.
Następnie, zdefiniuj klasę "Cart", która implementuje interfejs "ICart". Klasa powinna przechowywać listę produktów oraz zaimplementować metody interfejsu.
Przeciąż operatory "+" i "-" dla klasy "Cart", tak aby umożliwić dodawanie i usuwanie produktów za pomocą tych operatorów.

Zadania:

Zaimplementuj interfejsy "IProduct" oraz "ICart" według powyższych specyfikacji.
Stwórz kilka obiektów klasy "Product" i dodaj je do obiektu klasy "Cart". Wywołaj metodę "CalculateTotal" i wyświetl jej wynik.
Przetestuj przeciążone operatory "+" i "-" dla obiektu klasy "Cart". Dodaj kilka produktów za pomocą operatora "+"
oraz usuń jeden produkt za pomocą operatora "-". Wywołaj ponownie metodę "CalculateTotal" i wyświetl jej wynik.
*/