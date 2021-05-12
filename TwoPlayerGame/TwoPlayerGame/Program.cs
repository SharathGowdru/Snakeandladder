using System;

namespace SnakeAndLadderSimulator
{
    class Program
    {
        public class SnakeAndLadder
        {
            public const int IsLadder = 1;
            public const int IsSnake = 2;
            public const int IsPlayer1 = 0;
            public const int IsPlayer2 = 0;


            static void Main(string[] args)
            {
                int player = 0;
                int posOfPlayer1 = 0;
                int posOfPlayer2 = 0;
                int dieRollCount = 0;
                while (posOfPlayer1 < 100 && posOfPlayer2 < 100)
                {
                    dieRollCount++;
                    Random random = new Random();
                    int dice = random.Next(1, 7);
                    int option = random.Next(0, 3);
                    switch (option)
                    {
                        case IsLadder:
                            Console.WriteLine("Yeah! its a ladder,please step up");
                            if (player == IsPlayer1)
                                posOfPlayer1 += dice;
                            else
                                posOfPlayer2 += dice;
                            break;

                        case IsSnake:
                            Console.WriteLine("Opss! its a snake,you are going down");

                            if (player == IsPlayer2)
                            {
                                posOfPlayer1 -= dice;
                                if (posOfPlayer1 < 0)
                                    posOfPlayer1 = 0;
                            }
                            else
                            {
                                posOfPlayer2 -= dice;
                                if (posOfPlayer2 < 0)
                                    posOfPlayer2 = 0;
                            }
                            break;

                        default:
                            Console.WriteLine("You cannot move");
                            break;
                    }
                    if (posOfPlayer1 > 100 || posOfPlayer2 > 100)
                    {

                        Console.WriteLine("Cannot move ...please roll again");
                        if (player == IsPlayer1)
                            posOfPlayer1 -= dice;
                        else
                            posOfPlayer2 -= dice;


                    }
                    Console.WriteLine("The player 1 is at position " + posOfPlayer1 + ",and rolled a die : " + dice + "and the option is: " + option);
                    Console.WriteLine("The player 2 is at position " + posOfPlayer2 + ",and rolled a die : " + dice + "and the option is: " + option);
                    if (option == 1)
                    {
                        Console.WriteLine("Congrats! One more Chance.");
                    }
                    else if (player == IsPlayer1)
                    {
                        Console.WriteLine("Second Player turn");
                        player = 1;
                    }
                    else
                    {
                        Console.WriteLine("First Player Turn");
                        player = 0;
                    }
                }
                Console.WriteLine("The total no of time die was rolled to win is :" + dieRollCount);
                if (posOfPlayer1 == 100)
                {
                    Console.WriteLine("Player1 Wins");
                }
                else
                {
                    Console.WriteLine("Player2 Wins");
                }
            }
        }
    }
}