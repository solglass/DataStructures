using System;
using System.Collections.Generic;


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

        public ArrayList(int[] array)
        {
            _array = new int[(int)(array.Length * 1.33) + 1];
            Array.Copy(array, _array, array.Length);
            Lenght = array.Length;
        }

        public ArrayList(int elem)
        {
            _array = new int[9];
            _array[0] = elem;
            Lenght = 1;
        }

        public int this[int index]
        {
            get
            {
                if (index > Lenght - 1 || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index > Lenght - 1 || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
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
            if (index >= Lenght || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else { IncreaseArrayByOneElement(index, value); }

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

        public void AddAtPosition(int[] arr, int index)
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
            if (index >= Lenght || index < 0)
            {
                throw new IndexOutOfRangeException();
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
            else throw new ArgumentException("Cannot delete less than 1 element");

        }

        public void DeleteFirstElements(int number)
        {
            if (number > 0)
            {
                for (int i = 0; i < number; i++) { DeleteFirst(); }
            }
            else throw new ArgumentException("Cannot delete less than 1 element");

        }
        public void DeleteElementsAtPosition(int index, int number)
        {
            if (number > 0)
            {
                if (index == 0) { DeleteFirstElements(number); }
                else if (index == Lenght - 1) { DeleteLastElements(number); }
                else for (int i = 0; i < number; i++) { DeleteByIndex(index); }
            }
            else throw new ArgumentException("Cannot delete less than 1 element");

        }

        public int GetLenght()
        { return Lenght; }

        public int GetElement(int index)
        {
            if (index < Lenght - 1 && index >= 0)
            {
                return _array[index];
            }
            else throw new IndexOutOfRangeException();
        }
        public int GetIndex(int element)
        {
            int index = -1;
            for (int i = 0; i < Lenght; i++)
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
            if (index < Lenght - 1 || index >= 0)
            {
                _array[index] = element;
            }
            else throw new IndexOutOfRangeException();
        }

        public void Reverse()
        {
            int[] newArray = new int[Lenght];
            Array.Copy(_array, newArray, Lenght);
            _array = OrderOperations.ReverseTheArray(newArray);
        }
        public int FindMinElementOfTheArray()
        {
            int[] newArray = new int[Lenght];
            Array.Copy(_array, newArray, Lenght);
            return MathOperations.FindMinElementOfTheArray(newArray);
        }
        public int FindIndexOfMinElementOfTheArray()
        {
            int[] newArray = new int[Lenght];
            Array.Copy(_array, newArray, Lenght);
            return MathOperations.FindIndexOfMinElementOfTheArray(newArray);
        }
        public int FindMaxElementOfTheArray()
        {
            int[] newArray = new int[Lenght];
            Array.Copy(_array, newArray, Lenght);
            return MathOperations.FindMaxElementOfTheArray(newArray);
        }
        public int FindIndexOfMaxElementOfTheArray()
        {
            int[] newArray = new int[Lenght];
            Array.Copy(_array, newArray, Lenght);
            return MathOperations.FindIndexOfMaxElementOfTheArray(newArray);
        }

        public void SortArrayDesc()
        {
            int[] newArray = new int[Lenght];
            Array.Copy(_array, newArray, Lenght);
            _array = OrderOperations.BubbleSortTheArrayDesc(newArray);
        }
        public void SortArrayAsc()
        {
            int[] newArray = new int[Lenght];
            Array.Copy(_array, newArray, Lenght);
            _array = OrderOperations.InsertSortTheArrayAsc(newArray);
        }


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
            return -1521134295 * (-1521134295 * (-1521134295 + EqualityComparer<Array>.Default.GetHashCode(this._array))
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
            if (index < Lenght && index >= 0)
            {
                Array.Copy(_array, copyFromIndex, newArray, index, Lenght - copyFromIndex);
            }
            else throw new IndexOutOfRangeException();
            newArray[Lenght - 1] = 0;
            Lenght--;
            _array = newArray;
        }

        private void IncreaseArrayByOneElement(int index = 0, int elem = 0)
        {
            if (index < Lenght )
            {
                int copyFromIndex = index;
                int[] newArray = new int[_TrueLenght + 1];
                Array.Copy(_array, newArray, _TrueLenght);
                Array.Copy(_array, copyFromIndex, newArray, index + 1, Lenght - copyFromIndex);
                Lenght++;
                newArray[index] = elem;
                _array = newArray;
            }

        }


    }
}
