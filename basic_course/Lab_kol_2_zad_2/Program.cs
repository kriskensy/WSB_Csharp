using System;
using System.Collections.Generic;

namespace Lab_kol_2_zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            RegularUser user = new RegularUser("normal user", "123");
            Moderator moderator = new Moderator("moderator", "456", new List<string> { "Posts", "News" });
            Administrator admin = new Administrator("admin", "111", 2);

            user.GetInfo();
            moderator.GetInfo();
            admin.GetInfo();
        }
    }

    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Login: {Login}");
        }
    }

    public class Administrator : User
    {
        public int AccessLevel { get; set; }

        public Administrator(string login, string password, int accessLevel) : base(login, password)
        {
            AccessLevel = accessLevel;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Admin, access Level: {AccessLevel}");
        }
    }

    public class Moderator : User
    {
        public List<string> GrantedModules { get; set; }

        public Moderator(string login, string password, List<string> grantedModules) : base(login, password)
        {
            GrantedModules = grantedModules;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Moderator, granted Modules: " + string.Join(", ", GrantedModules));
        }
    }

    public class RegularUser : User
    {
        public RegularUser(string login, string password) : base(login, password)
        {
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Normal User");
        }
    }
}

/*
 * Załóżmy, że masz do wykonania system rejestracji użytkowników w aplikacji. Użytkownicy mają różne role, takie jak
 * Administrator, Moderator i Użytkownik. Zadanie polega na zaprojektowaniu hierarchii klas, które umożliwią zaimplementowanie tej funkcjonalności.

 Zdefiniuj klasę bazową o nazwie "User" z następującymi polami:
 ◦ Login (string) - przechowuje nazwę użytkownika
 ◦ Password (string) - przechowuje hasło użytkownika
Następnie, zdefiniuj klasę "Administrator", dziedziczącą po klasie "User", która posiada dodatkowe pole:
◦ AccessLevel (int) - przechowuje poziom uprawnień administratora (np. 1 - regular, 2 - advanced itp.)
Kolejna klasa, "Moderator", również dziedziczy po klasie "User" i posiada pola:
◦ GrantedModules (List) - przechowuje listę obszarów, w których moderator ma uprawnienia do moderacji
Na koniec, zdefiniuj klasę "RegularUser", dziedziczącą po klasie "User".

Zadania:

Zaimplementuj odpowiednie konstruktory dla klas "Administrator", "Moderator" i "RegularUser", które umożliwią ustawienie
wartości pól klasy bazowej ("User") oraz dodatkowych pól specyficznych dla każdej klasy.
Zaimplementuj metodę w klasie "User" o nazwie "GetInfo", która wyświetli na konsoli informacje o użytkowniku
(np. login, poziom dostępu dla administratora, moduły itp.). Stwórz instancje obiektów dla wszystkich klas:
"Administrator", "Moderator" i "RegularUser", i przetestuj działanie metody "GetInfo" dla każdego z obiektów.
Oceniane będą poprawność dziedziczenia, implementacja konstruktorów, działanie metody "GetInfo" oraz podatność na błędy.
*/