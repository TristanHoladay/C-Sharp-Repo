using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoItem_App
{
    class App
    {
        public UserChoice Choice { get; set; }

        public App(string choice)
        {
            this.Choice = choice;
        }

        public enum UserChoice
        {
            ListItem,
            AddItem,
            UpdateItem,
            DeleteItem,
            Quit
        }

       public void ProcessInput()
       {
            if(Choice == UserChoice.Quit)
            {

            }
       }
         

    }
}
