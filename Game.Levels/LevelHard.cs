using System;
using Game.Interfaces;


namespace Game.Levels
{
    public class LevelHard : IGame
    {
        
        private const int Trails = 3;

        private int SecretNumber = 43;
        
        public int NumberOfGuessLeft { get ; set ;}
        
        public LevelHard()
        {
            NumberOfGuessLeft = Trails;
        }
        public void Play()
        {
            for (int i = 1; i <= Trails ; i++)
            {
                Console.Write("Guess a number between 1 and 50: ");
                int guess = int.Parse(Console.ReadLine());
                if (guess == SecretNumber)
                {
                    Console.WriteLine("\nYou got it right!\a");
                    break;
                }
                else if(i == Trails)
                {
                    Console.WriteLine();
                    Console.WriteLine("Game over!\a");
                    Console.WriteLine("The secret number is {0}", SecretNumber);
                }
                else
                {
                    NumberOfGuessLeft--;
                    Console.WriteLine();
                    Console.WriteLine("That was wrong");
                    Console.WriteLine("You got {0} trails left", NumberOfGuessLeft);
                    continue;
                }

            }
        }

    }
}