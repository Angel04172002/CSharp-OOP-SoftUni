namespace CommandPattern.Core
{
    using CommandPattern.Core.Contracts;
    using System;
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter interpreter;

        public Engine(ICommandInterpreter interpreter)
        {
            this.interpreter = interpreter; 
        }

        public void Run()
        {
            while(true)
            {
                string input = Console.ReadLine();
                string result = interpreter.Read(input);
                Console.WriteLine(result);
            }
        }
    }
}
