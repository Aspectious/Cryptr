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
            } else if (mode == false) // Or did they enter "Decrypt"?
            {

            }
        }
        public static void FetchAlgorithm(int Algorithm)
        {
            algorithm.algorithm caeser;
        }
    }
}
