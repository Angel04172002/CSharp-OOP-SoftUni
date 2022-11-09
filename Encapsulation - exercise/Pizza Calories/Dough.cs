using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private string flour;
        private string bakingTechnique;
        private double caloriesPerGram;

        public Dough(string flour, string bakingTechnique, double caloriesPerGram)
        {
            this.flour = flour;
            this.bakingTechnique = bakingTechnique;
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

                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                if (flour.ToLower() == "white" && bakingTechnique.ToLower() == "crispy")
                {
                    this.caloriesPerGram = (value * 2) * 1.5 * 0.9;
                }
                else if (flour.ToLower() == "white" && bakingTechnique.ToLower() == "chewy")
                {
                    this.caloriesPerGram = (value * 2) * 1.5 * 1.1;
                }
                else if (flour.ToLower() == "white" && bakingTechnique.ToLower() == "homemade")
                {
                    this.caloriesPerGram = (value * 2) * 1.5 * 1.0;
                }
                else if (flour.ToLower() == "wholegrain" && bakingTechnique.ToLower() == "crispy")
                {
                    this.caloriesPerGram = (value * 2) * 1.0 * 0.9;
                }
                else if (flour.ToLower() == "wholegrain" && bakingTechnique.ToLower() == "chewy")
                {
                    this.caloriesPerGram = (value * 2) * 1.0 * 1.1;
                }
                else if (flour.ToLower() == "wholegrain" && bakingTechnique.ToLower() == "homemade")
                {
                    this.caloriesPerGram = (value * 2) * 1.0 * 1.0;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }
    }
}
