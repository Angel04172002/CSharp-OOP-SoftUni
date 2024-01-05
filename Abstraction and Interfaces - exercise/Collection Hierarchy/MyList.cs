using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy
{
    public class MyList<T> : IMyList<T>
    {
        private readonly IList<T> items;

        public MyList()
        {
            this.items = new List<T>();
        }

        public int Used
            => this.items.Count;

        public int Add(T element)
        {
            this.items.Insert(0, element);
            return 0;
        }

        public T Remove()
        {
            T first = this.items.FirstOrDefault();

            this.items.RemoveAt(0);
            return first;
        }
    }
}
