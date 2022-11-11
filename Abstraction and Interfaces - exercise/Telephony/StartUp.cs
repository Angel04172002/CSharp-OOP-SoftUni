using System;
using Telephony.Core;
using Telephony.IO;
using Telephony.IO.Interfaces;
using Telephony.Models;
using Telephony.Models.Interfaces;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IStationaryPhone statPhone = new StationaryPhone();
            ISmartPhone smartPhone = new SmartPhone();
            Engine engine = new Engine();
            engine.Run(reader, writer, statPhone, smartPhone);
        }
    }
}
