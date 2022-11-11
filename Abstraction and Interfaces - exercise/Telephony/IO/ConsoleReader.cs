using Telephony.IO.Interfaces;
using System;

namespace Telephony.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
