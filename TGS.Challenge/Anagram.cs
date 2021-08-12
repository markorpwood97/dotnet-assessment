using System;
using System.Text.RegularExpressions;

namespace TGS.Challenge
{
  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class Anagram
    {
        //Initial Solution Idea:
        //1. Remove Special Characters
        //2. Check if length of both words match
        //3. Loop through first work checking if letter exists removing letter in second word until completed

        public bool AreAnagrams(string word1, string word2)
        {
            word1 = Regex.Replace(word1, @"[^0-9a-zA-Z]+", "").ToLower();
            word2 = Regex.Replace(word2, @"[^0-9a-zA-Z]+", "").ToLower();

            if (word1 == string.Empty || word2 == string.Empty)
            {
                throw new ArgumentException();
            }

            if (word1.Length != word2.Length)
            {
                return false;
            }

            foreach (var word1Character in word1)
            {
                if (!word2.Contains(word1Character))
                {
                    return false;
                }
                word2 = word2.Remove(word2.IndexOf(word1Character), 1);
            }

            return true;
        }
    }
}
