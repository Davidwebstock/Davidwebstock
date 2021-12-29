using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAPP
{
    public class ToDo
    {
        public static void ListItems()
        {
            

            var toDoList = new List<string>();
            bool consoleRunning = true;

            Console.WriteLine("This is a to do list program");
            Console.WriteLine("Commands: '-Exit', '-Show', '-' \n");

            while (consoleRunning == true)
            {
                Console.WriteLine("Please enter a list item to add or a command to perform:");
                //read in what the user types
                var input = Console.ReadLine();

                switch (input)
                {
                    //exit
                    case string a when a.StartsWith("-Exit"):
                        consoleRunning = false;
                        break;
                    //remove
                    case string b when b.EndsWith("-"):
                        var endIndex = b.IndexOf("-");
                        var item = b.Substring(0, endIndex);
                        if (toDoList.Contains(item))
                        {
                            toDoList.Remove(item);
                            Console.WriteLine("Removed {0} \n", item);
                        }
                        else
                        {
                            Console.WriteLine("{0} is not currently in the list, it cannot be removed", item);
                        }
                        break;
                    //show
                    case string c when c.StartsWith("-Show"):
                        Console.WriteLine("\n------To Do List-----");
                        foreach (var task in toDoList)
                        {
                            Console.WriteLine(task);
                        }
                        Console.WriteLine("---------------------\n");
                        break;
                    //if none of those commands are given, 
                    //add whatever was typed in to the To Do list
                    default:
                        toDoList.Add(input);
                        break;
                }
            }
        }


    }
}

