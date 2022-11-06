namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string line1 = Console.ReadLine();
                string line2 = Console.ReadLine();
                string[] tokens1 = line1.Split(';', StringSplitOptions.RemoveEmptyEntries);
                List<Person> people = new List<Person>();
                List<Product> products = new List<Product>();

                for (int i = 0; i < tokens1.Length; i++)
                {
                    string[] tokensSplitByEqualSign = tokens1[i].Split('=');
                    string name = tokensSplitByEqualSign[0];
                    int money = int.Parse(tokensSplitByEqualSign[1]);

                    Person person = new Person(name, money);
                    people.Add(person);
                }

                string[] tokens2 = line2.Split(';', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < tokens2.Length; i++)
                {
                    string[] tokensSplitByEqualSign = tokens2[i].Split('=');
                    string nameOfProduct = tokensSplitByEqualSign[0];
                    int moneyOfProduct = int.Parse(tokensSplitByEqualSign[1]);

                    Product product = new Product(nameOfProduct, moneyOfProduct);
                    products.Add(product);
                }

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] tokens = command.Split(' ');
                    string name = tokens[0];
                    string product = tokens[1];

                    int indexPerson = people.FindIndex(p => p.Name == name);
                    int indexProduct = products.FindIndex(p => p.Name == product);

                    if (people[indexPerson].Money - products[indexProduct].Cost >= 0)
                    {
                        Console.WriteLine($"{people[indexPerson].Name} bought {products[indexProduct].Name}");
                        people[indexPerson].Products.Add(products[indexProduct]);
                        people[indexPerson].Money -= products[indexProduct].Cost;
                    }
                    else
                    {
                        Console.WriteLine($"{people[indexPerson].Name} can't afford {products[indexProduct].Name}");
                    }

                    command = Console.ReadLine();
                }

                for(int i = 0; i < people.Count; i++)
                {
                    Console.Write($"{people[i].Name} - ");

                    if (people[i].Products.Count == 0)
                    {
                        Console.Write("Nothing bought");
                    }

                    for(int k = 0; k < people[i].Products.Count; k++)
                    {
                        if (k != people[i].Products.Count - 1)
                        {
                            Console.Write($"{people[i].Products[k].Name}, ");
                        }
                        else
                        {
                            Console.Write($"{people[i].Products[k].Name}");
                        }
                    }

                    Console.WriteLine();
                }
            }
            catch(ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}
