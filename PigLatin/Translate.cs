using System;
using System.Collections.Generic;
using System.Text;

namespace PigLatin
{
    class Translate
    {
        public static bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char ch in vowels)
            {
                if (ch == c)
                { return true; }
            }
            return false;
        }
        public bool CheckForSpecialCharacters(string word)
        {
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            foreach (char c in specialChars)
            {
                foreach (char w in word)
                {
                    if (w == c)
                    {
                        Console.WriteLine("That word has special characters, we will return it as is");
                        return true;
                    }
                }
            }
            return false;
        }
        public string ToPigLatin(string word)
        {
            //I don't like this.


            //this is strange depending on the understanding of pig latin. Some sites state that you still ad -ay if no vowels are found. But to each their own.              
            char firstLetter = word[0];
            bool vowelFirst = IsVowel(firstLetter);
            if (vowelFirst == true)
            {
                return word + "way";
            }
            else if (vowelFirst == false)
            {
                return TranslateConsonantWord(word);
            }
            else
            {
                foreach (char letter in word)
                {
                    bool noVowels = IsVowel(letter);
                    if (noVowels != true)
                    {

                        break;
                    }

                }
                return word;
            }
        }
        public string TranslateConsonantWord(string word)
        {
            int vowelIndex = 0;
            //Handle going through all the consonants
            //IS IT THOUGH>??
            for (int i = 0; i < word.Length; i++)
            {
                if (IsVowel(word[i]) == true)
                {
                    vowelIndex = i - 1;
                    break;
                }
            }

            string sub = word.Substring(vowelIndex + 1);
            string postFix = word.Substring(0, vowelIndex + 1);

            return sub + postFix + "ay";
        }
    }
}
