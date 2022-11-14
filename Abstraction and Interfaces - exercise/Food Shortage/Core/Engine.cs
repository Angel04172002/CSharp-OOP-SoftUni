using BorderControl.Core.Interfaces;
using BorderControl.IO;
using BorderControl.IO.Interfaces;
using BorderControl.Models;
using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Core
{
    public class Engine : IEngine
    {
        public void Run(IReader reader, IWriter writer)
        {
            List<ICreature> creatures = new List<ICreature>();

            int n = int.Parse(reader.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] tokens = reader.ReadLine().Split(' ');

                if(tokens.Length == 4)
                {
                    ICitizen citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
                    creatures.Add(citizen);
                }
                else if(tokens.Length == 3)
                {
                    IRebel rebel = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    creatures.Add(rebel);
                }
            }

            string command = reader.ReadLine();
            int totalFood = 0;

            while(command != "End")
            {
                if(creatures.Exists(p => p.Name == command))
                {
                    var creature = creatures.Find(p => p.Name == command);
                    totalFood += creature.BuyFood();
                }

                command = reader.ReadLine();
            }

            writer.WriteLine(totalFood.ToString());

            /*
            while(command != "End")
            {
                string[] tokens = command.Split(' ');
                string word = tokens[0];

                if(word == "Robot")
                {
                    IRobot robot = new Robot(tokens[1], tokens[2]);
                    //creatures.Add(robot);
                }
                else if(word == "Citizen")
                {
                    ICitizen citizen = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
                    creatures.Add(citizen);
                }
                else if(word == "Pet")
                {
                    IPet pet = new Pet(tokens[1], tokens[2]);
                    creatures.Add(pet);
                }

                command = reader.ReadLine();
            }

            string year = Console.ReadLine();

            foreach(var c in creatures)
            {
                if(c.BirthDate.EndsWith(year))
                {
                    writer.WriteLine(c.BirthDate);
                }
            }

            */
        }
    }
}
