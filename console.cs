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
                Console.WriteLine("ENCRYPT Selected. Please Select a Direction, Left or Right.");
                string direction = Console.ReadLine();
                bool dir;
                Console.WriteLine("ENCRYPT Selected. Please Enter the key you wish to use.");
                int KEY = Int32.Parse(Console.ReadLine());
                Console.WriteLine("ENCRYPT Selected. Please Enter Your Text.");
                string messagetoencrypt = Console.ReadLine();

                if (direction.ToLower().StartsWith("l"))
                {
                    dir = false;
                } else
                {
                    dir = true;
                }
                string h = algorithm.shared.caeser.encrypt(KEY,dir,messagetoencrypt);


                /* Why did I make this? */
                Console.WriteLine();
                Console.WriteLine(" -- Algorithm Completed! -- ");
                Console.WriteLine();
                Console.WriteLine("Original Statement: " + messagetoencrypt);
                Console.WriteLine("Final    Statement: " + h);
                Console.WriteLine();
                Console.WriteLine("-- END OF LINE --");
                main.Show_mainmenu(0);
            } else if (mode == false) // Or did they enter "Decrypt"?
            {
                Console.WriteLine("ENCRYPT Selected. Please Select a Direction, Left or Right.");
                string direction = Console.ReadLine();
                bool dir;
                Console.WriteLine("ENCRYPT Selected. Please Enter the key you wish to use.");
                int KEY = Int32.Parse(Console.ReadLine());
                Console.WriteLine("ENCRYPT Selected. Please Enter Your Text.");
                string messagetoencrypt = Console.ReadLine();

                if (direction.ToLower().StartsWith("l"))
                {
                    dir = false;
                }
                else
                {
                    dir = true;
                }
                string h = algorithm.shared.caeser.decrypt(KEY, dir, messagetoencrypt);


                /* Why did I make this? */
                Console.WriteLine();
                Console.WriteLine(" -- Algorithm Completed! -- ");
                Console.WriteLine();
                Console.WriteLine("Original Statement: " + messagetoencrypt);
                Console.WriteLine("Final    Statement: " + h);
                Console.WriteLine();
                Console.WriteLine("-- END OF LINE --");
                main.Show_mainmenu(0);
            }
        }
        public static void ListAlgorithms()
        {

        }
        public static void FetchAlgorithm(int Algorithm) // Load the algorithm class
        {
        }
    }
}
