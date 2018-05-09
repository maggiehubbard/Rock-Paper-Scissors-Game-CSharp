using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class RoshamboApp
    {
        

        static void Main(string[] args)
        {
            //variables
            
            string playAgainst;
            Player opp;
            Player user;
            int oppWins = 0, userWins = 0, draws = 0;
            IValidator validator = new Validator();


            Console.WriteLine("WELCOME TO ROCK PAPER SCISSORS APP");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

            Console.Write("Enter your name: ");

            user = new ThirdPlayer(Console.ReadLine()); //This reads the literal user types in to save as the name of the 3rd player


            Console.Write("\nWould you like to play against Puppies or Kittens? (p/k)");
            playAgainst = Console.ReadLine().ToLower();
                while (!validator.IsValidPlayAgainst(playAgainst))
                {
                    Console.WriteLine("\nError: That was an invalid team name. Please try again.");
                    Console.Write("Puppies or Kittens? Enter (p or k)");
                    playAgainst = Console.ReadLine().ToLower();
                } 
            if (playAgainst == "p")
            {
                opp = new Puppies();
            } else
            {
                opp = new Kittens();
            }
            string again = "y";
            while (again != "n")
            {
                Roshambo userChoice = user.GenerateRoshambo();
                Roshambo oppChoice = opp.GenerateRoshambo();
                
                
            
                if (oppChoice == userChoice)
                {
                    Console.WriteLine("DRAW!");
                    draws++;
                }else if (oppChoice == Roshambo.Paper && userChoice == Roshambo.Rock)
                {
                    Console.WriteLine($"{opp.Name} WINS!");
                    oppWins++;
                }
                else if (oppChoice == Roshambo.Rock && userChoice == Roshambo.Scissors)
                {
                    Console.WriteLine($"{opp.Name} WINS!");
                    oppWins++;
                }
                else if (oppChoice == Roshambo.Scissors && userChoice == Roshambo.Paper)
                {
                    Console.WriteLine($"{opp.Name} WINS!");
                    oppWins++;
                }
                else if (userChoice == Roshambo.Rock && oppChoice == Roshambo.Scissors)
                {
                    Console.WriteLine($"{user.Name} WINS!");
                    userWins++;
                }
                else if (userChoice == Roshambo.Paper && oppChoice == Roshambo.Rock)
                {
                    Console.WriteLine($"{user.Name} WINS!");
                    userWins++;
                }
                else if (userChoice == Roshambo.Scissors && oppChoice == Roshambo.Paper)
                {
                    Console.WriteLine($"{user.Name} WINS!");
                    userWins++;
                }

                //Displays Scores & player choices
                Console.WriteLine("\nSCORES");
                Console.WriteLine("===========");
                Console.WriteLine($"{user.Name} chose {userChoice}");
                Console.WriteLine($"{opp.Name} chose {oppChoice}");               
                Console.WriteLine($"{user.Name} Wins: {userWins}");
                Console.WriteLine($"{opp.Name} Wins: {oppWins}");
                Console.WriteLine($"Draw Games: {draws}");

                Console.WriteLine("Would you like to play again?(y/n)");
                again = Console.ReadLine().ToLower();
                while (again != "y" && again != "n")
                {
                    Console.WriteLine("Error: That input was not valid. Please try again.");
                    Console.WriteLine("Would you like to play again?(y/n)");
                    again = Console.ReadLine().ToLower();
                }

                
            }
            int x = (int)Roshambo.Rock;
            Console.WriteLine(x);

            //Pause before exit
            Console.WriteLine("Press any key to exit. .");
            Console.ReadKey();
        }
    }
}
