using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Core.Interfaces;
using Vehicles.IO.Interfaces;
using Vehicles.Models.Interfaces;
using Vehicles.Factories;
using Vehicles.Factories.Interfaces;
using Vehicles.Exceptions;
using Vehicles.Models;
using System.Linq;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private IVehicleFactory vehicleFactory;

        private ICollection<IVehicle> vehicles;

        private Engine()
        {
            vehicles = new HashSet<IVehicle>();
        }
        public Engine(IReader reader, IWriter writer, IVehicleFactory vehicleFactory) : this()
        {
            this.reader = reader;
            this.writer = writer;
            this.vehicleFactory = vehicleFactory;
        }

        public void Run()
        {
             try
             {

                 string[] carArgs = reader.ReadLine()
                                   .Split(' ');
                 string[] truckArgs = reader.ReadLine()
                                   .Split(' ');
                 string[] busArgs = reader.ReadLine()
                    .Split(' ');

                 this.CreateVehicle(carArgs);
                 this.CreateVehicle(truckArgs);
                 this.CreateVehicle(busArgs);
             }
             catch(ArgumentException ae)
             {
                 writer.WriteLine(ae.Message);
             }


            int n = int.Parse(reader.ReadLine());
            
            

            for (int i = 0; i < n; i++)
            {
                    try
                    {

                        string[] args = reader.ReadLine().Split(' ');
                        string cmdType = args[0];
                        string vehicle = args[1];
                        double arg = double.Parse(args[2]);

                        if (cmdType == "Drive")
                        {
                            writer.WriteLine(this.vehicles.FirstOrDefault(v => v.GetType().Name == vehicle).Drive(arg));
                        }
                        else if(cmdType == "DriveEmpty")
                        {
                            writer.WriteLine(this.vehicles.FirstOrDefault(v => v.GetType().Name == vehicle).Drive(arg,true));
                        }
                        else if (cmdType == "Refuel")
                        {
                            this.vehicles.FirstOrDefault(v => v.GetType().Name == vehicle).Refuel(arg);
                        }
                    }
                    catch(InsufficientFuelException ife)
                    {
                        writer.WriteLine(ife.Message);
                    }
            }

            foreach (var vehicle in vehicles)
            {
                writer.WriteLine($"{vehicle.GetType().Name}: {vehicle.FuelQuantity:f2}");
            }
        }
 
        private void CreateVehicle(string[] vehicleArgs)
        {
            string typeOfVehicle = vehicleArgs[0];
            double fuelQuantity = double.Parse(vehicleArgs[1]);
            double litersPerKm = double.Parse(vehicleArgs[2]);
            double tankCapacity = double.Parse(vehicleArgs[3]);

            this.vehicles.Add(this.vehicleFactory.BuildVehicleUsingFactory(typeOfVehicle, fuelQuantity, litersPerKm, tankCapacity));
        }
    }
}
