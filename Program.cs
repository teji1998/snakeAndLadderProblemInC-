using System;

namespace snakeAndLadderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and ladder problem!");

            //constants
            const int noPlayOption = 0;
            const int ladderOption = 1;
            const int snakeOption = 2;
            const int playerOne = 1;
            //variable
            int positionOne = 0;
            int diceRollCount = 0;
            //while loop to check the condition of position is greater than zero
            while (positionOne < 100)
            {
                Random random = new Random();
                int dieRoll = random.Next(1, 7);
                diceRollCount++;
                int options = random.Next(0, 3);
                Console.WriteLine("Position: " + positionOne);
                switch (options)
                {
                    case noPlayOption:
                        Console.WriteLine("Position: " + positionOne);
                        break;
                    case ladderOption:
                        if (positionOne + dieRoll <= 100)
                        {
                            positionOne = positionOne + dieRoll;
                        }
                        Console.WriteLine("Position: " + positionOne);
                        break;
                    case snakeOption:
                        positionOne = positionOne - dieRoll;
                        if (positionOne < 0)
                        {
                            positionOne = 0;
                        }
                        Console.WriteLine("Position: " + positionOne);
                        break;
                }
            }
            Console.WriteLine("Player Wins with Die Roll :" + diceRollCount);

        }
    }
}
