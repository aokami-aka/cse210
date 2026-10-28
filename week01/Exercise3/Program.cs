using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int counter = 0;

            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            while (guess != magicNumber)
            {
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Lower");
                    counter++;
                }

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {counter} guesses.");

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }
    }
}