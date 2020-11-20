using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class DoubleLinkedList : IDataStructure
    {
        public int Length { get; private set; }
        private DoubleNode _root;

        public DoubleLinkedList()
        {
            Length = 0;
            _root = new DoubleNode();
            Clear();
        }
        public DoubleLinkedList(int[] array)
        {

            Length = array.Length;

            if (array.Length != 0)
            {
                _root = new DoubleNode();
                Clear();
                DoubleNode tmp = _root;
                for (int i = 0; i < array.Length; i++)
                {
                    DoubleNode previousnode = tmp;
                    tmp.Next = new DoubleNode(array[i]);
                    tmp = tmp.Next;
                    tmp.Previous = previousnode;
                    if (i == array.Length -1)
                    { tmp.Next = _root;  }
                }
                _root.Previous = tmp;

            }
            else
            {
                _root = new DoubleNode();
                Clear();
            }
        }

        public int this[int index]
        {
            get
            {
                CheckBounds(index);
                if (Length == 0)
                { throw new IndexOutOfRangeException(); }
                DoubleNode tmp = FindDoubleNode(index); 
                return tmp.Value;
            }

            set
            {
                CheckBounds(index);
                if (Length == 0)
                { throw new IndexOutOfRangeException(); }
                DoubleNode tmp = FindDoubleNode(index);
                tmp.Value = value;
            }
        }

        public void Add(int value)
        {
            DoubleNode tmp = new DoubleNode(value);
            tmp.Previous = _root.Previous;
            tmp.AttachBefore(_root);
            Length++;
        }

        public void AddFirst(int value)
        {
            AddByIndex(0, value);
        }

        public void AddByIndex(int index, int value)
        {
            CheckBounds(index);
            DoubleNode node = new DoubleNode(value);
            node.AttachBefore(FindDoubleNode(index));
            Length++;

        }


        public void Add(int[] arr)
        {
            for (int i=0; i<arr.Length;i++)
            {
                Add(arr[i]);
            }

        }
        public void AddFirst(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            { AddByIndex(0, arr[i]); }

        }
        public void AddByIndex(int index, int[] arr)
        {
            CheckBounds(index);
            for (int i = arr.Length-1; i >=0; i--)
            { AddByIndex(index, arr[i]); }


        }
        public void DeleteLast()
        {
            DeleteByIndex(Length - 1);
        }
        public void DeleteFirst()
        {

            if (Length == 1)
            {
                Length--;
            }
            else
            {
                DeleteByIndex(0);

            }



        }

        public void DeleteByIndex(int index)
        {
            CheckBounds(index);
            DoubleNode crnt = FindDoubleNode(index);
            crnt.Detach();
            Length--;

        }

        public void DeleteFirstByValue(int value)
        {
            for (DoubleNode n = _root.Next; n != _root; n = n.Next)
            {
                if (value == n.Value)
                { n.Detach();
                    Length--;
                    break;
                }
            }
        }
        public void DeleteAllByValue(int value)
        {
            for (DoubleNode n = _root.Next; n != _root; n = n.Next)
            {
                if (value == n.Value)
                {
                    n.Detach();
                    Length--;
                }
            }

        }
        public void DeleteLastElements(int number)
        {
            DeleteElementsByIndex(Length - number, number);
        }
        public void DeleteFirstElements(int number)
        {

            DeleteElementsByIndex(0, number);

        }
        public void DeleteElementsByIndex(int index, int number)
        {
            for (int i = 0; i <number; i++)
            { DeleteByIndex(index); }
        }

        public int GetElement(int index)
        {
            DoubleNode crnt = _root;
            for (int i = 1; i < index; i++)
            {
                crnt = crnt.Next;
            }
            return crnt.Value;
        }

        public int GetIndex(int element)
        {
            return 0;
        }
        public void ChangeElement(int index, int element)
        {
            CheckBounds(index);

            DoubleNode crnt = _root;

            for (int i = 0; i < index; i++)
            {
                crnt = crnt.Next;
            }

            crnt.Value = element;

        }

        public void Reverse()
        { }
        public int FindMinElement()
        {
            DoubleNode crnt = _root;
            int min = crnt.Value;
            for (int i = 1; i < Length - 1; i++)
            {
                crnt = crnt.Next;
                if (crnt.Value < min)
                { min = crnt.Value; }
            }

            return min;
        }

        public int FindIndexOfMinElement()
        {
            DoubleNode crnt = _root;
            int minindex = 0;
            int min = crnt.Value;
            for (int i = 1; i < Length - 1; i++)
            {
                crnt = crnt.Next;
                if (crnt.Value < min)
                {
                    min = crnt.Value;
                    minindex = i;
                }
            }

            return minindex;
        }


        public int FindMaxElement()
        {
            DoubleNode crnt = _root;
            int max = crnt.Value;
            for (int i = 1; i < Length - 1; i++)
            {
                crnt = crnt.Next;
                if (crnt.Value > max)
                { max = crnt.Value; }
            }

            return max;
        }

        public int FindIndexOfMaxElement()
        {
            DoubleNode crnt = _root;
            int maxindex = 0;
            int max = crnt.Value;
            for (int i = 1; i < Length - 1; i++)
            {
                crnt = crnt.Next;
                if (crnt.Value > max)
                {
                    max = crnt.Value;
                    maxindex = i;
                }
            }

            return maxindex;
        }

        public void SortDesc()
        { }

        public void SortAsc()
        { }

        public override bool Equals(object obj)
        {
            DoubleLinkedList doubleLinkedList = (DoubleLinkedList)obj;

            if (Length != doubleLinkedList.Length)
            {
                return false;
            }

            DoubleNode tmp1 = _root;
            DoubleNode tmp2 = doubleLinkedList._root;

            for (int i = 0; i < Length; i++)
            {
                if (tmp1.Value != tmp2.Value)
                {
                    return false;
                }
                tmp1 = tmp1.Next;
                tmp2 = tmp2.Next;
            }
            return true;
        }
        public override string ToString()
        {
            string s = "";

            DoubleNode tmp = _root;
            for (int i = 0; i < Length; i++)
            {
                tmp = tmp.Next;
                s += tmp.Value + ";";
   
            }
            return s;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private DoubleNode FindDoubleNode(int index)
        {

            CheckBounds(index);
            DoubleNode node = _root.Next;
            if (index == 0 && Length > 0)
            { return node; }
            else
            {
                for (int i = 1; i <= index; i++)
                {
                    node = node.Next;
                }
            }
            return node;
        }

        private void CheckBounds(int index)
        {
            if (index < 0 || index > Length )
            {
                throw new IndexOutOfRangeException();
            }
        }

        private void Clear()
        {
            _root.Next = _root;
            _root.Previous = _root;
        }


    }
}
