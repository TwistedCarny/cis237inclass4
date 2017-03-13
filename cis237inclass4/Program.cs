using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    class Program
    {
        static void Main(string[] args)
        {
            IIntegerLinkedList linkedList = new IntegerLinkedList();

            linkedList.AddMaintainSort(5);
            linkedList.AddMaintainSort(3);
            linkedList.AddMaintainSort(4);
            linkedList.AddMaintainSort(2);
            linkedList.AddMaintainSort(1);

            linkedList.Display();

            linkedList.RemoveMaintainSort(3);
            linkedList.RemoveMaintainSort(1);

            linkedList.AddToFront(15);

            linkedList.Display();

            Console.WriteLine("GENERIC BELOW");

            IGenericLinkedList<string> genericLinkedList = new GenericLinkedList<string>();

            IGenericLinkedList<double> doubleLinkedList = new GenericLinkedList<double>();

            genericLinkedList.AddToFront("1");
            genericLinkedList.AddToFront("2");
            genericLinkedList.AddToFront("3");
            genericLinkedList.AddToBack("4");
            genericLinkedList.AddToBack("5");
            genericLinkedList.AddToBack("6");
            genericLinkedList.AddToBack("7");

            genericLinkedList.Display();

            genericLinkedList.RemoveFromFront();
            genericLinkedList.RemoveFromFront();
            genericLinkedList.RemoveFromBack();

            genericLinkedList.Display();
        }
    }
}
