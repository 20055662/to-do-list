using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>();

        while (true) // menu loop
        {
            Console.WriteLine("==== ToDo Menu ====");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice) //user choices
            {
                case "1":
                    Console.Write("Enter task: ");
                    string task = Console.ReadLine();
                    tasks.Add(task);
                    Console.WriteLine("Task added");
                    break;

                case "2":
                    Console.WriteLine("---- Tasks ----");
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("No tasks");
                    }
                    else
                    {
                        for(int i=0; i< tasks.Count; i++) //for loop
                        {
                            Console.WriteLine($"{i + 1}.{tasks[i]}");// string interpolation
                        }
                    }
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
}