using System;
using System.Collections.Generic;


namespace DataStructures
{
    public class ArrayList : IDataStructure
    {

        public int Length { get; private set; }
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
            Length = 0;
        }

        public ArrayList(int[] array)
        {
            _array = new int[(int)(array.Length * 1.33) + 1];
            Array.Copy(array, _array, array.Length);
            Length = array.Length;
        }

        public ArrayList(int elem)
        {
            _array = new int[9];
            _array[0] = elem;
            Length = 1;
        }

        public int this[int index]
        {
            get
            {
                if (index > Length - 1 || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index > Length - 1 || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }


        public void Add(int value)
        {
            if (_TrueLenght <= Length)
            {
                IncreaseLenght();
            }
            _array[Length] = value;
            Length++;
        }

        public void AddFirst(int value)
        {
            IncreaseArray(0, value);

        }

        public void AddByIndex  (int value, int index)
        {
            if (index >= Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else { IncreaseArray(index, value); }

        }

        public void Add(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Add(arr[i]);
            }
        }


        public void AddFirst(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                AddFirst(arr[i]);
            }
        }

        public void AddByIndex( int index, int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                AddByIndex(arr[i], index);
            }
        }


        public void DeleteLast()
        { DecreaseArray(Length - 1); }
        public void DeleteByIndex(int index)
        {
            if (index >= Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            DecreaseArray(index);
        }
       public void DeleteFirst()
          { DecreaseArray(0); }

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
                DecreaseArray(Length - 1, number);
            }
            else throw new ArgumentException("Cannot delete less than 1 element");

        }

        public void DeleteFirstElements(int number)
        {
            if (number > 0)
            {
                DecreaseArray(0, number);
            }
            else throw new ArgumentException("Cannot delete less than 1 element");

        }
        public void DeleteElementsAtPosition(int index, int number)
        {
            if (number > 0)
            {

                    DecreaseArray(index, number);
            }
            else throw new ArgumentException("Cannot delete less than 1 element");

        }

        public int GetLenght()
        { return Length; }

        public int GetElement(int index)
        {
            if (index < Length - 1 && index >= 0)
            {
                return _array[index];
            }
            else throw new IndexOutOfRangeException();
        }
        public int GetIndex(int element)
        {
            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == element)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void ChangeElement(int index, int element)
        {
            if (index < Length - 1 || index >= 0)
            {
                _array[index] = element;
            }
            else throw new IndexOutOfRangeException();
        }

        public void Reverse()
        {
            int[] newArray = new int[Length];
            Array.Copy(_array, newArray, Length);
            _array = OrderOperations.ReverseTheArray(newArray);
        }
        public int FindMinElement()
        {
            int[] newArray = new int[Length];
            Array.Copy(_array, newArray, Length);
            return MathOperations.FindMinElementOfTheArray(newArray);
        }
        public int FindIndexOfMinElement()
        {
            int[] newArray = new int[Length];
            Array.Copy(_array, newArray, Length);
            return MathOperations.FindIndexOfMinElementOfTheArray(newArray);
        }
        public int FindMaxElement()
        {
            int[] newArray = new int[Length];
            Array.Copy(_array, newArray, Length);
            return MathOperations.FindMaxElementOfTheArray(newArray);
        }
        public int FindIndexOfMaxElement()
        {
            int[] newArray = new int[Length];
            Array.Copy(_array, newArray, Length);
            return MathOperations.FindIndexOfMaxElementOfTheArray(newArray);
        }

        public void SortDesc()
        {
            int[] newArray = new int[Length];
            Array.Copy(_array, newArray, Length);
            _array = OrderOperations.BubbleSortTheArrayDesc(newArray);
        }
        public void SortAsc()
        {
            int[] newArray = new int[Length];
            Array.Copy(_array, newArray, Length);
            _array = OrderOperations.InsertSortTheArrayAsc(newArray);
        }


        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;

            if (Length != arrayList.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Length; i++)
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
            return -1521134295 * (-1521134295 * (-1521134295 + EqualityComparer<Array>.Default.GetHashCode(this._array))
                + EqualityComparer<int>.Default.GetHashCode(this.Length)) + EqualityComparer<int>.Default.GetHashCode(this._TrueLenght);
        }

        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < Length; i++)
            {
                s += _array[i]+ "; ";
            }
            return s;
        }

        private void IncreaseLenght(int number = 1)
        {
            int newLenght = _TrueLenght;
            while (newLenght <= Length + number)
            {
                newLenght = (int)(newLenght * 1.33 + 1);
            }

            int[] newArray = new int[newLenght];
            Array.Copy(_array, newArray, _TrueLenght);

            _array = newArray;
        }

        private void DecreaseArray(int index = 0, int numberOfElements = 1)
        {
            int copyFromIndex = index + numberOfElements;
            int numberOfElementsToCopy = Length - copyFromIndex + 1;

            if (index < Length && index >= 0  )
            {
                if (numberOfElementsToCopy > 0)
                { Array.Copy(_array, copyFromIndex, _array, index, numberOfElementsToCopy); }
            }
            else throw new IndexOutOfRangeException();
            Length-= numberOfElements;

        }

        private void IncreaseArray(int index = 0, int elem = 0)
        {
            if (index < Length )
            {
                int copyFromIndex = index;
                Array.Copy(_array, copyFromIndex, _array, index + 1, Length - copyFromIndex);
                Length++;
                _array[index] = elem;

            }

        }



    }
}
