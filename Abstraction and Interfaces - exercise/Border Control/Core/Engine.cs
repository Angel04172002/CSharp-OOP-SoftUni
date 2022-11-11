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

                if(tokens.Length == 2)
                {
                    IRobot robot = new Robot(tokens[0], tokens[1]);
                    creatures.Add(robot);
                }
                else if(tokens.Length == 3)
                {
                    ICitizen citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    creatures.Add(citizen);
                }

                command = reader.ReadLine();
            }

            string id = reader.ReadLine();

            foreach(var c in creatures)
            {
                if(c.Id.EndsWith(id))
                {
                    writer.WriteLine(c.Id);
                }
            }
        }
    }
}
