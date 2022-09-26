using System;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            Console.Title = "ROCK PAPER SCISSORS";

            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";
            
            int playerWins = 0;
            int computerWins = 0;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("       ╔═══════════════════╗\r\n       *ROCK PAPER SCISSORS*\r\n       ╚═══════════════════╝\r\n");
            
            while (true)
            {

                Console.WriteLine("Choose [R]ock, [P]aper or [S]cissors: ");

                string playerMove = Console.ReadLine().ToLower();

                if (playerMove == "r" || playerMove == "rock")
                {
                    Console.WriteLine("You chose Rock!");
                    playerMove = "Rock";
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    Console.WriteLine("You chose Paper!");
                    playerMove = "Paper";
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    Console.WriteLine("You chose Scissors!");
                    playerMove = "Scissors";
                }
                else
                {
                    Console.WriteLine("Invalid input! Try again...");
                    return;
                }

                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);

                string computerMove = "";

                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = "Rock";
                        break;
                    case 2:
                        computerMove = "Paper";
                        break;
                    case 3:
                        computerMove = "Scissors";
                        break;
                }

                Console.WriteLine($"The computer chose {computerMove}.");

                if (playerMove == "Rock" && computerMove == "Scissors" ||
                    playerMove == "Paper" && computerMove == "Rock" ||
                    playerMove == "Scissors" && computerMove == "Paper")
                {
                    Console.Beep();
                    Console.WriteLine("═════════════════════════════════════");
                    Console.WriteLine("You win!");
                    playerWins++;
                    Console.WriteLine($"The result is:\r\nYou:{playerWins} VS Computer:{computerWins}");
                    Console.WriteLine("═════════════════════════════════════\r\n");
                    Console.WriteLine();
                }
                else if (playerMove == "Rock" && computerMove == "Paper" ||
                    playerMove == "Paper" && computerMove == "Scissors" ||
                    playerMove == "Scissors" && computerMove == "Rock")
                {
                    Console.Beep();
                    Console.WriteLine("═════════════════════════════════════");
                    Console.WriteLine("You lose!");
                    computerWins++;
                    Console.WriteLine($"The result is:\r\nYou:{playerWins} VS Computer:{computerWins}");
                    Console.WriteLine("═════════════════════════════════════\r\n");
                    Console.WriteLine();
                }
                else
                {
                    Console.Beep();
                    Console.WriteLine("═════════════════════════════════════");
                    Console.WriteLine("It's a draw!");
                    Console.WriteLine($"The result is:\r\nYou:{playerWins} VS Computer:{computerWins}");
                    Console.WriteLine("═════════════════════════════════════\r\n");
                    Console.WriteLine();
                }

            }
        }
    }
}
