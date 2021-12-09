﻿namespace Bakery.Models.BakedFoods
{
    public class Cake : BakedFood
    {
        private const int InitialPortion = 245;

        public Cake(string name, decimal price)
            : base(name, InitialPortion, price)
        {
        }
    }
}