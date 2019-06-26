using System;

namespace Week7._1PreWork
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsContext context = new StudentsContext();

            context.Database.EnsureCreated();

            Console.WriteLine("Do you want to enter students? Y/N");
            string choice = Console.ReadLine().ToLower();

            while (choice != "n")
            {

                Console.WriteLine("Enter Student full name");
                String fullName = Console.ReadLine();

                string[] parts = fullName.Split();
                if (parts.Length == 2)
                {
                    Student newStudent = new Student(parts[0], parts[1]);

                    context.students.Add(newStudent);

                    context.SaveChanges();
                    Console.WriteLine("Added the student");
                }
                else
                {
                    Console.WriteLine("Invalid full name, did not add student");
                }

                Console.WriteLine("Add another student? Y/N");
                choice = Console.ReadLine().ToLower();
            }

            Console.WriteLine("The Current List of Students are: ");

            foreach(Student s in context.students)
            {
                Console.WriteLine("{0} - {1} {2}", s.Id, s.FirstName, s.LastName);
            }
        }
    }
}
