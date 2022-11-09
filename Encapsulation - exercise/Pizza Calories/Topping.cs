using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private double caloriesPerGram;
        private string type;

        public Topping(string type, double caloriesPerGram)
        {
            this.type = type;
            this.CaloriesPerGram = caloriesPerGram;
        }

        public double CaloriesPerGram
        {
            get
            {
                return this.caloriesPerGram;
            }
            private set
            {
                if(value < 0 || value > 50)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                }

                if(type.ToLower() == "meat")
                {
                    this.caloriesPerGram = (2 * value) * 1.2;
                }
                else if(type.ToLower() == "veggies")
                {
                    this.caloriesPerGram = (2 * value) * 0.8;
                }
                else if (type.ToLower() == "cheese")
                {
                    this.caloriesPerGram = (2 * value) * 1.1;
                }
                else if (type.ToLower() == "sauce")
                {
                    this.caloriesPerGram = (2 * value) * 0.9;
                }
                else
                {
                    throw new ArgumentException($"Cannot place {this.type} on top of your pizza.");
                }
                
            }
        }
    }
}
