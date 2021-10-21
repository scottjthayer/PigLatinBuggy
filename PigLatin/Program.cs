﻿using System;
using System.Linq;

namespace PigLatin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Translate translate = new Translate();
            Console.WriteLine("Please input a word or sentence to translate to pig Latin");
            string input = Console.ReadLine().ToLower().Trim();

            if (translate.CheckForSpecialCharacters(input) == true)
            {
                Console.WriteLine(input);
            }
            else if (translate.CheckForSpecialCharacters(input) == false)
            {
                string translation = translate.ToPigLatin(input);
                Console.WriteLine(translation);
            }
        }


        //public static bool IsVowel(char c)
        //{
        //    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        //    return c.ToString() == vowels.ToString();
        //}

        //public static string ToPigLatin(string word)
        //{
        //    char[] specialChars = { '@', '.', '-', '$', '^', '&' };
        //    word = word.ToLower();
        //    foreach(char c in specialChars)
        //    {
        //        foreach(char w in word)
        //        {
        //            if (w == c)
        //            {
        //                Console.WriteLine("That word has special characters, we will return it as is");
        //                return word;
        //            }
        //        }

        //    }

        //    bool noVowels = true;
        //    foreach(char letter in word)
        //    {
        //        if (IsVowel(letter))
        //        {
        //            noVowels = false;
        //        }
        //    }

        //    if (noVowels)
        //    {
        //        return word; 
        //    }

        //    char firstLetter = word[0];
        //    string output = "placeholder";
        //    if (IsVowel(firstLetter) == true)
        //    {
        //        output = word + "ay";
        //    }
        //    else
        //    {
        //        int vowelIndex = -1;
        //        //Handle going through all the consonants
        //        for (int i = 0; i <= word.Length; i++)
        //        {
        //            if (IsVowel(word[i]) == true)
        //            {
        //                vowelIndex = i;
        //                break;
        //            }
        //        }

        //        string sub = word.Substring(vowelIndex + 1);
        //        string postFix = word.Substring(0, vowelIndex -1);

        //        output = sub + postFix + "ay";
        //    }

        //    return output;


    }
}
