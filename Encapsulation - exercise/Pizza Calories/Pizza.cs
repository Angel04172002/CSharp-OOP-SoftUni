using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;


        public Pizza()
        {
            this.toppings = new List<Topping>();
        }

        public Pizza(string name) : this()
        {
            this.Name = name;
        }

        public string Name
        {
            get
            { 
                return this.name;
            }
            private set
            {
                if(value == "" || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public Dough Dough
        {
            get { return this.dough; }
            set { this.dough = value; }
        }

        public Topping Toppings
        {
            get { return this.Toppings; }
            set
            {
                if (toppings.Count > 10 || toppings.Count < 0)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
            }
        }

        public int NumberOfToppings
        {
            get { return toppings.Count; }
        }

        

        public double TotalCalories
        {
            get
            {
                double totalCalories = 0;

                foreach(Topping topping in toppings)
                {
                    totalCalories += topping.CaloriesPerGram;
                }

                totalCalories += dough.CaloriesPerGram;

                return totalCalories;
            }
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} - {this.TotalCalories:f2} Calories.");
            return sb.ToString().TrimEnd();
        }
    }
}
