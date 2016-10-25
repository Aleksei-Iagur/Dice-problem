namespace Dice_problem
{
    class Probabilities
    {
        internal int[] Values { get; set; }

        public void Reset()
        {
            Values = new[] { 1, 2, 3, 4, 5, 6, 5, 4, 3, 2, 1 };
        }
    }
}
