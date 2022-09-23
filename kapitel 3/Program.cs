using System;
namespace Upggift_3._13
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder >= 16)
            {
                Console.WriteLine("Du kan delta i tävlingen");
            }
            else if (ålder >= 19)
            {
                Console.WriteLine("Du får delta i tävlingen");
            }
            else if (ålder >= 19)
            {
                Console.WriteLine("Du är för gammal du kan inte delta i tävlingen");
            }
            else
            {
                Console.WriteLine("Tyvär, du är för ung. Du kan inte delta i tävlingen");
            }
        }
    }
}