using System;

namespace UC_3_SnakeLadder
{
    class Program
    {
            public class SnakeAndLadder
            {
                public const int IsLadder = 1;
                public const int IsSnake = 2;


                static void Main(string[] args)
                {
                    int posOfPlayer = 0;
                    Random random = new Random();
                    int dice = random.Next(1, 7);
                    int option = random.Next(0, 3);
                    switch (option)
                    {
                        case IsLadder:
                            posOfPlayer += dice;
                            break;

                        case IsSnake:
                            posOfPlayer -= dice;
                            if (posOfPlayer < 0)
                                posOfPlayer = 0;
                            break;

                        default: break;
                    }
                    Console.WriteLine("The player is at position " + posOfPlayer + ",and rolled a die : " + dice);
                }

            }
        }
    }
