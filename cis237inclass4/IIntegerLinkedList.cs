using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    interface IIntegerLinkedList
    {
        void AddMaintainSort(int integerData);
        int RemoveMaintainSort(int removeData);

        void Display();

        bool IsEmpty { get; }

        int Size { get; }
    }
}
