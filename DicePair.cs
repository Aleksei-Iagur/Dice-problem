using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_problem
{
    struct DicePair
    {
        public Die Die1 { get; set; }
        public Die Die2 { get; set; }

        public bool Contains(Die die)
        {
            return Die1.Equals(die) || Die2.Equals(die);
        }
    }
}
