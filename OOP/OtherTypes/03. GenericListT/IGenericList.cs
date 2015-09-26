using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace _03.GenericListT
{
    public interface IGenericList<T>
    {
        void Add(T element);
        T ElementAt(int position);
        void Remove(int position);
        void Insert(T element, int position);
        void Clear();
        int IndexOf(T element);
        bool Contains(T element);

    }
}