using System;
using System.Security;
using System.Text;

namespace _03.GenericListT
{
    [Version(0, 1)]
    public class GenericListT<T> : IGenericList<T> where T : IComparable 
    {
        private const byte defaultCapacity = 16;
        private int capacity;
        private T[] array;
        private int index;
        public GenericListT (int capacityOfArray = defaultCapacity)
        {
            this.Capacity = capacityOfArray;
            this.array = new T[this.Capacity];
            this.index = 0;
        }

        public int Capacity
        {
            get { return this.capacity; }
            set 
            {
                if (value < 0)
                {
                   throw new ArgumentNullException("Value cannot be less than 0!");
                }
                this.capacity = value;
            }
        }
        public void Add(T element)
        {
            DoubleUp(index);
            this.array[index] = element;
            this.index++;

        }

        public T ElementAt(int position)
        {
           ValidIndex(position);
            return this.array[position];
        }

        public void Remove(int position)
        {
            ValidIndex(position);
            for (int i = position ; i < this.array.Length - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
            
            this.index--;
      
        }

        public void Insert(T element, int position)
        {
            ValidIndex(position);
            DoubleUp(index);
            for (int i = index; i > position; i--)
            {
                this.array[i] = this.array[i - 1];
            }
            this.array[position] = element;
            this.index++;
            
        }

        public void Clear()
        {
            this.array = new T[this.Capacity];
            this.index = 0;
        }

        public int IndexOf(T element)
        {
            
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public T Min()
        {
            T min = this.array[0];
            for (int i = 0; i < index; i++)
            {
                if (this.array[i].CompareTo(min) == -1)
                {
                    min = this.array[i];
                }
            }
            return min;
        }
        public T Max()
        {
            T max = this.array[0];
            for (int i = 0; i < index; i++)
            {
                if (this.array[i].CompareTo(max) == 1)
                {
                    max = this.array[i];
                }
            }
            return max;
        }

        private void DoubleUp(int index)
        {
            if (index == this.array.Length)
            {
                T[] newArr = new T[this.array.Length * 2];
                Array.Copy(this.array,newArr, this.array.Length);
                this.array = newArr;
            }
        }

        
        private void ValidIndex(int position)
        {
            if (position >= this.array.Length || position < 0)
            {
                throw new ArgumentOutOfRangeException(string.Format("You can only access index from 0 to {0}", array.Length));
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < index; i++)
            {
                result.Append(this.array[i]);
                if (i != index - 1)
                {
                    result.Append(", ");
                }
            }
            return result.ToString();
        }
    }
}