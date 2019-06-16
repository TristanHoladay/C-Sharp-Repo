using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    #region Main
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle c1 = new Car("sedan", 4)
            {
                Make = "Ford",
                Model = "Fusion",
                licenseNumber = "123JI540",
                Price = 21000
            };
            Vehicle c2 = new Car("coup", 2)
            {
                Make = "BMW",
                Model = "Z3",
                licenseNumber = "ILE8873",
                Price = 30000
            };
            Vehicle t1 = new Truck(10)
            {
                Make = "Toyota",
                Model = "Tacoma",
                licenseNumber = "77DS822",
                Price = 35000
            };
            Vehicle t2 = new Truck(13)
            {
                Make = "Ford",
                Model = "F-150",
                licenseNumber = "9982NCB",
                Price = 40000
            };
            
            CarLot lot1 = new CarLot("Francis' Auto Sales");
            lot1.Add(c1);
            lot1.Add(c2);
            lot1.Printout();
            CarLot lot2 = new CarLot("Terry's Trucks");
            lot2.Add(t1);
            lot2.Add(t2);
            lot2.Printout();
            Console.Read();
        }
    }
    #endregion

    #region Car Lot
    class CarLot
    {
        protected string Name { get; }

        private List<Vehicle> Vehicles = new List<Vehicle>();

        public CarLot(string name)
        {
            Name = name.ToUpper();
        }

        public void Add(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public void Printout()
        {
            int num = 1;

            Console.WriteLine(Name);
            Console.WriteLine("Vehicle Inventory:\n");

            foreach(Vehicle vehicle in Vehicles)
            {
                Console.WriteLine($"({num})");
                Console.WriteLine(vehicle.Description() + "\n");
                num++;
            }
        }
    }
    #endregion

    #region Vehicle
    abstract class Vehicle
    {
        public string licenseNumber;
        public string Make;
        public string Model;
        public int Price;

        public virtual string Description()
        {
            return "This is a Vehicle Description";
        }
    }
    #endregion

    #region Car
    class Car : Vehicle
    {
        protected string Type { get; set; }
        protected int Doors { get; set; }

        public Car(string t, int num)
        {
            Type = t.ToUpper();
            Doors = num;
        }

        public override string Description()
        {
            return $"[Make: {Make}\n Model: {Model}\n Type: {Type}\n Number of Doors: {Doors}\n License Number: {licenseNumber}\n Price: ${Price}]";
        }
    }
    #endregion

    #region Truck
    class Truck : Vehicle
    {
        protected int bedSize { get; set; }

        public Truck(int ft)
        {
            bedSize = ft;
        }

        public override string Description()
        {
            return $"[Make: {Make}\n Model: {Model}\n Bed Size in sq-ft: {bedSize}\n License Number: {licenseNumber}\n Price: ${Price}]";
        }
    }
    #endregion
}
