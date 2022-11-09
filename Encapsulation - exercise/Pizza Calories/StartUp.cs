
using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string command = Console.ReadLine();
                string[] pizzaTokens = command.Split(' ');
                Pizza pizza = new Pizza(pizzaTokens[1]);


                command = Console.ReadLine();

                while (command != "END")
                {
                    string[] tokens = command.Split(' ');

                    switch (tokens[0])
                    {
                            case "Dough":
                            {
                                Dough dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
                                pizza.Dough = dough;
                            }
                            break;

                            case "Topping":
                            {
                                Topping topping = new Topping(tokens[1], double.Parse(tokens[2]));
                                pizza.AddTopping(topping);
                                pizza.Toppings = topping;
                            }
                            break;
                    }

                    command = Console.ReadLine();
                }

                Console.WriteLine(pizza);
            }
            catch(ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
