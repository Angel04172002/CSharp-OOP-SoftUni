using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        public string Name { get; private set; } 
        public string FavouriteFood { get; private set; }

        protected Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public abstract string ExplainSelf();
    }
}
