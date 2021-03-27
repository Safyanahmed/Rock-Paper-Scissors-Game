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
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;
                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.WriteLine("Choose rock, paper, or scissors:    ");
                    inputPlayer = Console.ReadLine();
                
                    Random rnd = new Random();

                    randomInt = rnd.Next(1,4);

                    switch (randomInt) 
                    {
                        case 1:
                            inputCPU = "rock";
                            Console.WriteLine("Computer chose Rock.");
                            if (inputPlayer == "rock") 
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "paper")
                            {
                                Console.WriteLine("PLAYER WINS!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "scissors") 
                            {
                                Console.WriteLine("COMPUTER WINS!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "paper";
                            Console.WriteLine("Computer chose Paper.");
                            if (inputPlayer == "paper")
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "scissors") 
                            {
                                Console.WriteLine("PLAYER WINS!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "rock") 
                            {
                                Console.WriteLine("COMPUTER WINS!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 3:
                            inputCPU = "scissors";
                            Console.WriteLine("Computer chose Scissors.");
                            if (inputPlayer == "scissors")
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "rock") 
                            {
                                Console.WriteLine("PLAYER WINS!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "paper") 
                            {
                                Console.WriteLine("COMPUTER WINS!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                        Console.WriteLine("Invalid Entry!");

                        break;
                    }
                    Console.WriteLine("\n\nScores:\tPLAYER:\t{0}\tCOMPUTER:\t{1}", scorePlayer, scoreCPU);
                }
                if (scorePlayer == 3) {
                    Console.WriteLine("Player WINS!");
                }
                else if (scoreCPU == 3) {
                    Console.WriteLine("Computer Wins!");
                }
                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "no")
                {
                    playAgain = false;
                }
                else
                {
                    
                }
            }
        } 
    }
}

