using System;

namespace Cryptr
{
    class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cryptr Cipher Codec by Sudo");
            Console.WriteLine();
            Show_mainmenu(1);
        }
        static void Show_mainmenu(int num)
        {
            if (num == 1)
            {
                Console.WriteLine("Welcome User, what would you like to do? (Encrypt/Decrypt):");
            } else
            {
                Console.WriteLine("What would you like to do? (Encrypt/Decrypt):");
            }
            var raw_decisison = Console.ReadLine();
            bool finaldecision;

            Console.WriteLine();
            if (raw_decisison.ToLower().StartsWith("e"))
            {
                finaldecision = true;
                console.menu(finaldecision);
            } else if (raw_decisison.ToLower().StartsWith("d"))
            {
                finaldecision = false;
                console.menu(finaldecision);
            } else
            {
                Console.WriteLine("Sorry, I did not get that. Could you please try again?");
                Show_mainmenu(0);
            }
        }
    }
}
