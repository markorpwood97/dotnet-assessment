﻿using System;
using System.Text;

namespace TGS.Challenge
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that number grouped by commas after every 3 digits. 
        
        NOTES: You cannot use any built-in formatting functions to complete this task.

        Assume: 0 <= n < 1000000000

        1 -> "1"
        10 -> "10"
        100 -> "100"
        1000 -> "1,000"
        10000 -> "10,000"
        100000 -> "100,000"
        1000000 -> "1,000,000"
        35235235 -> "35,235,235"

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class FormatNumber
    {
        //Initial Solution Idea:
        //1. Convert int to string
        //2. Run case on value.Length
        //3. Each case can build a new string putting "," where needed
        //3.1 Might be more efficient create int "charactersUsed" then loop through while (value.Length - charactersUsed) > 3 building a string
        //  that builds three numbers at a time using the end of the string
        //3.2 After loop, add remaining numbers to the front. 

        public string Format(int value)
        {
            StringBuilder output = new StringBuilder();
            string valueString = value.ToString();

            if (value < 0 || value >= 1000000000)
            {
                throw new ArgumentOutOfRangeException();
            }

            while (valueString.Length > 3)
            {
                for (int i = 1; i <= 3; i++)
                {
                    output.Insert(0, valueString[valueString.Length - 1]);
                    valueString = valueString.Remove(valueString.Length -1);
                }
                output.Insert(0, ",");
            }

            output.Insert(0, valueString);

            return output.ToString();
        }
    }
}
