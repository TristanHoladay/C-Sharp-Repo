using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPreWork
{
    class Car
    {
        //Color Property
        public string Color { get; private set; }

        //Car Constructor Method
        public Car(string initialColor)
        {
            Color = initialColor;
        }


        static void Main(string[] args)
        {
            Car bluecar = new Car("blue");
            Garage smallGarage = new Garage(2);

            smallGarage.ParkCar(bluecar, 0);
            Console.WriteLine(smallGarage.Cars);
        }
    }

    class Garage
    {
        //Garage Field
        private Car[] carsArray;

        //Garage Property
        public int Size { get; private set; }

        //Garage Constructor Method
        public Garage(int initialSize)
        {
            Size = initialSize;
            this.carsArray = new Car[initialSize];
        }

        //Garage Method
        public void ParkCar (Car car, int spot)
        {
            carsArray[spot] = car;
        }

        //Written Out Getter 
        public string Cars {
            get {
                string printOut = "";
                for(int i=0; i<carsArray.Length; i++)
                {
                    if(carsArray[i] != null) {
                        printOut += string.Format("The {0} car is in spot {1}.{2}", carsArray[i].Color, i, Environment.NewLine);
                    }
                }
                return printOut;
            }
        }

    }
}
