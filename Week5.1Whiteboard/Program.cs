using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5._1Whiteboard
{
    class Program
    {
        static int add(int x, int y)
        {
            return x + y;
        }

        //currying: returning function as value that will take the next arg given
        static Func<int, int> add(int x)
        {
            return y => x + y;
        }

        static void Main(string[] args)
        {
            //raise to power of 2
            int[] myArr = { 1, 5, 10, 4, 2 };
            int sum = 0;
            foreach(int x in myArr)
            {
                if(Math.Pow(x, 2) % 4 == 0)
                {
                    sum +=  (int)Math.Pow(x, 2);
                }
            }

            //calling on the Func<> created above
            Console.WriteLine(add(5)(2));
            
        }
    }
}
