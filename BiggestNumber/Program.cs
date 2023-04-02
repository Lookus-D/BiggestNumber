using System;

namespace BiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me your 3 numbers, please.");
            //Example:
            //a = 25;
            //b = 63;
            //c = 79;
            Console.WriteLine("Give me your first number:");
            string a = Console.ReadLine();
            int chosenA = 0;
            Int32.TryParse(a, out chosenA);

            Console.WriteLine("Give me your second number:");
            string b = Console.ReadLine();
            int chosenB = 0;
            Int32.TryParse(b, out chosenB);

            Console.WriteLine("Give me your third number:");
            string c = Console.ReadLine();
            int chosenC = 0;
            Int32.TryParse(c, out chosenC);


            if ((chosenA > chosenB) && (chosenA > chosenC))
            {
                Console.WriteLine($"The biggest is first number \"{chosenA}\".");
            }
            else if ((chosenB > chosenA) && (chosenB > chosenC))
            {
                Console.WriteLine($"The biggest is second number \"{chosenB}\".");
            }
            else
            {
                Console.WriteLine($"The biggest is third number \"{chosenC}\".");
            }
        }
    }

}
