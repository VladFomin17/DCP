using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    internal class ListStorage<T> : IStorage<T>
    {
        private List<T> Storage;
        public ListStorage() 
        {
            Storage = new List<T>();
        }

        public void Add(T item)
        {
            Storage.Add(item);
        }

        public T Get(int index)
        {
            return Storage[index];
        }
        
    }
}
