using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy
{
    public class AddCollection<T> : IAddCollection<T>
    {
        private readonly ICollection<T> items;

        public AddCollection()
        {
            this.items = new List<T>(); 
        }

        public int Add(T element)
        {
            this.items.Add(element);

            return this.items.Count - 1;
        }
    }
}
