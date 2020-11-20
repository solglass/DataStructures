using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList : IDataStructure
    {
        public int Length { get; private set; }
        private Node _root;

        public LinkedList()
        {
            Length = 0;
            _root = null;
        }
        public LinkedList(int[] array)
        {
            Length = array.Length;

            if (array.Length != 0)
            {
                _root = new Node(array[0]);
                Node tmp = _root;
                for (int i = 1; i < array.Length; i++)
                {
                    tmp.Next = new Node(array[i]);
                    tmp = tmp.Next;
                }
            }
            else
            {
                _root = null;
            }
        }

        public int this[int index]
        {
            get
            {
                Node tmp = _root;
                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }
                return tmp.Value;
            }

            set
            {
                Node tmp = _root;
                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }
                tmp.Value = value;
            }
        }

        public void Add(int value)
        {

            if (Length > 0)
            {
                Node crnt = _root;
                for (int i = 0; i < Length - 1; i++)
                {
                    crnt = crnt.Next;
                }
                Node tmp = new Node(value);
                tmp.Next = crnt.Next;
                crnt.Next = tmp;
            }
            else
            {
                Node tmp = new Node(value);
                tmp.Next = _root;
                _root = tmp;
            }
            Length++;
        }

        public void AddFirst(int value)
        {
            AddByIndex(0, value);
        }

        public void AddByIndex(int index, int value)
        {
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (index != 0)
            {
                Node crnt = _root;
                for (int i = 0; i < index - 1; i++)
                {
                    crnt = crnt.Next;
                }
                Node tmp = new Node(value);
                tmp.Next = crnt.Next;
                crnt.Next = tmp;
            }
            else
            {
                Node tmp = new Node(value);
                tmp.Next = _root;
                _root = tmp;
            }
            Length++;
        }

        public void Add(int[] arr)
        {
            if (Length > 0)
            {
                Node crnt = _root;
                for (int i = 0; i < Length - 1; i++)
                {
                    crnt = crnt.Next;
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    Node tmp = new Node(arr[i]);
                    tmp.Next = crnt.Next;
                    crnt.Next = tmp;
                    crnt = crnt.Next;
                    Length++;
                }

            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 0)
                    {
                        Node tmp = new Node(arr[i]);
                        tmp.Next = _root;
                        _root = tmp;

                    }

                    else
                    {
                        Node crnt = _root;
                        Node tmp = new Node(arr[i]);
                        tmp.Next = crnt.Next;
                        crnt.Next = tmp;
                    }
                    Length++;
                }
            }
        }
        public void AddFirst(int[] arr)
        {
            AddByIndex(0, arr);
        }
        public void AddByIndex(int index, int[] arr)
        {
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (index != 0)
            {
                Node crnt = _root;
                for (int i = 0; i < index - 1; i++)
                {
                    crnt = crnt.Next;
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    Node tmp = new Node(arr[i]);
                    tmp.Next = crnt.Next;
                    crnt.Next = tmp;
                    crnt = crnt.Next;
                    Length++;
                }

            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 0)
                    {
                        Node tmp = new Node(arr[i]);
                        tmp.Next = _root;
                        _root = tmp;

                    }

                    else
                    {
                        Node crnt = _root;
                        Node tmp = new Node(arr[i]);
                        tmp.Next = crnt.Next;
                        crnt.Next = tmp;
                    }
                    Length++;
                }
            }



        }
        public void DeleteLast()
        {
            DeleteByIndex(Length - 1);
        }
        public void DeleteFirst()
        {

            if (Length == 1)
            {

            }
            else
            {
                Node crnt = _root;
                Node tmp = crnt.Next;
                _root = tmp;

            }

            Length--;

        }

        public void DeleteByIndex(int index)
        {
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0 && Length > 0)
            {
                Node crnt = _root;
                _root = crnt.Next;
            }
            else if (index < Length)
            {
                Node crnt = _root;
                for (int i = 0; i < index - 1; i++)
                {
                    crnt = crnt.Next;
                }

                Node tmp = crnt.Next.Next;
                crnt.Next = tmp;
            }
            else
            {

            }
            Length--;
        }

        public void DeleteFirstByValue(int value)
        {
            Node crnt = _root;
            if (crnt.Value == value)
            { DeleteFirst(); }
            else
                for (int i = 1; i < Length - 1; i++)
                {

                    crnt = crnt.Next;
                    if (crnt.Value == value)
                    {
                        DeleteByIndex(i);
                        break;
                    }
                }
        }
        public void DeleteAllByValue(int value)
        {
            Node crnt = _root;
            for (int i = 0; i < Length; i++)
            {
                Node nxt = crnt.Next;
                if (i == 0 && crnt.Value == value)
                {
                    DeleteFirst();
                }
                else if (nxt != null && nxt.Value == value)
                {
                    if (i < Length)
                    {
                        Node tmp = crnt.Next.Next;
                        while (tmp.Value == value && tmp != null && Length > i)
                        {
                            tmp = crnt.Next;
                            Length--;
                        }
                        if (i < Length)
                        {
                            crnt.Next = tmp;
                            Length--;
                        }
                    }

                }
                else if (crnt.Value == value)
                { Length--; }


                crnt = crnt.Next;
            }

        }
        public void DeleteLastElements(int number)
        {
            DeleteElementsByIndex(Length - number, number);
        }
        public void DeleteFirstElements(int number)
        {
            if (Length == 1)
            {

            }
            else if (Length == number)
            { Length = 0; }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    Node crnt = _root;
                    Node tmp = crnt.Next;
                    _root = tmp;
                    Length--;
                }

            }


        }
        public void DeleteElementsByIndex(int index, int number)
        {
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0 && Length > 0)
            {

                for (int i = 0; i < number; i++)
                {
                    if (Length > 0)
                    {
                        Node crnt = _root;
                        _root = crnt.Next;
                    }
                    Length--;

                }

            }
            else if (index < Length - 1)
            {
                Node crnt = _root;
                Node nxt = crnt.Next;
                for (int i = 0; i < index - 1; i++)
                {
                    crnt = crnt.Next;
                }

                for (int i = 0; i < number; i++)
                {
                    if (nxt != null)
                    {
                        Node tmp = crnt.Next.Next;
                        crnt.Next = tmp;

                        nxt = crnt.Next;
                    }


                    Length--;

                }

            }
            else
            {
                Length--;
            }

        }

        public int GetElement(int index)
        {
            Node crnt = _root;
            for (int i = 1; i < index; i++)
            {
                crnt = crnt.Next;
            }
            return crnt.Value;
        }

        public int GetIndex(int element)
        {
            Node crnt = _root;
            int index = -1;
            if (crnt.Value == element)
            { index = 0; }
            else
                for (int i = 1; i < Length - 1; i++)
                {
                    crnt = crnt.Next;
                    if (crnt.Value == element)
                    { index = i; }
                }
            return index;
        }
        public void ChangeElement(int index, int element)
        {
            Node crnt = _root;

            for (int i = 0; i < index; i++)
            {
                crnt = crnt.Next;
            }

            crnt.Value = element;

        }

        public void Reverse()
        {
            Node oldRoot = _root;
            Node tmp;
            while (oldRoot.Next != null)
            {
                tmp = oldRoot.Next;
                oldRoot.Next = oldRoot.Next.Next;
                tmp.Next = _root;
                _root = tmp;
            }
        }
        public int FindMinElement()
        {
            Node crnt = _root;
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
            Node crnt = _root;
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
            Node crnt = _root;
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
            Node crnt = _root;
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
            LinkedList linkedList = (LinkedList)obj;

            if (Length != linkedList.Length)
            {
                return false;
            }

            Node tmp1 = _root;
            Node tmp2 = linkedList._root;

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

            Node tmp = _root;
            for (int i = 0; i < Length; i++)
            {
                s += tmp.Value + ";";
                tmp = tmp.Next;
            }
            return s;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
