using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    class IntegerLinkedList : IIntegerLinkedList
    {
        //make node class
        protected class Node
        {
            public int Data { get; set; }
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

        public void AddToFront(int integerData)
        {
            Node oldHead = _head;

            _head = new Node();

            _head.Data = integerData;

            _head.Next = oldHead;

            _size++;

            if(_tail == null)
            {
                _tail = _head;
            }
        }

        public void AddToBack(int integerData)
        {
            Node oldTail = _tail;

            _tail = new Node();

            _tail.Data = integerData;

            _tail.Next = null;

            if(IsEmpty)
            {
                _head = _tail;
            }
            else
            {
                oldTail.Next = _tail;
            }
            _size++;
        }

        public int RemoveFromFront()
        {
            if (IsEmpty)
            {
                throw new Exception("List is empty");
            }

            int returnData = _head.Data;

            _head = _head.Next;

            _size--;

            if (IsEmpty)
            {
                _tail = null;
            }

            return returnData;
        }

        public int RemoveFromBack()
        {
            if (IsEmpty)
            {
                throw new Exception("List is empty");
            }

            int returnData = _tail.Data;

            if(_head == _tail)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                Node currentNode = _head;
                while(currentNode.Next != _tail)
                {
                    currentNode = currentNode.Next;
                }

                _tail = currentNode;

                _tail.Next = null;
            }

            return returnData;
        }





















        public void AddMaintainSort(int integerData)
        {
            Node newNode = new Node();
            newNode.Data = integerData;

            if(IsEmpty || _head.Data >= newNode.Data)
            {
                newNode.Next = _head;

                _head = newNode;

                if(_tail == null)
                {
                    _tail = _head;
                }
            }
            else
            {
                Node currentNode = _head;

                while(currentNode.Next != null && currentNode.Next.Data < newNode.Data)
                {
                    //Move down the list one node
                    currentNode = currentNode.Next;
                }

                //Make the newNode's next property point to the current nodes next property.
                newNode.Next = currentNode.Next;

                currentNode.Next = newNode;

                if(_tail == currentNode)
                {
                    _tail = newNode;
                }
            }
            _size++;
        }

        public int RemoveMaintainSort(int removeData)
        {
            if (IsEmpty)
            {
                throw new Exception("List is empty");
            }

            int returnData;

            if(_head == _tail || _head.Data == removeData)
            {
                returnData = _head.Data;

                _head = _head.Next;

                if(_head == null)
                {
                    _tail = null;
                }
            }
            else
            {
                Node currentNode = _head;

                while(currentNode.Next != _tail && currentNode.Next.Data != removeData)
                {
                    currentNode = currentNode.Next;
                }

                if(currentNode.Next.Data == removeData)
                {
                    returnData = currentNode.Next.Data;

                    if(currentNode .Next == _tail)
                    {
                        _tail = currentNode;
                    }

                    currentNode.Next = currentNode.Next.Next;
                }
                else
                {
                    throw new Exception("Item not found");
                }
            }
            _size--;

            return returnData;
        }

        public void Display()
        {
            Console.WriteLine("The list is:");

            Node currentNode = _head;

            while(currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
            }
        }
    }

}
