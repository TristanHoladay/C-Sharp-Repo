using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5._2WhiteBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsPalindrome(string word)
            {
                int midPoint = word.Length / 2;

                if (word == null)
                {
                    return false;
                }
                else
                { 
                    for (int i = 0; i < midPoint; i++)
                    {
                        if (word[i] != word[word.Length - i - 1])
                        {
                            return false;
                        }
                    }

                    return true;
                }
            }
        }
    }
}
