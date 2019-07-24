using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightlyWB1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 0, 2, 3, 4 };
            int[] arr2 = new int[] { 3, 5, 6, 7, 8, 13 };

            int a1Length = arr1.Length;
            int a2Length = arr2.Length;
            int sumLength = 0;
            

            if (a1Length >= a2Length)
            {
                sumLength = a1Length;
            }
            else
            {
                sumLength = a2Length;
            }

            int[] sum = new int[sumLength];

            for (int i = 0; i < sumLength; i++)
            {
                try
                {
                    sum[i] = arr1[i] + arr2[i];
                }
                catch
                {
                    if(a1Length < sumLength)
                    {
                        sum[i] = 0 + arr2[i];
                    }
                    else if (a2Length < sumLength)
                    {
                        sum[i] = arr1[i] + 0;
                    }
                }
            }

            foreach(int i in sum)
            {
                Console.Write(i +"|");
            }

            Console.Read();

        }
    }
}
