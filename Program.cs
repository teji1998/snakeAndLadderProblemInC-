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

            //variables
            int positionOne = 0;

            //using while loop 
            while (positionOne < 100)
            {
                Random random = new Random();
                int dieRoll = random.Next(1, 7);//values between 1 and 7
                int options = random.Next(0, 3);//values between 0 and 3

                //using switch case
                switch (options)
                {
                    case noPlayOption:
                        positionOne = positionOne + 0;
                        break;
                    case ladderOption:
                        positionOne = positionOne + dieRoll;
                        break;
                    case snakeOption:
                        positionOne = positionOne - dieRoll;
                        if (positionOne < 0)
                        {
                            positionOne = 0;
                        }
                        break;
                }
            }
            Console.WriteLine("Player Wins with Position :" + positionOne);

        }
    }
}
