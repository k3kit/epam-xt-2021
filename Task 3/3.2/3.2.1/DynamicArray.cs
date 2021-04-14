using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._1
{
    class DynamicArray<T> : IEnumerable, IEnumerable<T>
    {
        private T[] array;
        public int Length;
        public int Capacity
        {
            get => array.Length;
            set
            {
                if (value < Capacity)
                {
                    throw new ArgumentOutOfRangeException();
                }

                else if (value == Capacity)
                {
                    return;
                }

                else if (value > Capacity)
                {
                    T[] newArray = new T[value];
                    for(int i = 0; i < Capacity; i++)
                    {
                        newArray[i] = array[i];
                    }

                    array = newArray;
                    Capacity = value;
                }
            }
        }


        public DynamicArray()
        {
            array = new T[8];
            Length = 0;
            Capacity = 8;
        }


        public DynamicArray(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                array = new T[capacity];
                Length = 0;
                Capacity = capacity;
            }
        }


        public DynamicArray(IEnumerable<T> collection)
        {
            array = new T[collection.Count()];
            Length = 0;
            Capacity = collection.Count()+1;

            foreach (var item in collection)
            {
                array[Length] = item;
                Length++;
            }
        }


        public void Add(T item)
		{
			if (Length + 1 > Capacity)
			{
				int newCapacity = Capacity * 2;
				T[] tempArray = new T[newCapacity];

				array.CopyTo(tempArray, 0);
				array = tempArray;
			}

			array[Length] = item;
			Length++;
		}

        public void AddRange(IEnumerable<T> collection)
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                if (Length + collection.Count() > Capacity)
                {
                    int newCapacity = Capacity * 2 + collection.Count();
                    T[] tempArray = new T[newCapacity];

                    array.CopyTo(tempArray, 0);
                    array = tempArray;
                }

                int pos = Length;
                foreach (var item in collection)
                {
                    array[pos] = item;
                    pos++;
                    Length++;
                }
            }
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < Length; i++)
            {
                if (Equals(item, array[i]))
                {
                    for (int j = i; j < Length - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }

                    array[Length - 1] = default;
                    Length--;
                    return true;
                }
            }

            return false;
        }

        public bool Insert(int index, T item)
        {
            if (index < 0 || index >= Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (Length == Capacity)
            {
                int newCapacity = Capacity * 2;
                T[] tempArray = new T[newCapacity];

                array.CopyTo(tempArray, 0);
                array = tempArray;
            }

            for (int i = Length - 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }

            array[index] = item;
            Length++;

            return true;
        }


        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)array).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }


        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < Length)
                {
                    return array[index];

                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            set
            {
                if (index >= 0 && index < Length)
                {
                    array[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
