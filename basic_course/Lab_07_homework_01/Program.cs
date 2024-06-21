using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_07_homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>
            {
                new Task("Football game", 1, new DateTime(2024, 6, 22)),
                new Task("C# homework", 1, new DateTime(2024, 6, 11)),
                new Task("Saturday party", 2, new DateTime(2024, 6, 13)),
                new Task("Workout", 4, new DateTime(2024, 6, 4)),
                new Task("Book reading", 3, new DateTime(2024, 6, 9)),
                new Task("Football game", 1, new DateTime(2024, 6, 23)),
            };

            TaskManagement tasksManagement = new TaskManagement();

            List<Task> footballGame = tasksManagement.TaksFilter(tasks, z => z.Title.Contains("Football game"));
            footballGame.ForEach(Console.WriteLine);
            Console.WriteLine();

            List<Task> prio1 = tasksManagement.TaksFilter(tasks, z => z.Priority == 1);
            prio1.ForEach(Console.WriteLine);
            Console.WriteLine();

            List<Task> date13June = tasksManagement.TaksFilter(tasks, z => z.TaskDeadline <= new DateTime(2024, 6, 13));
            date13June.ForEach(Console.WriteLine);
        }
    }

    public class Task
    {
        public string Title { get; set; }
        public int Priority { get; set; }
        public DateTime TaskDeadline { get; set; }

        public Task(string title, int priority, DateTime taskDeadline)
        {
            Title = title;
            Priority = priority;
            TaskDeadline = taskDeadline;
        }

        public override string ToString()
        {
            return $"Task: {Title}, prio: {Priority}, deadline: {TaskDeadline.ToShortDateString()}";
        }
    }

    public class TaskManagement
    {
        public List<Task> TaksFilter(List<Task> tasks, Func<Task, bool> criterion)
        {
            return tasks.Where(criterion).ToList();
        }
    }
}