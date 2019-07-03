using System;

namespace ToDoItem_App
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUtil ToDo = new ConsoleUtil();
            if (!ToDo.DisplayMenu())
            {
                //repeat the code...
            }
            else
            {
                ToDo.ProcessInput();
            }

            Console.Read();
        }
    }
}
