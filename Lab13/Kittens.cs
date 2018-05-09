using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Kittens : Player //This is the player that wil only choose rock ~ done
    {
        public Kittens()
        {
            Name = "Kittens";
        }
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock; //will always choose rock
        }
    }
}
