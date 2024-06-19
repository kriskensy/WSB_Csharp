using System;
using System.Collections.Generic;

namespace Lab_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> lista = new List<Task>()
            {
                new Task("Task 1", 1, DateTime.Now),
                new Task("Task 2", 2, DateTime.Now),
                new Task("Task 3", 3, DateTime.Now),
                new Task("Task 4", 4, DateTime.Now),
            };

            TaskManagement taskManagement = new();
        }
    }

    public class Task
    {
        public string Title { get; set; }
        public int Priority { get; set; }
        public DateTime Deadline { get; set; }

        public Task(string title, int priority, DateTime deadline)
        {
            Title = title;
            Priority = priority;
            Deadline = deadline;
        }
    }

    public class TaskManagement
    {
        public List<Task> FilterTasks(IEnumerable<Task> tasks, Func<Task, bool> criterion)
        {
            var result = new List<Task>();

            foreach (var item in tasks)
            {
                if (criterion(item))
                    result.Add(item);
            }

            return result;
        }
    }

    // public class MyList<T>
    // {
    //     private T[] _items;
    //     public int Count { get; private set; }
    //
    //     public MyList()
    //     {
    //         _items = new T[10];
    //         Count = 0;
    //     }
    //
    //     public void Add(T item)
    //     {
    //         if (Count == _items.Length)
    //         {
    //             var temp = new T[_items.Length * 2];
    //             for (var i = 0; i < _items.Length; i++)
    //                 temp[i] = _items[i];
    //         
    //             _items = temp;
    //         }
    //
    //         _items[Count] = item;
    //         Count++;
    //     }
    //
    //     public T Get(int index)
    //     {
    //         if (index < 0 || index > Count)
    //             throw new IndexOutOfRangeException("Wrong index value");
    //
    //         return _items[index];
    //     }
    //
    //     public void Remove(int index)
    //     {
    //         if (index < 0 || index > Count)
    //             throw new IndexOutOfRangeException("Wrong index value");
    //
    //         for (int i = index; i < Count; i++)
    //             _items[i] = _items[i + 1];
    //
    //         Count--;
    //         _items[Count] = default(T);
    //     }
    //
    //     public bool Contains(T item)
    //     {
    //         foreach (var i in _items)
    //         {
    //             if (ReferenceEquals(item, i))
    //                 return true;
    //         }
    //
    //         return false;
    //     }
    // }
}