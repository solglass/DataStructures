using System;
using System.Collections.Generic;
using System.Threading;
using Homework;


namespace DataStructures
{
    public class ArrayList
    {

        public int Lenght { get; private set; }
        private int[] _array;
        private int _TrueLenght
        {
            get
            {
                return _array.Length;
            }
        }

        public ArrayList()
        {
            _array = new int[9];
            Lenght = 0;
        }

        public void Add(int value)
        {
            if (_TrueLenght <= Lenght)
            {
                IncreaseLenght();
            }
            _array[Lenght] = value;
            Lenght++;
        }

        public void AddFirst(int value)
        {
            IncreaseArrayByOneElement(0, value);

        }

        public void AddAtPosition(int value, int index)
        {
            if (index >= Lenght)
            {
                throw new Exception("Index " + index + " is out of bounds ");
            }
            else { IncreaseArrayByOneElement(index, value); }

        }

        public void AddArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Add(arr[i]);
            }
        }


        public void AddArrayFirst(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                AddFirst(arr[i]);
            }
        }

        public void AddArrayAtPosition(int[] arr, int index)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                AddAtPosition(arr[i], index);
            }
        }


        public void DeleteLast()
        { DecreaseArrayByOneElement(Lenght - 1); }
        public void DeleteByIndex(int index)
        {
            if (index >= Lenght)
            {
                throw new Exception("Index " + index + " is out of bounds ");
            }
            DecreaseArrayByOneElement(index);
        }
        public void DeleteFirst()
        { DecreaseArrayByOneElement(0); }

        public void DeleteFirstByValue(int value)
        {
            int indexdel = GetIndex(value);
            DeleteByIndex(indexdel);
        }

        public void DeleteAllByValue(int value)
        {
            int indexdel;
            while ((indexdel = GetIndex(value)) != -1)
            {
                DeleteByIndex(indexdel);
            }
        }

        public void DeleteLastElements(int number)
        {
            if (number > 0)
            {
                for (int i = 0; i < number; i++) { DeleteLast(); }
            }
            else throw new Exception("Cannot delete less than 1 element");

        }

        public void DeleteFirstElements(int number)
        {
            if (number > 0)
            {
                for (int i = 0; i < number; i++) { DeleteFirst(); }
            }
            else throw new Exception("Cannot delete less than 1 element");

        }
        public void DeleteElementsAtPosition(int index, int number)
        {
            if (number > 0)
            {
                if (index == 0) { DeleteFirstElements(number); }
                else if (index == Lenght - 1) { DeleteLastElements(number); }
                else for (int i = 0; i < number; i++) { DeleteByIndex(index); }
            }
            else throw new Exception("Cannot delete less than 1 element");

        }

        public int GetLenght()
        { return Lenght; }

        public int GetElement(int index)
        {
            if (index < Lenght - 1)
            {
                return _array[index];
            }
            else throw new Exception("Index " + index + " is out of bounds ");
        }
        public int GetIndex(int element)
        {
            int index = -1;
            for (int i = 0; index < Lenght - 1; i++)
            {
                if (_array[i] == element)
                {
                    index = i;
                    break;
                }
            }
            // if (index >= 0) return index;
            //else throw new Exception("Element not found");
            return index;
        }

        public void ChangeElement(int index, int element)
        {
            if (index < Lenght - 1)
            {
                _array[index] = element;
            }
            else throw new Exception("Index " + index + " is out of bounds ");
        }

        public void Reverse()
        { _array = OrderOperations.ReverseTheArray(_array); }
        public int FindMinElementOfTheArray()
        { return MathOperations.FindMinElementOfTheArray(_array); }
        public int FindIndexOfMinElementOfTheArray()
        { return MathOperations.FindIndexOfMinElementOfTheArray(_array); }
        public int FindMaxElementOfTheArray()
        { return MathOperations.FindMaxElementOfTheArray(_array); }
        public int FindIndexOfMaxElementOfTheArray()
        { return MathOperations.FindIndexOfMaxElementOfTheArray(_array); }

        public void SortArrayDesc()
        { _array = OrderOperations.BubbleSortTheArrayDesc(_array); }
        public void SortArrayAsc()
        { _array = OrderOperations.InsertSortTheArrayAsc(_array); }


        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;

            if (Lenght != arrayList.Lenght)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Lenght; i++)
                {
                    if (_array[i] != arrayList._array[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return -1521134295 * (-1521134295 * (-1521134295  + EqualityComparer<Array>.Default.GetHashCode(this._array)) 
                + EqualityComparer<int>.Default.GetHashCode(this.Lenght)) + EqualityComparer<int>.Default.GetHashCode(this._TrueLenght);
        }

        private void IncreaseLenght(int number = 1)
        {
            int newLenght = _TrueLenght;
            while (newLenght <= Lenght + number)
            {
                newLenght = (int)(newLenght * 1.33 + 1);
            }

            int[] newArray = new int[newLenght];
            Array.Copy(_array, newArray, _TrueLenght);

            _array = newArray;
        }

        private void DecreaseArrayByOneElement(int index = 0)
        {

            int copyFromIndex = index + 1;
            int[] newArray = new int[_TrueLenght];
            Array.Copy(_array, newArray, _TrueLenght);
            if (index < Lenght - 1)
            {
                Array.Copy(_array, copyFromIndex, newArray, index, Lenght - copyFromIndex);
            }
            else throw new Exception("Index " + index + " is out of bounds ");
            newArray[Lenght - 1] = 0;
            Lenght--;
            _array = newArray;
        }

        private void IncreaseArrayByOneElement(int index = 0, int elem = 0)
        {
            if (index < Lenght - 1)
            {
                int copyFromIndex = index + 1;
                int[] newArray = new int[_TrueLenght];
                Array.Copy(_array, newArray, _TrueLenght);
                Array.Copy(_array, copyFromIndex, newArray, index, Lenght - copyFromIndex);
                Lenght++;
                newArray[index] = elem;
                _array = newArray;
            }
            else IncreaseLenght(1);
            _array[Lenght - 1] = elem;
        }



    }
}
