using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumOfTimesDicePlayed
{
    class SnakeAndLadder
    {
        int START_POSITION = 0;
        const int NoPlay = 0;
        const int Ladder = 1;
        const int Snakle = 2;
        const int winning_position = 100;
        public void PlayGame()
        {
            int Dice_Count = 0;
            int Player = 0;
            while (Player < winning_position)
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
                        Player += Die;
                        Console.WriteLine("You got Ladder \n Player position = " + Player);
                        break;
                    case Snakle:
                        Player -= Die;
                        if (Player < START_POSITION)
                        {
                            Player = START_POSITION;
                        }
                        Console.WriteLine("You gotSnake \n player position = " + Player);

                        break;
                }

            }
            Console.WriteLine($"Position After every Dice role {Dice_Count}");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            SnakeAndLadder StartPlay = new SnakeAndLadder();
            StartPlay.PlayGame();

        }
    }
}