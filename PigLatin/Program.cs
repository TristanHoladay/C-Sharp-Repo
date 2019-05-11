using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            //PigLatin Method
            //ask user for english word
            //Calling converter method
            Console.WriteLine("Please input an English word: ");
            string input = Console.ReadLine();
            Console.WriteLine(ToPigLatin(input));
            Console.Read();
        }

        //PigLatin Function
        public static string ToPigLatin(string word)
        {
            
            bool startsWith = false;
            bool endsWith = false;
            string currentVowel = string.Empty;

            char[] vowels = { 'a', 'e', 'i','o', 'u'};

            //Make string lowercase
            string wordLower = word.ToLower();

            //figure out if word starts/ends with vowel
            // if yes add "yay"

            if (wordLower.IndexOfAny(vowels) == -1)
            {
                return (word + "ay");
            }
            else
            {
                for (int i = 0; i < vowels.Length; i++)
                {
                    currentVowel = vowels[i].ToString();
                    if (wordLower.StartsWith(currentVowel))
                    {
                        startsWith = true;
                        break;
                    }

                    if (wordLower.EndsWith(currentVowel))
                    {
                        endsWith = true;
                        break;
                    }
                }
            }

            if(startsWith == true && endsWith == true)
            {
                return (word + "yay");
            }
            else if (startsWith == true && endsWith == false)
            {
                return (word + "ay");
            }
            else
            {
                int firstVowelPosition = wordLower.IndexOfAny(vowels);
                string firstHalf = word.Substring(0, firstVowelPosition);
                string secondHalf = word.Substring(firstVowelPosition);
                return (secondHalf + firstHalf + "ay");
            }
        }
    }
}
