namespace CommandPattern.Utilities
{
    using CommandPattern.Core.Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] tokens = args.Split(' ');
            string commandName = tokens[0];

            string[] parameters = tokens
                .Skip(1)
                .ToArray();

            var currentAssembly = Assembly.GetEntryAssembly();

            var currentType = currentAssembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == $"{commandName}Command");

            if (currentType == null)
            {
                throw new InvalidOperationException("Invalid type");
            }


            var method = currentType
                .GetMethods()
                .FirstOrDefault(m => m.Name == "Execute");

            if (method == null)
            {
                throw new InvalidOperationException("Invalid method");
            }

            var obj = Activator.CreateInstance(currentType);

            var result = (string)method.Invoke(obj, new object[] { parameters });

            return result;
        }
    }
}
