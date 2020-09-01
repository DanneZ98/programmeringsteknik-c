﻿using System;
using System.Linq;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv en konsollapplikation som tar emot en skriven text.
            // Ha med antal ord
            // Antal vokaler
            // Vilket det längsta ordet är
            Console.WriteLine("Insert a sentence");
            char[] vowels = new char[] { 'a', 'o', 'i', 'e', 'u', 'y', 'å', 'ä', 'ö' };

            string userInput = Console.ReadLine();
            string myLowerCaseString = userInput.ToLower();
            
            int wordcount = userInput.Length;

            string[] words = myLowerCaseString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int vowelCount = 0;
            string longestWord = string.Empty;
            
            foreach (var word in words)
            {
                foreach (var character in word)
                {
                    if (vowels.Contains(character))
                    {
                        vowelCount++;
                    }
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }
            }
            
            Console.WriteLine("Longest word: " + longestWord);
            Console.WriteLine("Vowel count: " + vowelCount);
            Console.WriteLine("Word count: " + wordcount);
        }
    }
}
using System;
using System.Linq;

namespace WordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv en konsolapplikation som tar emot en skriven text.
            Console.WriteLine("Enter a string, preferrably containing a sentence.");

            char[] vowels = new char[] { 'a', 'o', 'i', 'e', 'u', 'y', 'å', 'ä', 'ö' };

            string enteredString = Console.ReadLine();
            string lowercaseString = enteredString.ToLower();
            
            string[] words = lowercaseString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int vowelCount = 0;
            int wordCount = words.Length;
            string longestWord = string.Empty;


            // Dubbel foreach-loop
            foreach (var word in words)
            {
                foreach (var character in word)
                {
                    if (vowels.Contains(character))
                    {
                        vowelCount++;
                    }
                }

                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            // Man kan även loopa strängar på detta sätt
            for (var i = 0; i < enteredString.Length; i++)
            {
                var character = enteredString[i];
            }

            // Vi vill ha ut följande:
            // Antal ord?
            // Antal vokaler?
            // Vilket är det längsta ordet?

            Console.WriteLine("Word count: " + wordCount);
            Console.WriteLine("Vowel count: " + vowelCount);
            Console.WriteLine("Longest word: " + longestWord + ", " + longestWord.Length + " characters.");
        }
    }
}
