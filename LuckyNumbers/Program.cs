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
                //PART 1
                //Ask the user for a starting number for the lowest number in the number range.
                //Ask the user for an ending number for the highest number in the number range.
                //Ask the user to guess the 6 numbers the user thinks will be the lucky numbers generated within the number range.
                //Numbers must be stored in an array
                //Array must be populated using a loop
                //If the user enters a number that is outside of the range set, prompt the user to give you a valid number. 
                //Do this until the user enters a valid number.
                //
                //PART 2
                //The program should randomly generate 6 numbers using a loop
                //The randomly generated numbers should be stored in an array
                //Numbers should be displayed to the console as such and using a loop (Numbers below are for example only. Format must be exact):
                //Lucky Number: 12
                //Lucky Number: 47
                //Lucky Number: 28
                //Lucky Number: 3
                //Lucky Number: 19
                //Lucky Number: 35
                //
                //PART 3
                //Hard - code a value for the jackpot amount and let the user know what the jackpot amount is at some point you decide in the program.
                //The program should count the number of correctly guessed numbers and output to the console to notify the user.Example:
                //You guessed 3 numbers correctly!
                //The program should calculate the user's winnings based on the number of numbers guessed correctly.

                //The user's winnings should be output to the console. Example:
                //You won $256, 877.23!
                //
                //PART 4
                //Ask the user if the user would like to play again.
                //If the user says yes, then the program should run again from the beginning.
                //If the user says no, then the program should say "Thanks for playing!"(Must be exact statement).

                //PART 1

                int jackpotAmt = 100000;

                Console.WriteLine("Welcome to LUCKY'S SUPER LOTTO! \nThe unique game of chance where YOU, the user, can take \ncontrol of your own fortune!");
                Console.WriteLine("The Jackpot amount today is: $" + jackpotAmt);
                Console.WriteLine("Ready to make some money? \nPress any key to begin! \n");
                Console.ReadKey();

                Console.Write("Enter a number (This will be the lowest number in the range): ");
                int lowNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter another number (This will be the highest number in the range): ");
                int highNumber = int.Parse(Console.ReadLine());


                //int userNumbers = int.Parse(Console.ReadLine());
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
                Console.WriteLine("Press enter to see the lucky numbers!");
                Console.ReadKey();

                Random randomNumber = new Random();
                int[] numRan = new int[6];
                for (int i = 0; i <= numRan.Length - 1; i++)
                {
                    Console.WriteLine("Lucky Number: " + numRan[i] + randomNumber.Next(lowNumber, highNumber));
                }

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
                //Console says 6 correct even if 0 are correct

                Console.WriteLine("You won $" + jackpotAmt / 6 * match);

                Console.WriteLine("Do you want to play again? y/n");
                string userResponse = Console.ReadLine();
                string userResponseAny = userResponse.ToUpper();
                if (userResponseAny == "y")
            {
                
            }
                if (userResponseAny != "y")
                {
                    Environment.Exit(0);
                }

        }
    }
}
