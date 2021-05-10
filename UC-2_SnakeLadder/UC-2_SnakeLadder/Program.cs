using System;

namespace UC_2_SnakeLadder
{
    class Program
    {
        public int roll_Dice()
        {
            Random random = new Random();
            int p_1 = random.Next(1, 7);
            return p_1;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake and Ladder Program");
            int p_1 = 0;
            Console.WriteLine("\n" + "The Initial Position of Player is : " + p_1);
            Program sal = new Program();
            int Roll_Dice_value = sal.roll_Dice();
            Console.WriteLine("\n" + "Roll_Dice Value is : " + Roll_Dice_value);
        }
    }
}
