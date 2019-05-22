using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBTraining3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the longest string.");

            Console.WriteLine("Enter a sentence and I will find the longest word in it:");

            string userSentence = Console.ReadLine().Trim();

            string[] userWords = userSentence.Split(' ');
            char[] punctuation = new char[] { ',', '.', '?', '!', '/', '\\', '*', '$', '%'};

            string longestWord = "";
            string tempWord = "";
            int wordLength = 0;

            foreach(string word in userWords)
            {
                for(int i=0; i<punctuation.Length; i++)
                {
                    tempWord = word.Replace(punctuation[i].ToString(), "");
                }
               
            }

            if(tempWord.Length > longestWord.Length)
            {
                longestWord = tempWord;
            }
            wordLength = longestWord.Length;

            Console.WriteLine("The longest word is {0}. It has a length of {1}.", longestWord, wordLength);
            Console.Read();
        }
    }
}
