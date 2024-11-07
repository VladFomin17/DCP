using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Repository<T> where T : class
    {
        List<T> Items;
        public Repository() 
        {
            Items = new List<T>();
        }
        public void AddItem(T item) => Items.Add(item);

        // Метод для получения элемента по индексу
        public T GetItem(int index) => Items[index];

        // Метод для получения количества элементов
        public int Count => Items.Count;

    }
}
