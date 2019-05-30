using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardTraining2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedScores = { 37, 89, 41, 65, 91, 53 };

            for (int i = 0; i < unsortedScores.Length; i++)
            {
                sortedScores(unsortedScores);
            }

            for(int i=0; i<unsortedScores.Length; i++)
            {
                Console.WriteLine(unsortedScores[i]);
            }

            Console.Read();
        }

        public static void sortedScores(int[] unsortedArray)
        {
            int smallerOne = 0;
            for (int i=0; i<unsortedArray.Length-1; i++)
            {
                if(unsortedArray[i] < unsortedArray[i+1])
                {
                    smallerOne = unsortedArray[i];
                    unsortedArray[i] = unsortedArray[i + 1];
                    unsortedArray[i + 1] = smallerOne;
                }
            }
        }

    }
}
