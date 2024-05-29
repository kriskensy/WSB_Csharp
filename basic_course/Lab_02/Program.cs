using System;
using System.Linq;

namespace Lab_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] osoby = { "Tomek", "Romek", "Atomek" };
            //
            // int[] numbers;
            // numbers = new int[5];
            //
            // int[,] macierz = new[,]
            // {
            //     { 1, 2, 3 },
            //     { 4, 5, 6 },
            //     { 7, 8, 9 }
            // };
            //
            // //int[][] macierz2 = new int[3][];
            // int[][] macierz2 = new int[][]
            // {
            //     new int[] { 1, 2, 3 },
            //     new int[] { 4, 5, 6, 0, 6 },
            //     new int[] { 7, 8, 9, 5, 87, 23, 4 }
            // };
            //
            // char[] znaki = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            // var ostatniZnak = znaki[^2];
            // Console.WriteLine(ostatniZnak);
            //
            // var wycinek1 = znaki[..2];
            // Console.WriteLine(wycinek1);
            // var wycinek2 = znaki[2..];
            // Console.WriteLine(wycinek2);
            //
            // //petle
            // int i = 0;
            //
            // Console.Write("Petla do-while: ");
            // do
            // {
            //     Console.Write(i + " ");
            //     i++;
            // } while (i < znaki.Length);
            //
            // Console.WriteLine();
            //
            // while (i < znaki.Length)
            // {
            //     Console.Write(i + " ");
            //     i++;
            // }
            //
            // //dwie tozsame petle nieskonczone
            // // for (;;)
            // // {
            // // }
            // //
            // // while (true)
            // // {
            // // }
            //
            // //foreach, bez potrzeby implementacji logiki
            // Console.Write("Petla foreach: ");
            // foreach (var znak in znaki)
            // {
            //     Console.Write(znak + " ");
            // }

            //zad_1

            // int[] dane = new int[10];
            //
            // for (int i = 0; i < dane.Length; i++)
            // {
            //     dane[i] = i;
            // }
            //
            // foreach (var liczba in dane)
            // {
            //     Console.Write(liczba + " ");
            // }

            //zad_2

            // int[] dane2 = new int[10];
            //
            // for (int i = 0; i < dane2.Length; i++)
            // {
            //     dane2[i] = 9 - i;
            // }
            //
            // foreach (var liczba in dane2)
            // {
            //     Console.Write(liczba + " ");
            // }

            //zad_3

            // int[,] macierz = new int[10, 10];
            // int suma = 0;
            //
            // for (int i = 0; i < 10; i++)
            // {
            //     for (int j = 0; j < 10; j++)
            //     {
            //         if (i == j)
            //         {
            //             macierz[i, j] = 1;
            //             suma += macierz[i, j];
            //         }
            //         else
            //         {
            //             macierz[i, j] = 0;
            //         }
            //     }
            // }
            //
            // for (int i = 0; i < 10; i++)
            // {
            //     for (int j = 0; j < 10; j++)
            //     {
            //         Console.Write(macierz[i, j] + " ");
            //     }
            //     Console.WriteLine();
            // }
            //
            // Console.WriteLine("Suma przekątnej: " + suma);

            //zad_4

            // int[,] macierz = new int[10, 10];
            // int sumaKolumna1 = 0;
            // int sumaKolumna2 = 0;
            //
            // for (int i = 0; i < 10; i++)
            // {
            //     macierz[i, 0] = i;
            //     macierz[i, 1] = i * i;
            //
            //     sumaKolumna1 += macierz[i, 0];
            //     sumaKolumna2 += macierz[i, 1];
            //
            //     for (int j = 2; j < 10; j++)
            //     {
            //         macierz[i, j] = 0;
            //     }
            // }
            //
            // for (int i = 0; i < 10; i++)
            // {
            //     for (int j = 0; j < 10; j++)
            //     {
            //         Console.Write(macierz[i, j] + " ");
            //     }
            //
            //     Console.WriteLine();
            // }
            //
            // Console.WriteLine("Suma w pierwszej kolumnie: " + sumaKolumna1);
            // Console.WriteLine("Suma w drugiej kolumnie: " + sumaKolumna2);


            //zad_5

            // int[] dane = new int[100];
            //
            // for (int i = 0; i < dane.Length; i++)
            // {
            //     dane[i] = i + 1;
            // }
            //
            // int suma = 0;
            // foreach (int liczba in dane)
            // {
            //     suma += liczba;
            // }
            //
            // Console.WriteLine("Suma liczb: " + suma);

            //zad_6

            // int[] dane = new int[100];
            // int sumaParzyste = 0;
            // int sumaNieparzyste = 0;
            //
            // for (int i = 0; i < dane.Length; i++)
            // {
            //     dane[i] = i + 1;
            // }
            //
            // foreach (int liczba in dane)
            // {
            //     if (liczba % 2 == 0)
            //     {
            //         sumaParzyste += liczba;
            //     }
            //     else
            //     {
            //         sumaNieparzyste += liczba;
            //     }
            // }
            //
            // Console.WriteLine("Suma liczb parzystych: " + sumaParzyste);
            // Console.WriteLine("Suma liczb nieparzystych: " + sumaNieparzyste);

            //zad_7

            // Console.WriteLine("podaj rozmiar macierzy nxn: ");
            // int n = Convert.ToInt32((Console.ReadLine()));
            //
            // int[,] macierzA = new int[n, n];
            // int[,] macierzB = new int[n, n];
            // int[,] macierzSum = new int[n, n];
            //
            // Console.WriteLine("wartosci dla macierzy A: ");
            // for (int i = 0; i < n; i++)
            // {
            //     for (int j = 0; j < n; j++)
            //     {
            //         Console.Write($"element [{i},{j}]: ");
            //         macierzA[i, j] = Convert.ToInt32(Console.ReadLine());
            //     }
            // }
            //
            // Console.WriteLine("wartosci dla macierzy B: ");
            // for (int i = 0; i < n; i++)
            // {
            //     for (int j = 0; j < n; j++)
            //     {
            //         Console.Write($"element [{i},{j}]: ");
            //         macierzB[i, j] = Convert.ToInt32(Console.ReadLine());
            //     }
            // }
            //
            // Console.WriteLine("sumowanie macierzy: ");
            // for (int i = 0; i < n; i++)
            // {
            //     for (int j = 0; j < n; j++)
            //     {
            //         macierzSum[i, j] = macierzA[i, j] + macierzB[i, j];
            //     }
            // }
            //
            // for (int i = 0; i < n; i++)
            // {
            //     for (int j = 0; j < n; j++)
            //     {
            //         Console.Write(macierzSum[i, j] + " ");
            //     }
            //
            //     Console.WriteLine();
            // }

            //zad_8

            // int[] tablica1 = new int[11];
            // int[] tablica2 = new int[10];
            //
            // for (int i = 0; i < tablica1.Length; i++)
            // {
            //     tablica1[i] = i + 10;
            // }
            //
            // Random random = new Random();
            //
            // int wylosowanyElement = random.Next(10, 21);
            //
            // int j = 0;
            // for (int i = 0; i < tablica1.Length; i++)
            // {
            //     if (tablica1[i] != wylosowanyElement)
            //     {
            //         tablica2[j] = tablica1[i];
            //         j++;
            //     }
            // }
            //
            // int brakujacyElement = tablica1.Sum() - tablica2.Sum();
            //
            // Console.WriteLine("tablica 1: " + string.Join(", ", tablica1));
            // Console.WriteLine("tablica 2: " + string.Join(", ", tablica2));
            // Console.WriteLine("brakujacy element: " + brakujacyElement);

            //zad_9

            int rozmiarTablicy;
            
            do
            {
                Console.WriteLine("rozmiar tablicy (pomiędzy 10 a 20):");
            } while (!int.TryParse(Console.ReadLine(), out rozmiarTablicy) || rozmiarTablicy < 10 ||
                     rozmiarTablicy > 20);

            int[] tablica = new int[rozmiarTablicy];
            Random random = new Random();
            
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = random.Next(1, 21);
            }
            
            Console.WriteLine("Tablica przed sortowaniem:");
            Console.WriteLine(string.Join(", ", tablica));
            
            Array.Sort(tablica);
            
            Console.WriteLine("Tablica po sortowaniu:");
            Console.WriteLine(string.Join(", ", tablica));
        }
    }
}