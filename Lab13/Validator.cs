using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    public interface IValidator
    {
        bool IsValidPlayAgainst(string playAgainst);
        bool IsValidRoshambo(string roshambo);
    }


    public class Validator : IValidator //validates userenter yer or no

    {

        public bool IsValidPlayAgainst(string playAgainst)
        {
            return (playAgainst == "p" || playAgainst == "k");
        }

        public bool IsValidRoshambo(string roshambo)
        {
            return (roshambo == "r" || roshambo == "p" || roshambo == "s");
        }

    }
}
