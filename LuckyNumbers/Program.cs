using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jackpotAmt = 100000;

            Console.WriteLine("Welcome to LUCKY'S SUPER LOTTO! \nThe unique game of chance where YOU, the user, can take \ncontrol of your own fortune!");
            Console.WriteLine("The Jackpot amount today is: $" + jackpotAmt);
            Console.WriteLine("Ready to make some money? \nPress any key to begin! \n");
            Console.ReadKey();
            //
            Console.Write("Enter a number (This will be the lowest number in the range): ");
            int lowNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter another number (This will be the highest number in the range): ");
            int highNumber = int.Parse(Console.ReadLine());
            //
            int[] userNumbers = new int[6];

            Console.WriteLine("Now enter SIX numbers to WIN BIG!");
            for (int i = 0; i <= userNumbers.Length - 1; i++)
            {
                userNumbers[i] = int.Parse(Console.ReadLine());
                while (userNumbers[i] < lowNumber || userNumbers[i] > highNumber)
                {
                    Console.WriteLine("Please enter a valid number: ");
                    userNumbers[i] = int.Parse(Console.ReadLine());
                }
            }
            //
            Console.WriteLine("Press enter to see the lucky numbers!");
            Console.ReadKey();

            Random randomNumber = new Random();
            int[] numRan = new int[6];
            for (int i = 0; i <= numRan.Length - 1; i++)
            {
                Console.WriteLine("Lucky Number: " + numRan[i] + randomNumber.Next(lowNumber, highNumber));
            }
            //
            Console.WriteLine("Press enter to see if your numbers match any of the lucky numbers! ");
            Console.ReadKey();

            int match = 0;
            foreach (int num in userNumbers)
            {
                if (num == numRan[0] || num == userNumbers[0] || num == numRan[1] || num == userNumbers[1] || num == numRan[2] || num == userNumbers[2] || num == numRan[3] || num == userNumbers[3] || num == numRan[4] || num == userNumbers[4] || num == numRan[5] || num == userNumbers[5])
                {
                    match++;
                }
            }
            Console.WriteLine("You guessed " + match + " correctly!");

            //Console says 6 correct even if 0 are correct?

            Console.WriteLine("You won $" + jackpotAmt / 6 * match);

            Console.Write("Do you want to play again? y/n: ");
            string userResponse = Console.ReadLine();
            string userResponseAny = userResponse.ToLower();
            if (userResponseAny == "y")
            {
                Console.Clear();
                
            }
            if (userResponseAny != "y")
            {
                Console.WriteLine("Thanks for playing!");
                Environment.Exit(0);
            }

        }
    }
}
