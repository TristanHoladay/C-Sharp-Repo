using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable_Presentation
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "Hello");
            ht.Add("2", "World");


            if(ht.Contains(1))
            {
                Console.WriteLine(ht[1]);
            }


            int hcode = ht[1].GetHashCode();
            int hcodeB = ht["2"].GetHashCode();
            Console.WriteLine(hcode);
            Console.WriteLine(hcodeB);


            Console.Read();
        }
    }
}
