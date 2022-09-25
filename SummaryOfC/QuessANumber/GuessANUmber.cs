using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuessANumber
{
    public enum GuessingPlayer
    {
        Human,
        Machine
    }
    internal class GuessANUmber
    {
        private readonly int max;
        private readonly int maxTries;
        private readonly GuessingPlayer guessingPlayer;
        public GuessANUmber(int max = 100, int maxTries = 5, GuessingPlayer guessingPlayer = GuessingPlayer.Human)
        {
            this.max = max;
            this.maxTries = maxTries;
        }
        public void Start()
        {
            if(guessingPlayer == GuessingPlayer.Human)
            {
                HumanGuesses();
            }
            else
            {
                MachineGuesses();
            }
        }
        private void HumanGuesses()
        {
            Random rand = new Random();
            int guessedNumber = rand.Next(0, max);

            int lastGuess = -1;
            int tries = 0;
            while(lastGuess != guessedNumber && tries < maxTries)
            {
                Console.WriteLine("Guess the number!");
                lastGuess = int.Parse(Console.ReadLine());
                if (lastGuess == guessedNumber)
                {
                    Console.WriteLine("Congrats! You Guessed a number!");
                    break;
                }
                else if (lastGuess < guessedNumber)
                {
                    Console.WriteLine("My number is greater");
                    tries++;
                }
                else
                {
                    Console.WriteLine("My number is less");
                    tries++;
                }
                if (tries == maxTries)
                {
                    Console.WriteLine("You lose");
                    break;
                }
            }
            
        }
        private void MachineGuesses()
        {
            Console.WriteLine("Enter a number that`s going to be guessed by a computer");

            int guessedNumber = -1;
            while (guessedNumber == -1)
            {
                int parsedNumber = int.Parse(Console.ReadLine());
                if (parsedNumber >= 0 && parsedNumber <= maxTries)
                {
                    guessedNumber = parsedNumber;
                }
            }
            int lastGuess = -1;
            int min = 0;
            int max = this.max;
            int tries = 0;

            while (lastGuess != guessedNumber && tries < maxTries)
            {
                lastGuess = (max + min) / 2;
                Console.WriteLine($"Did you guess this number - {lastGuess}");
                Console.WriteLine("if yes, enter `y`, if you number is greater - enter `g`, if less - `l`");

                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine("I guessed your number");
                    break;
                }
                else if (answer == "g")
                {
                    min = lastGuess;
                }
                else
                {
                    max = lastGuess;
                }

                if(lastGuess == guessedNumber)
                {
                    Console.WriteLine("Dont cheat");
                }
                tries++;
                if(tries == maxTries)
                {
                    Console.WriteLine("I lose");
                    break;
                }
            }
        }
    }
}
