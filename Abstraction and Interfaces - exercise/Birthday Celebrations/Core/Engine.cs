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

            string command = reader.ReadLine();

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
        }
    }
}
