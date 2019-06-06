using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCos
{
    class Program
    {
        static void Main(string[] args)
        {
            DriverLicense DL = new DriverLicense("Francis", "Peterson", "Male", "1234567");
            Console.WriteLine(DL.Name());

            Console.Read();
        }

            #region DL
        public class DriverLicense
        {
            public string firstName { get; private set; }
            public string lastName { get; private set; }
            public string Gender { get; private set; }
            public string LicenseNumber { get; private set; }


            public DriverLicense(string fn, string ln, string gender, string dlNum )
            {
                firstName = fn;
                lastName = ln;
                Gender = gender;
                LicenseNumber = dlNum;
            }

            public string Name()
            {
                string FullName = firstName + " " + lastName;
                return FullName;
            }
            #endregion

            #region Book
            class Book
         {
            public string Title { get; private set; }
            public List<string> Authors { get; private set; }
            public string Pages { get; private set; }
            public string SKU { get; private set; }
            public string Publisher { get; private set; }
            public string Price { get; private set; }


            public Book(string T, string A, string P, string sku, string Pub, string cost)
            {
                    Title = T;
                    Authors.Add(A);
                    Pages = P;
                    SKU = sku;
                    Publisher = Pub;
                    Price = cost;
            }
         }
            #endregion

            #region Airplane
            class Airplane
            {
                public string Manufacturer { get; private set; }
                public string Model { get; private set; }
                public string Variant { get; private set; }
                public string Capacity { get; private set; }
                public int Engines { get; private set; }

                public Airplane(string Man, string Mod, string Var, string Cap, int Eng)
                {
                    Manufacturer = Man;
                    Model = Mod;
                    Variant = Var;
                    Capacity = Cap;
                    Engines = Eng;
                }


                private string _myField;

                public string MyProperty
                {
                    get
                    {
                        return _myField;
                    }
                    set
                    {
                        _myField = value;
                    }
                }




            }
#endregion
        }
    }
}
