
using System;

namespace SnakeLadderProblem
{
    class Program
    {

        public static int Game(int present_Pos)
        {
            Random rn = new Random();
            bool val = true;

            int next_Pos = 0;
            Console.WriteLine("Your Present Position is " + present_Pos);
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
                if (x2 == 6)
                {
                    next_Pos = Game(next_Pos);
                }
                if (next_Pos >= 100)
                {
                    val = false;
                }
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
            present_Pos = next_Pos;
            if (present_Pos < 100)
            {
                Console.WriteLine("So you are at " + present_Pos + "\n");

            }

            if (val == false)
            {
                Console.WriteLine("Congrtulations!! You've reached final destination!");
                System.Environment.Exit(0);
            }

            return present_Pos;

        }

        static int DiceRoll()
        {
            Random rn = new Random();
            int diceNum = rn.Next(1, 7);
            return diceNum;
        }

        static void Main(string[] args)
        {
            Random rn = new Random();
            Console.WriteLine("Hello, Welcome to Single player Snake and Ladder game");
            int P1start_Pos = 0; int P1present_Pos = P1start_Pos;
            int P2start_Pos = 0; int P2present_Pos = P2start_Pos;

            int first_Turn = rn.Next(0, 2);
            //bool flag = 0;

            if (first_Turn == 0)
            {
                Console.WriteLine("Turn of Player A");
                P1present_Pos = Game(P1present_Pos);

                while (P2present_Pos < 100 && P1present_Pos < 100)
                {
                    Console.WriteLine("Turn of Player B");
                    P2present_Pos = Game(P2present_Pos);
                    Console.WriteLine("Turn of Player A");
                    P1present_Pos = Game(P1present_Pos);
                }
            }
            else
            {
                Console.WriteLine("Turn of Player B");
                P2present_Pos = Game(P2present_Pos);

                while (P2present_Pos < 100 && P1present_Pos < 100)
                {
                    Console.WriteLine("Turn of Player A");
                    P1present_Pos = Game(P1present_Pos);
                    Console.WriteLine("Turn of Player B");
                    P2present_Pos = Game(P2present_Pos);
                }
            }


        }

    }



}
