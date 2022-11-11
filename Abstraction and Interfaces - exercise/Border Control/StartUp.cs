using BorderControl.Core;
using BorderControl.IO;
using BorderControl.IO.Interfaces;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            Engine engine = new Engine();
            engine.Run(reader, writer);
        }
    }
}
