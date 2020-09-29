using System;
using System.Collections.Generic;
using System.Text;

namespace Gruempelitunier
{
    abstract class Game
    {
        public abstract string Date { get; set; } //string weil Time nicht geht. 
        public abstract int GoalT1 { get; set; }
        public abstract int GoalT2 { get; set; }
    }
}
