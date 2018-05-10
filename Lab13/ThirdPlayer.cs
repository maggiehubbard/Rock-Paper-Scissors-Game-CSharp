using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class ThirdPlayer : Player //This is the player that the user will use
    {

        //construstor to access thirdplay.name
        public ThirdPlayer(string name)
        {
            this.Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            IValidator validator = new Validator();
            
            Console.WriteLine("Rock, Paper or Scissors? (r/p/s): ");
           
            string input = Console.ReadLine().ToLower();

            while (!validator.IsValidRoshambo(input))
            {
              Console.WriteLine("Error that was not a valid option. Please try again.");
              Console.WriteLine("Rock, Paper or Scissors? (r/p/s): ");
              input = Console.ReadLine().ToLower();
            }
            if (input == "r")
            {
                return Roshambo.Rock;
            }
            else if (input == "p")
            {
                return Roshambo.Paper;
            }
            else
            {
                return Roshambo.Scissors;
            }
            
        }
    }
}
