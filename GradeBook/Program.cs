using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        static Dictionary<string, string> gradeBook = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            studentInput();
            outputGradeBook();
            Console.Read();
        }

        #region Input
        public static void studentInput()
        {
            //ask for input or quit
            Console.WriteLine("Welcome to Grade Book! Would you like to input data: yes or no?");
            string choice = Console.ReadLine().ToLower();

            while (choice != "no")
            {

                Console.WriteLine("Please enter a first name: ");
                string studentName = Console.ReadLine();

                Console.WriteLine("Please enter student's grades separated by spaces like so: 100 100 100 100.");
                string studentGrades = Console.ReadLine();

                gradeBook.Add(studentName, studentGrades);

                Console.WriteLine("Do you want to input another student or quit?");
                string quit = Console.ReadLine();

                if (quit == "quit")
                {
                    break;
                }
            }     
        }
        #endregion

        #region Output
        public static void outputGradeBook()
        {
            foreach(KeyValuePair<string, string> kvp in gradeBook)
            {
                //split the values and trim the white space
                string trimmedString = kvp.Value.Trim();
                string[] stringGrades = trimmedString.Split(' ');
                int[] numberGrades = new int[stringGrades.Length];
                
                //loop to convert strings into integers and store in int[]
                for(int i=0; i<stringGrades.Length; i++)
                {
                    numberGrades[i] = Convert.ToInt32(stringGrades[i]);
                }

                int lowestGrade = numberGrades.Min();
                int highestGrade = numberGrades.Max();
                int sum = 0;
                
                //loop to get sum of grades
                for(int i=0; i<numberGrades.Length; i++)
                {
                    sum += numberGrades[i];
                }

                float average = (sum / numberGrades.Length);

                Console.WriteLine($"{kvp.Key}:\nHighest Grade is {highestGrade} \nLowest Grade is {lowestGrade} \nAverage is {average}");
            }
        }
        #endregion

    }
}
