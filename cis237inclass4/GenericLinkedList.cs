using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    class GenericLinkedList<T> : IGenericLinkedList<T>
    {

        protected class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        // A couple of pointers to the head and tail of the linked list
        protected Node _head;
        protected Node _tail;
        protected int _size;

        public bool IsEmpty
        {
            get
            {
                return _head == null;
            }
        }

        public int Size
        {
            get
            {
                return _size;
            }
        }

        public void AddToFront(T data)
        {
            Node oldHead = _head;

            _head = new Node();

            _head.Data = data;

            _head.Next = oldHead;

            _size++;

            if (_tail == null)
            {
                _tail = _head;
            }
        }

        public void AddToBack(T data)
        {
            Node oldTail = _tail;

            _tail = new Node();

            _tail.Data = data;

            _tail.Next = null;

            if (IsEmpty)
            {
                _head = _tail;
            }
            else
            {
                oldTail.Next = _tail;
            }
            _size++;
        }

        public T RemoveFromFront()
        {
            if (IsEmpty)
            {
                throw new Exception("List is empty");
            }

            T returnData = _head.Data;

            _head = _head.Next;

            _size--;

            if (IsEmpty)
            {
                _tail = null;
            }

            return returnData;
        }

        public T RemoveFromBack()
        {
            if (IsEmpty)
            {
                throw new Exception("List is empty");
            }

            T returnData = _tail.Data;

            if (_head == _tail)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                Node currentNode = _head;
                while (currentNode.Next != _tail)
                {
                    currentNode = currentNode.Next;
                }

                _tail = currentNode;

                _tail.Next = null;
            }

            return returnData;
        }

        public void Display()
        {
            Console.WriteLine("The list is:");

            Node currentNode = _head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
            }
        }
    }
}

