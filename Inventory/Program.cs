using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        private static List<IRentable> InventoryList = new List<IRentable>();
        static void Main(string[] args)
        {
            IRentable b1 = new Boat("This is my first boat!");
            IRentable b2 = new Boat("This is my second boat!");
            IRentable c1 = new Car("This is my first car!");
            IRentable c2 = new Car("This is my second car!");
            IRentable h1 = new House("This is my first house!");
            IRentable h2 = new House("This is my second house!");

            InventoryList.AddRange(new IRentable[] {b1, b2, c1, c2, h1, h2 });

            foreach(IRentable item in InventoryList)
            {
                Console.WriteLine(item.GetType().Name);
                Console.WriteLine("Daily Rate: " + item.GetDailyRate());
                Console.WriteLine(item.GetDescription() + "\n");
            }

            Console.Read();
        }
    }

    public interface IRentable
    {
        decimal GetDailyRate();
        string GetDescription();
    }

    #region Boat
    public class Boat : IRentable
    {
        private decimal _hourlyRate = 25.00m;
        private string Description { get; set; }
        public Boat(string description)
        {
            Description = description;
        }
        public decimal GetDailyRate()
        {
            return Decimal.Round(_hourlyRate * 24, 2);
        }
        
        public string GetDescription()
        {
            return Description;
        }
    }
    #endregion

    #region House
    public class House : IRentable
    {
        private decimal _weeklyRate = 300.00m;
        private string Description { get; set; }

        public House(string description)
        {
            Description = description;
        }

        public decimal GetDailyRate()
        {
            return Decimal.Round(_weeklyRate / 7, 2);
        }

        public string GetDescription()
        {
            return Description;
        }
    }
    #endregion

    #region Car
    public class Car : IRentable
    {
        private decimal _dailyRate = 30.00m;
        private string Description { get; set; }

        public Car(string description)
        {
            Description = description;
        }

        public decimal GetDailyRate()
        {
            return _dailyRate;
        }

        public string GetDescription()
        {
            return Description;
        }
    }
    #endregion

}
