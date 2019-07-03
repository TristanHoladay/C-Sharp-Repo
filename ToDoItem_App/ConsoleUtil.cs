using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoItem_App
{
    class ConsoleUtil
    {
        public App App;
        public UserInput Choice { get; set; }

        public enum UserInput
        {
            l,
            done,
            pending,
            a,
            u,
            d,
            q
        }

        public ConsoleUtil()
        {
            App = new App();
            Console.WriteLine("Hello. Welcome to your To Do List. Please select from the following options:");
        }

        public bool DisplayMenu()
        {
            string menu = @"
             List All Items: L/l
             List Items According to Status: done/pending
             Update an Item: U/u
             Add an Item: A/a
             Delete an Item: D/d
             Quit: Q/q";
            Console.WriteLine(menu);

            Choice = (UserInput) Enum.Parse(typeof(UserInput), Console.ReadLine().ToLower());
            if(Enum.IsDefined(typeof(UserInput), Choice))
            {
                return true;
            }
            else
            {
                Console.WriteLine("You did not input a valid menu option. Please try again.");
                return false;
            }
            
        }

        public void ProcessInput()
        {
            while (Choice != UserInput.q)
            {
                switch (Choice)
                {
                    case UserInput.l:
                        List<ToDoItem> List = App.ListItems();
                        Console.WriteLine(List);
                        break;
                    case UserInput.done:
                        Console.WriteLine(App.ListItems("done"));
                        break;
                    case UserInput.pending:
                        App.ListItems("pending");
                        break;
                    case UserInput.a:
                        Console.WriteLine("Add and Item: Please provide information in the form-- description|status|dueDate(mm/dd/yyyy)");
                        string itemInfo = Console.ReadLine();
                        string[] parts = itemInfo.Split('|');
                        App.AddItem(parts[0], parts[1], Convert.ToDateTime(parts[2]));
                        break;
                    case UserInput.u:
                        Console.WriteLine("To update an item please provide the updated information as: ID|new description |new status|new duedate(mm/dd/yyyy)");
                        string updateInfo = Console.ReadLine();
                        string[] upParts = updateInfo.Split('|');
                        App.UpdateItem(int.Parse(upParts[0]), upParts[1], upParts[2], Convert.ToDateTime(upParts[3]));
                        break;
                    case UserInput.d:
                        Console.WriteLine("Please provide the ID of the item you would like to delete.");
                        int id = int.Parse(Console.ReadLine());
                        App.DeleteItems(id);
                        break;
                }

                DisplayMenu();
            }
            
            //User has chosen to quit
            Console.WriteLine("Have a great day!");
        }
        
    }
}
