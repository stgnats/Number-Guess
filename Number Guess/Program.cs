using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            /* use this space to write your own short program! 
            Here's what you learned:

            CONDITIONALS: if, if...else, else if
            SWITCH STATEMENT: switch (condition)
            TERNARY OPERATOR: (condition) ? true : false
            Good luck! */
            Random rng = new Random();
        start:;
            int guess = 0;
            while (guess == 0) //give the user a chance to enter a valid integer if they enter incorrect data
            {
                Console.Write("Welcome to Number Guess! Enter a number between 1 and 10 below and try and guess the number!\nGuess the number: ");
                string guessStr = Console.ReadLine();
                int.TryParse(guessStr, out guess);
                if (guess != 0) //stops the loop if a valid integer is entered
                {
                    break;
                }
            }
            bool correct = false;
            int ans = rng.Next(1, 10);
            while (correct == false)
            { 
                if (guess == ans)
                {
                    Console.WriteLine("You are correct!\nPlay again? ");
                    string again = Console.ReadLine();
                    if (again.ToLower() == "yes")
                    {
                        goto start;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("Incorrect! Try again: ");
                string guessStr = Console.ReadLine();
                int.TryParse(guessStr, out guess);
            }
        }
    }
}