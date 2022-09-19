using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FU
{
    public interface IBaseCollection
    {
        void Add(object obj);
        void Remove(object obj);
        //void Clear(); при обновлении интерфейса, всем унаследовавшим потребуется предоставить реализацию метода, breaking change
        
    }
    //абстрактные классы более расширяемы разработчиком, а интерфейсы более расширяемы клиентом

    public static class BaseCollectionExt
    {
        public static void AddRange(this IBaseCollection collection, IEnumerable<object> objects)
        {
            foreach(var item in objects)
            {
                collection.Add(item);
            }
        }
    }
    public class BaseList : IBaseCollection //нельзя унаследовать много классов, можно наследовать множество интерфейсов , в интерфейсах нельзя использовать конструктуры
    {
        private object[] items;
        private int count = 0;

        public BaseList(int initialCapacity)
        {
            items = new object[initialCapacity];
        }
        public void Add(object obj)
        {
            items[count] = obj;
            count++;
        }

        public void Remove(object obj)
        {
            items[count] = null;
            count--;
        }
    }
}
