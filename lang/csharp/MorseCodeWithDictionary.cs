using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
					
public class Program
{
	public static void Main()
	{
		
		Dictionary<char, String> morse = new Dictionary<char, String>()
            {
                {'A' , ".-"},
                {'B' , "-..."},
                {'C' , "-.-."},
                {'D' , "-.."},
                {'E' , "."},
                {'F' , "..-."},
                {'G' , "--."},
                {'H' , "...."},
                {'I' , ".."},
                {'J' , ".---"},
                {'K' , "-.-"},
                {'L' , ".-.."},
                {'M' , "--"},
                {'N' , "-."},
                {'O' , "---"},
                {'P' , ".--."},
                {'Q' , "--.-"},
                {'R' , ".-."},
                {'S' , "..."},
                {'T' , "-"},
                {'U' , "..-"},
                {'V' , "...-"},
                {'W' , ".--"},
                {'X' , "-..-"},
                {'Y' , "-.--"},
                {'Z' , "--.."},
                {'0' , "-----"},
                {'1' , ".----"},
                {'2' , "..---"},
                {'3' , "...--"},
                {'4' , "....-"},
                {'5' , "....."},
                {'6' , "-...."},
                {'7' , "--..."},
                {'8' , "---.."},
                {'9' , "----."},
            };
		
		    Console.WriteLine("Write something:");
            String input = Console.ReadLine();
            input = input.ToUpper();

            for (int i = 0; i < input.Length; i++)
            {
                if (i > 0)
                    Console.Write('/');

                char c = input[i];
                if (morse.ContainsKey(c))
                    Console.Write(morse[c]);
            }

            Console.WriteLine();
	}
}
