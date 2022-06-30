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
                string j = Console.ReadLine();
                string h = algorithm.shared.caeser.encrypt(5,true,j);
                Console.WriteLine("Original Statement: " + j);
                Console.WriteLine("Final    Statement: " + h);
                main.Show_mainmenu(0);
            } else if (mode == false) // Or did they enter "Decrypt"?
            {
                Console.WriteLine("DECRYPT Selected. What algorithm would you like to use?");
            }
        }
        public static void ListAlgorithms()
        {

        }
        static void ListStatisticsAndKill(bool MODE, string originalmessage, string finalmessage, string algorithm )
        {
            Console.WriteLine("-- Statistics -- ");
            Console.WriteLine();
        }
        public static void FetchAlgorithm(int Algorithm) // Load the algorithm class
        {
        }
    }
}
