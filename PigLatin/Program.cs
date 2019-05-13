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
            Console.WriteLine("Please write an English sentence: ");
            string input = Console.ReadLine();
            Console.WriteLine(PigLatin(input));
            Console.Read();
        }


        //Converting Sentences Method
        public static string PigLatin(string sentence)
        {
            string pigSentence = String.Empty;

            //takes sentence, trims off white space
            string trimSent = sentence.Trim();

            //breaks up each word
            string[] sentArr = trimSent.Split(' ');
            
            for(int i = 0; i<sentArr.Length; i++)
            {
                string currentWord = sentArr[i];

                //feeds word into ToPigLatin
                string pigWord = ToPigLatin(currentWord);

                //gets back result and adds back into a sentence
                pigSentence = pigSentence + pigWord + " "; 
            }

            return pigSentence;
        }

        //Converting Word into PigLatin Function
        public static string ToPigLatin(string word)
        {
            
            bool startsWith = false;
            bool endsWith = false;
            bool hasPunctuation = false;
            bool hasVowel = false;
            string currentVowel = string.Empty;
            string cleanWord = string.Empty;
            string punc = string.Empty;

            //Make string lowercase
            string wordLower = word.ToLower();
            int lastChar = wordLower.Length - 1;

            char[] vowels = { 'a', 'e', 'i','o', 'u'};
            char[] punctuation = { '.', ',', '!', '?', ';', ':'};

            if (wordLower.IndexOfAny(punctuation) > -1)
            {
                for (int i = 0; i < punctuation.Length; i++)
                {
                    punc = punctuation[i].ToString();
                    if (punc == wordLower[lastChar].ToString())
                    {
                        cleanWord = wordLower.Remove(lastChar);
                        break;
                       
                    }
                }
            }
            else
            {
                cleanWord = wordLower;
            }

            //figure out if word starts/ends with vowel
            // if yes add "yay"

            if (cleanWord.IndexOfAny(vowels) == -1)
            {
                return (word + "ay" + punc);
            }
            else
            {
                hasVowel = true;

                for (int i = 0; i < vowels.Length; i++)
                {
                    currentVowel = vowels[i].ToString();
                    if (cleanWord.StartsWith(currentVowel))
                    {
                        startsWith = true;
                        break;
                    }
                }

                for (int i = 0; i < vowels.Length; i++)
                {
                    currentVowel = vowels[i].ToString();
                    if (cleanWord.EndsWith(currentVowel))
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
                return (word + "ay" + punc);
            }
            else
            {
                int firstVowelPosition = cleanWord.IndexOfAny(vowels);
                string firstHalf = cleanWord.Substring(0, firstVowelPosition);
                string secondHalf = cleanWord.Substring(firstVowelPosition);
                return (secondHalf + firstHalf + "ay" + punc);
            }
        }
    }
}
