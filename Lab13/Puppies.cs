using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{

    class Puppies : Player //this player has a random chance of answering either (rock-0,paper-1, or scissors-2) ~ done
    {
        public Puppies()
        {
            Name = "Puppies";
        }

        Random r = new Random();
        public override Roshambo GenerateRoshambo()
        {
            if ((r.Next(0, 2)) == 0)
            {
                return Roshambo.Rock;
            }
            else if ((r.Next(0, 2)) == 1)
            {
                return Roshambo.Paper;
            }
            else
                return Roshambo.Scissors;
        }
    }
}
