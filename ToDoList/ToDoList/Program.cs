using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>();

        while (true) // menu loop
        {
            ShowMenu();
            string choice = Console.ReadLine();

            switch (choice) //user choices
            {
                case "1":
                    AddTask(tasks);
                    break;

                case "2":
                    ViewTasks(tasks);
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine();//an empty line

        }

    }

    static void ShowMenu()
    {
        Console.WriteLine("==== ToDo Menu ====");
        Console.WriteLine("1. Add Task");
        Console.WriteLine("2. View Tasks");
        Console.WriteLine("3. Exit");
        Console.Write("Choose an option: ");

    }

    static void AddTask(List<string> tasks)
    {
        Console.Write("Enter task: ");
        string task = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(task)) //input validation
        {
            tasks.Add(task);
            Console.WriteLine("Task added.");
        }
        else
        {
            Console.WriteLine("Task cannot be empty.");
        }
    }

    static void ViewTasks(List<string> tasks)
    {
        Console.WriteLine("---- Tasks ----");
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++) //for loop
            {
                Console.WriteLine($"{i + 1}.{tasks[i]}");// string interpolation
            }
        }
    }
}