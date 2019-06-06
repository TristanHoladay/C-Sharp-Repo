
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToDoItem
{
    #region ToDoItem Class
    public class ToDoItem
    {
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Priority { get; set; }

        public ToDoItem(string Des, string Date, string Prior)
        {
            Description = Des;
            DueDate = Date;
            Priority = Prior;
        }

    }
    #endregion
    class Program
    {
        private static List<ToDoItem> ToDoList = new List<ToDoItem>();

        static void Main(string[] args)
        {
            CreateItems();
            OutPut();
            Console.Read();
        }

        #region Add Items
        public static void CreateItems()
        {
            Console.WriteLine("Welcome to your To Do List");
            Console.WriteLine("Would you like to add an item or show your current list?");
            string Choice = Console.ReadLine().ToLower();

            while (Choice != "show")
            {
                Console.Write("Please Enter a Description: ");
                string description = Console.ReadLine();

                Console.Write("Please Enter a Due Date in the format MM/DD/YYYY: ");
                string date = Console.ReadLine();

                Console.Write("Please Enter the Item's Priority Level (High, Normal, or Low): ");
                string priority = Console.ReadLine();

                ToDoItem item = new ToDoItem(description, date, priority);
                ToDoList.Add(item);

                Console.WriteLine("Add Another Item? Yes/No");
                string secondChoice = Console.ReadLine().ToLower();
                if(secondChoice == "no")
                {
                    break;
                }

            }
        }
        #endregion

        public static void OutPut()
        {
            int count = 0;

            Console.WriteLine("To Do List:");
            Console.WriteLine("Description | " + "Due Date |" + " Priority");
            Console.WriteLine("---------------------------------");
            foreach (ToDoItem item in ToDoList)
            {
                count += 1;
                Console.WriteLine(count+ ") " + item.Description + " | " + item.DueDate + " | " + item.Priority);
            }
            
        }

    }
}
