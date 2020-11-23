using System;

namespace snakeAndLadderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and ladder problem!");

            //constants
            const int playerOne = 1;
            int positionOne = 0;

            Random random = new Random();

            //returns a random no between 1 and 7
            int dieRoll = random.Next(1, 7); 

            Console.WriteLine("The number on die when rolled is : " + dieRoll);
        }
    }
}
