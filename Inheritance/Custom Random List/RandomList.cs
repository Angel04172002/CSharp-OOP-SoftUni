using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            var rng = new Random();
            var index = rng.Next(0, this.Count);
            var element = this[index];
            this.RemoveAt(index);

            return element;
        }
    }
}
