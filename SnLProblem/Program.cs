using System;

namespace SnakeLadderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Single player Snake and Ladder game");
            int start_Pos = 0, next_Pos = 0;
            Random rn = new Random();
            int present_Pos = start_Pos;



            Console.WriteLine("FIRST TURN-----");
            Console.WriteLine("Your Present Psition is " + present_Pos);
            int x1 = DiceRoll();
            Console.WriteLine("You got Dice number " + x1);
            next_Pos = present_Pos + x1;
            Console.WriteLine("Your present position is " + next_Pos);
            present_Pos = next_Pos;

            Console.WriteLine("SECOND TURN------");
            Console.WriteLine("Your Present Psition is " + present_Pos);
            int playRN = rn.Next(0, 3);
            int x2 = DiceRoll();
            Console.WriteLine("You got dice number " + x2);
            if (playRN == 0)
            {
                Console.WriteLine("And You got No Play option");
                next_Pos = present_Pos;
            }
            if (playRN == 1)
            {
                Console.WriteLine("And You got Ladder option");
                next_Pos = present_Pos + x2;
            }
            if (playRN == 2)
            {
                Console.WriteLine("And You got Snake Option");
                if (present_Pos - x2 <= 0)
                {
                    next_Pos = 0;
                }
                else
                {
                    next_Pos = present_Pos - x2;
                }
            }
            Console.WriteLine("So, now you are at position " + next_Pos);

        }

        static int DiceRoll()
        {
            Random rn = new Random();
            int diceNum = rn.Next(1, 7);
            return diceNum;
        }
    }
}
