using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    internal interface IStorage<T>
    {
        T Get(int index);
        void Add(T value);
    }
}
