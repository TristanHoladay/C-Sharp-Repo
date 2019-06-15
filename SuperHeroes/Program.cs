using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    class Program
    {
        private static List<Person> personList = new List<Person>();

        static void Main(string[] args)
        {
            addToList();
            PrintList();
            Console.Read();   
        }

        #region List Creation
        public static void addToList()
        {
            Person p1 = new Person("Terry", "T-Dog");
            Person p2 = new Person("Cam", "Cam-shaft");
            SuperHero sh1 = new SuperHero("Charging Charles", "Charlie Whitcomb", "Rhino Charge");
            SuperHero sh2 = new SuperHero("Majestic Manatee", "Francis Peterson", "Sea Cow Binge of Death");
            Villain v1 = new Villain("Master Madness", "Charging Charles");
            Villain v2 = new Villain("Captain Cutthroat", "Majetic Manatee");


            personList.AddRange(new Person[] { p1, p2, sh1, sh2, v1, v2 });
        }
        #endregion

        #region Print
        public static string PrintList()
        {
            foreach (Person obj in personList)
            {
                Console.WriteLine(obj.Name + ": " + obj.PrintGreeting() + "\n");
            }

            return null;
        }
        #endregion
    }

    

    #region Person
    class Person
    {
        public string Name { get; set; }
        public string NickName { get; set; }

        public Person(string name, string nickname)
        {
            Name = name;
            NickName = nickname;
        }

        public override string ToString()
        {
            return Name;
        }

        public virtual string PrintGreeting()
        {
            return $"Hi, my name is {Name}, you can call me {NickName}.";
        }
    }
    #endregion

    #region Super Hero
    class SuperHero : Person
    {
        protected string RealName { get; set; }
        protected string SuperPower { get; set; }

        public SuperHero(string name, string real, string super) : base (name, null)
        {
            RealName = real;
            SuperPower = super;
        }

        public override string PrintGreeting()
        {
            return $"I am {RealName}. When I am {Name}, my super power is {SuperPower}!";
        }
    }
    #endregion

    #region Villain
    class Villain : Person
    {
        protected string Nemesis { get; set; }

        public Villain(string name, string nemesis) : base (name, null)
        {
            Nemesis = nemesis;
        }

        public override string PrintGreeting()
        {
            return $"I am {Name}! Have you seen {Nemesis}?!";
        }
    }
    #endregion
}
