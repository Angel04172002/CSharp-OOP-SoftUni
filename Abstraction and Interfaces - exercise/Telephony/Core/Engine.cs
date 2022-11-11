using Telephony.Core.Interfaces;
using Telephony.IO.Interfaces;
using Telephony.Models.Interfaces;
using System;

namespace Telephony.Core
{
    public class Engine : IEngine
    {
        public void Run(IReader reader, IWriter writer, 
            IStationaryPhone statPhone, ISmartPhone smartPhone)
        {
            string[] phoneNumbers = reader.ReadLine()
                .Split(' ');
            string[] websites = reader.ReadLine()
                .Split(' ');

            foreach(var number in phoneNumbers)
            {
                if(number.Length == 7)
                {
                    writer.WriteLine(statPhone.Call(number));
                }
                else if(number.Length == 10)
                {
                    writer.WriteLine(smartPhone.Call(number));
                }
            }

            foreach(var url in websites)
            {
                Console.WriteLine(smartPhone.Browse(url));
            }
        }
    }
}
