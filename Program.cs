using System;
using Game.Levels;
using Game.Interfaces;

namespace GuessGame
{
    class Program
    {
        public static IGame GetGame(string level)
        {
            IGame game = null;

            switch (level.ToLower())
            {
                case "easy":
                    game = new LevelEasy();
                    break;
                case "medium":
                    game = new LevelMedium();
                    break;
                
                case "hard":
                    game = new LevelHard();
                    break;
                default:
                    throw new ArgumentException("Invalid Level Set");
            }

            return game;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Yo! Welcome to Start NG Guess Game..");
                Console.WriteLine("......................................");
                Console.WriteLine("Input \n(1) for Easy Level\n(2) for Medium Level\n(1) for Hard Level");
                Console.Write("Select Level: ");
                int levelSelected  = int.Parse(Console.ReadLine());
                switch (levelSelected)
                {
                    case 1:
                        IGame gameEasy = GetGame("easy");
                        gameEasy.Play();
                        break;
                    case 2:
                        IGame gameMedium = GetGame("medium");
                        gameMedium.Play();
                        break;
                    case 3:
                        IGame gameHard = GetGame("hard");
                        gameHard.Play();
                        break;
                    default:
                        Console.WriteLine("Invalid Input.. Try Again!");
                        break;
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
            
        }
    }
}
