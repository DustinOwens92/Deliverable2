using System;

namespace Deliverable2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Guess which will have more: heads or tails?");
            string headsOrTailsGuess = Console.ReadLine();
            //ask user how many times to flip coin



            var numberOfFlips = 0;

            var heads = 0;

            var tails = 0;

            float correctCount;
            Random flips = new Random();



            Console.WriteLine("How many times shall we flip a coin?");
            numberOfFlips = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine();

            for (var d = 0; d < numberOfFlips; d++)
            {
                var flip = flips.Next(1, 3);
                if (flip == 1)
                {
                    heads++;
                    Console.WriteLine("heads", d);
                }
                else
                {
                    tails++;
                    Console.WriteLine("tails", d);
                }
            }
            //correctCount if statement
            if (headsOrTailsGuess == "heads")
            {
                correctCount = heads;
            }
            else
            {
                correctCount = tails;
            }
            // if statement telling user how many times their guess came up and percentage
            if (headsOrTailsGuess == "heads")
            {

                Console.WriteLine();
                Console.WriteLine("You're guess, " + headsOrTailsGuess
                   + ", came up " + heads + " time(s).");
                Console.WriteLine("That's " + (correctCount / numberOfFlips * 100) + "%.");
            }
            else
            {

                Console.WriteLine();
                Console.WriteLine("You're guess, " + headsOrTailsGuess + ", came up " + tails + " time(s).");
                Console.WriteLine("That's " + (correctCount / numberOfFlips * 100) + "%.");
            }
        }
    }




}










