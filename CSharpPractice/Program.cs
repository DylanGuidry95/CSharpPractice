using System;
using System.Collections.Generic;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //I = 1
            //V = 5
            //L = 10
            //C = 100
            //D = 500
            //M = 1000

            //Decimal Values
            //1 = I
            //4 = IV
            //5 = V
            //9 = IX
            //10 = X
            //40 = XL
            //50 = L
            //90 = XC
            //100 = C
            //400 = CD
            //500 = D
            //900 = CM
            //1000 = M

            Dictionary<int, string> DecToRoman = new Dictionary<int, string>
            {
                { 1, "I" },
                { 4, "IV" },
                { 5, "V" },
                { 9, "IX" },
                { 10, "X" },
                { 40, "XL" },
                { 50, "L" },
                { 90, "XC" },
                { 100, "C" },
                { 400, "CD" },
                { 500, "D" },
                { 900, "CM" },
                { 1000, "M" }
            };

            int UserValue = 100;
            string RomanValue = "";

            int curValue = UserValue;
            while (curValue > 0)
            {
                KeyValuePair<int, string> lastLowest;
                if (DecToRoman.ContainsKey(curValue))
                {
                    lastLowest = 
                        new KeyValuePair<int, string>(curValue,DecToRoman[curValue]);
                    curValue = curValue - lastLowest.Key;
                    RomanValue += lastLowest.Value;
                    break;                    
                }

                foreach (var kvp in DecToRoman)
                {
                    if(kvp.Key > curValue)
                        break;
                    lastLowest = kvp;
                }
                curValue = curValue - lastLowest.Key;
                RomanValue += lastLowest.Value;
            }
            Console.WriteLine(RomanValue);
            Console.ReadKey();
        }
    }
}
