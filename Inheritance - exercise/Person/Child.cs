using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
            if(Age > 15)
            {
                Age = 15;
            }
        }
    }
}
