using System;

namespace SnakeAndLadderSimulator
{
    class Program
    {
        public class SnakeAndLadder
        {
            public const int IsLadder = 1;
            public const int IsSnake = 2;


            static void Main(string[] args)
            {
                int positionOfPlayer = 0;
                while (positionOfPlayer < 100)
                {
                    Random random = new Random();
                    int dice = random.Next(1, 7);
                    int option = random.Next(0, 3);
                    switch (option)
                    {
                        case IsLadder:
                            Console.WriteLine("its a ladder,please step up");
                            positionOfPlayer += dice;
                            break;

                        case IsSnake:
                            Console.WriteLine("its a snake,you are going down");
                            positionOfPlayer -= dice;
                            if (positionOfPlayer < 0)
                                positionOfPlayer = 0;
                            break;

                        default:
                            Console.WriteLine("You Cannot move");
                            break;
                    }
                    Console.WriteLine("The player is at position " + positionOfPlayer + ",and rolled a die : " + dice);
                }
            }
        }
    }
}
