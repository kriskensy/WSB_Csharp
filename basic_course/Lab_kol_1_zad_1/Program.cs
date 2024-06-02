using System;
using System.Collections.Generic;

namespace Lab_kol_1_zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(int, int)> allGamesResults = new List<(int, int)>();
            int sumOfGoals = 0;

            Console.WriteLine("Write games results. Enter 'R' to see the results.");

            while (true)
            {
                Console.WriteLine("Game result: ");
                string gameResult = Console.ReadLine();

                if (gameResult == "R")
                    break;

                string[] results = gameResult.Split(' ');

                if (results.Length == 2 && int.TryParse(results[0], out int goalsTeam1) && goalsTeam1 >= 0 &&
                    int.TryParse(results[1], out int goalsTeam2) && goalsTeam2 >= 0)
                {
                    allGamesResults.Add((goalsTeam1, goalsTeam2));
                    sumOfGoals += goalsTeam1 + goalsTeam2;
                }
                else
                {
                    Console.WriteLine("incorrect value");
                }
            }

            int gameNumber = 0;

            while (gameNumber < allGamesResults.Count)
            {
                var gameResult = allGamesResults[gameNumber];
                Console.WriteLine($"Game {gameNumber + 1}, result: {gameResult.Item1}:{gameResult.Item2}");
                gameNumber++;
            }

            Console.WriteLine($"Sum of all goals: {sumOfGoals}.");
        }
    }
}

/*Napisz program w C#, który pobiera od użytkownika listę wyników meczów piłki nożnej (wynik składa się z dwóch liczb,
oznaczających ilość bramek zdobytych przez obie drużyny). Następnie program powinien wykorzystać pętlę while do wyświetlenia 
informacji o każdym meczu oraz obliczyć łączną liczbę bramek zdobytych przez wszystkie drużyny.*/