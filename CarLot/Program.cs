using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Read();
        }
    }

    class CarLot
    {
        protected string Name;
        private List<string> Vehicles;

        public CarLot(string name, string vehicle)
        {
            Name = name;
            Vehicles.Add(vehicle);
        }
    }

    #region Vehicle
   abstract class Vehicle
    {
       abstract public string licenseNumber { get; }
        abstract public string Make { get; }
        abstract public string Model { get; }
        abstract public int Price { get; }

        public abstract string Description();
       
    }
    #endregion

    class Car : Vehicle
    {

    }

    class Truck : Vehicle
    {

    }


}
