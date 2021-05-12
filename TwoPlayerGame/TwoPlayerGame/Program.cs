using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPlayerGame
{
    class SnakeAndLadder
    {
        int START_POSITION = 0;
        const int NoPlay = 0;
        const int Ladder = 1;
        const int Snake = 2;
        const int winning_position = 100;
        public void PlayGame()
        {
            int[] Player = new int[2] { 0, 0 };
            int Dice_Count = 0;
            int Chance = 0;
            while (Player[Chance] < winning_position)
            {
                Random random = new Random();
                int Die = random.Next(1, 7);
                int Option = random.Next(0, 3);
                Dice_Count++;
                Console.WriteLine($"Report the number of times the dice was played to win {Dice_Count}");


                switch (Option)
                {
                    case NoPlay:
                        Console.WriteLine("No Play, Pass the chance");
                        break;
                    case Ladder:
                        if (Player[Chance] +Die <= winning_position)
                        {
                            Player[Chance] += Die;

                        }
                        Console.WriteLine("You got Ladder \n Player position = " + Chance + "--->" + "Position" + " " + Player[Chance]);
                        break;
                    case Snake:
                        if (Player[Chance] -Die < START_POSITION)
                        {
                            Player[Chance] = START_POSITION;
                        }
                        else
                        {
                            Player[Chance] -= Die;
                        }
                        Console.WriteLine("You gotSnake \n player = " + Chance + "---> position " + " " + Player[Chance]);

                        break;
                    default:
                        break;
                }
                if (Option == NoPlay || Option == Snake)
                {
                    if (Chance == 0)
                    {
                        Chance = 1;
                    }
                    else
                    {
                        Chance = 0;
                    }
                }

            }
            Console.WriteLine($"Total number of Times Dice role {Dice_Count}");


        }
        static void Main(string[] args)
        {
            SnakeAndLadder StartPlay = new SnakeAndLadder();
            StartPlay.PlayGame();
        }
    }
}