using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();
            stackOfStrings.Push("1");
            stackOfStrings.Push("2");
            stackOfStrings.Push("3");

            List<string> range = new List<string>() { "10", "20", "30"};
            stackOfStrings.AddRange(range);

            Console.WriteLine(stackOfStrings.IsEmpty());

        }
    }
}
