using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy
{
    public class AddRemoveCollection<T> : IAddRemoveCollection<T>
    {
        private readonly IList<T> items;

        public AddRemoveCollection()
        {
            this.items = new List<T>(); 
        }
        public int Add(T element)
        {
            this.items.Insert(0, element);
            return 0;
        }

        public T Remove()
        {
            T last = this.items.LastOrDefault();

            this.items.RemoveAt(this.items.Count - 1);
            return last;
           
        }
    }
}
