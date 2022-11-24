using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{   public interface IList<T>
    {
        void Add(T item);
        
        void Delete(T item);
        void Search(T item);
        void ShowCollection();
    }

    public class MyCollection<T> : IList<T>
    {
        private ArrayList items = new ArrayList();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Delete(T item)
        {
            items.Remove(item);
        }
        public void Search(T item)
        {
            if (items.Contains(item))
            {
                Console.WriteLine($"{item} найден");
            }
            else
            {
                Console.WriteLine($"{item} не найден");
            }
        }
        public void ShowCollection()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
