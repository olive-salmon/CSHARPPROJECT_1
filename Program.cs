using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;

            Console.Write("Choose between Rock, Paper and Scissors:    ");
            inputPlayer = Console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();

            Random rnd = new Random();

            

            randomInt = rnd.Next(0, 3);

            switch (randomInt)
            {
                case 0:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer chose Rock");
                    if (inputPlayer == "ROCK") 
                    {
                        Console.WriteLine("Draw!\n\n");
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("Player Wins!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "SCISSORS") 
                    {
                        Console.WriteLine("Computer Wins!\n\n");
                        scoreCPU++;
                    }
                    break;
                case 1:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer chose Paper");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("Computer Wins!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("Draw!\n\n");
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("Player Wins!\n\n");
                        scorePlayer++;
                    }
                    break;
                case 2:
                    inputCPU = "SCISSORS";
                    Console.WriteLine("Computer chose Scissors");
                    if (inputPlayer == "ROCK") 
                    {
                        Console.WriteLine("Player Wins!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "PAPER") 
                    {
                        Console.WriteLine("Computer Wins!\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "SCISSORS") 
                    {
                        Console.WriteLine("Draw!\n\n");
                    }

                    break;
                default:
                    Console.WriteLine("Invalid Entry!");
                    break;
            }
            Console.WriteLine("Computer Score is: "); Console.WriteLine(scoreCPU);
            Console.WriteLine("\n\nPlayer Score is:"); Console.WriteLine(scorePlayer);

        }
    }
}
