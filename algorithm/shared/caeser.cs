using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptr.algorithm.shared
{
    class caeser : algorithm
    {
        static string EngAlphabetRef = "abcdefghijklmnopqrstuvwxyz"; // he he he ha
        public static string encrypt(int shift,bool direction,string message)
        {
            message = message.ToLower();
            string newalphabet = Shift(shift, direction);
            char[] messageasarray = message.ToCharArray();
            char[] alphabetarray = EngAlphabetRef.ToCharArray();
            char[] newAlphabetarray = newalphabet.ToCharArray();
            string output = "";
            for (int i=0; i<message.Length; i++)
            {
                if (!EngAlphabetRef.Contains(messageasarray[i]))
                {
                    
                    output = output + new String(messageasarray[i],1);
                    i++;
                }
                Console.WriteLine(messageasarray[i]);
                for (int b=0;b<alphabetarray.Length;b++)
                {
                    if (alphabetarray[b] == messageasarray[i]) {
                        Console.WriteLine("MATCH! Message character: " + messageasarray[i] + ", Character: " + alphabetarray[b]);
                        Console.WriteLine("Letter Encryption for " + messageasarray[i] + " is " + newAlphabetarray[b]);
                        output = output + new String(newAlphabetarray[b], 1);
                        b = alphabetarray.Length - 1;
                        
                    } else
                    {
                        Console.WriteLine("No Match - Message character: " + messageasarray[i] + ", Character: " + alphabetarray[b]);
                    }
                }
            }

            return output;
        }
        static string Shift(int shift,bool direction)
        {
            string newalphabet;

            Console.WriteLine(direction); // Debug
            
            // Step 1: Figure out what direction to move the alphabet.
            if (direction == true) // Right
            {
                newalphabet = EngAlphabetRef.Substring(0, EngAlphabetRef.Length - shift).Insert(0, EngAlphabetRef.Substring(EngAlphabetRef.Length - shift));
            } else // Left
            {
                newalphabet = EngAlphabetRef.Substring(shift).Insert(EngAlphabetRef.Substring(shift).Length, EngAlphabetRef.Substring(0, shift));
            }
            Console.WriteLine("Current Alphabet: " + EngAlphabetRef); // Debug
            Console.WriteLine("New Alphabet:     " + newalphabet);

            return newalphabet;
        }
        public static string decrypt(int shift, bool direction, string message)
        {
            string newalphabet = Shift(shift, !direction);


            return null;
        }
    }
}
