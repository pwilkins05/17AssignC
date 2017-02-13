using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console app should play guessing game with player, player gets 3 tries to guess
            //a number from 1 to 25
            Random generator = new Random(); //Setup random number

            //Bug: random generator is not properly generating from 1 to 25
            int randomNumber = generator.Next(1, 26);

            Console.WriteLine("Let's play a little game!");
            Console.WriteLine("Guess the number from 1 to 25");

            int tries = 0; //counts attempts
            int input = int.Parse(Console.ReadLine());
			
			//Bug: while loop is not incrementing
            while (tries < 3)
            {
                if (input == randomNumber)
                {
                    Console.WriteLine("You guessed right! You win!");
                    Console.ReadLine();
                }
                else if (input != randomNumber)
                {
                    Console.WriteLine("Try again!");
                    Console.WriteLine("Guess the number from 1 to 25");
                    Console.ReadLine();
                }
            }

            if (tries == 3)
            {
                Console.WriteLine("Sorry, you lost!");
                Console.ReadLine();
            }
        }
    }
}
