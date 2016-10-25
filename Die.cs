using System.Collections.Generic;
using System.Linq;

namespace Dice_problem
{
    class Die
    {
        public int[] Sides { get; set; }

        public Die()
        {
            Sides = new int[6];
        }

        public bool Equals(Die die)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var side in Sides)
            {
                if (!dict.ContainsKey(side))
                {
                    dict.Add(side, 1);
                }
                else
                {
                    dict[side]++;
                }
            }

            foreach (var side in die.Sides)
            {
                if (!dict.ContainsKey(side))
                {
                    dict.Add(side, -1);
                }
                else
                {
                    dict[side]--;
                }
            }

            return dict.All(x => x.Value == 0);
        }

        public override string ToString()
        {
            return $"[{string.Join(",", Sides)}]";
        }

        public Die Clone()
        {
            var die = new Die();

            for (var i = 0; i < Sides.Length; i++)
            {
                die.Sides[i] = Sides[i];
            }

            return die;
        }
    }
}
