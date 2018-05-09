using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    abstract class Player
    {  
        //FIELDS
        private string name;
        private Roshambo choice;

        //PROPERTIES
        public string Name { get => name; set => name = value; }
        private Roshambo Choice { get => choice; set => choice = value; }

        //METHODS
        public abstract Roshambo GenerateRoshambo(); //abstract here so it doesn't need a body until inherited in other classes
        
    }
}
