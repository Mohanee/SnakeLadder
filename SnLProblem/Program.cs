using System;

namespace SnakeLadderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Single player Snake and Ladder game");
            int start_Pos = 0;
            Random rn = new Random();
            int present_Pos = start_Pos;
            Console.WriteLine("Your present position is " + present_Pos);

            int next_Pos = present_Pos + rn.Next(1, 7);
            Console.WriteLine("DICE ROLLED");
            Console.WriteLine("Now you are at position " + next_Pos);

        }
    }
}

