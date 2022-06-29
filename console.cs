using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptr
{
    class console
    {
        public static void menu(bool mode)
        {
            if (mode == true) // Did the user enter "Encrypt" on the previous menu?
            {
                Console.WriteLine("ENCRYPT Selected. What algorithm would you like to use?");
                algorithm.shared.caeser.encrypt(5,true,"hello");
            } else if (mode == false) // Or did they enter "Decrypt"?
            {
                Console.WriteLine("DECRYPT Selected. What algorithm would you like to use?");
            }
        }
        public static void ListAlgorithms()
        {

        }
        static void ListStatistics(bool MODE, string )
        {
            Console.WriteLine("-- End of Line -- ");
            Console.WriteLine()
        }
        public static void FetchAlgorithm(int Algorithm) // Load the algorithm class
        {
        }
    }
}
