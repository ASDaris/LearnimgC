﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FU
{
    public class MyStack<T> : IEnumerable<T> //обобщенный класс, generic, который навязывает строгую типизацию клиенту
    {
        private T[] _items;

        public int Count { get; private set; }
        public int Capacity
        {
            get
            {
                return _items.Length;
            }
        }

        public MyStack()
        {
            const int defaultCapacity = 4;
            _items = new T[defaultCapacity];
        }
        public MyStack(int capacity)
        {
            _items = new T[capacity];
        }

        public void Push(T item)
        {
            if(_items.Length == Count)
            {
                T[] largeArray = new T[Count * 2];
                Array.Copy(_items, largeArray, Count);

                _items = largeArray;
            }
            _items[Count++] = item;
        }

        public void Pop()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException();
            }

            _items[--Count] = default; //default(T)
        }

        public object Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            return _items [Count - 1];
        }

        //public IEnumerator<T> GetEnumerator()
        //{
        //    return new StackEnumerator<T>(_items, Count);
        //}
        public IEnumerator<T> GetEnumerator()
        {
            for(int i = Count - 1; i >= 0; i--)
            {
                yield return _items [i]; //генерирует почти тоже что и класс StackEnumerator<T>, ленивое вычисление, вернет столько элементов сколько запросит внешний цикл, lazy evaluation
            }
        }

        IEnumerator IEnumerable.GetEnumerator() //эксплицитное (явное) инплиментация интерфейса, явная реализация GetEnumerator определенного в обычном IEnumerable
        {
            return GetEnumerator();
        }
    }

    public class StackEnumerator<T> : IEnumerator<T>
    {
        private readonly T[] array;
        private readonly int count;
        private int position;
        public StackEnumerator(T[] array, int count)
        {
            this.array = array;
            this.count = count;

            position = count;
        }
        public T Current
        {
            get
            {
                return array [position];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            position--;
            return position >= 0;
        }

        public void Reset()
        {
            position = count;
        }
    }
}