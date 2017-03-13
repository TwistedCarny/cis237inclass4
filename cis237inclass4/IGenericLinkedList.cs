using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    interface IGenericLinkedList<T>
    {
        void AddToFront(T data);
        void AddToBack(T data);
        T RemoveFromFront();
        T RemoveFromBack();

        void Display();

        bool IsEmpty { get; }

        int Size { get; }
    }
}
