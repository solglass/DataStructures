using System;
using System.Text;
using NUnit.Framework;
using DataStructures;

namespace NUnitTestProjectDataStructures
{
    class LinkedListTests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, 5)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, 4, -5)]
        [TestCase(new int[] { 1 }, 0, 1)]
        public void GetByIndexTest(int[] array, int index, int expected)
        {
            LinkedList linkedList = new LinkedList(array);

            int actual = linkedList[index];

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, int.MaxValue, new int[] { int.MaxValue, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 10, new int[] { 1, 2, 10, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, -9, new int[] { 1, 2, 3, 4, -9 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, 4, -100, new int[] { -1, -2, -3, -4, -100 })]
        [TestCase(new int[] { 1 }, 0, 0, new int[] { 0 })]
        public void SetByIndex(int[] array, int index, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual[index] = value;

            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, int.MaxValue, new int[] { int.MaxValue, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 10, new int[] { 1, 2, 10, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, -9, new int[] { 1, 2, 3, 4, -9, 5 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, 4, -100, new int[] { -1, -2, -3, -4, -100, -5 })]
        [TestCase(new int[] { 1 }, 0, 0, new int[] { 0, 1 })]
        [TestCase(new int[] { }, 0, 0, new int[] { 0 })]
        public void AddByIndex(int[] array, int index, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual.AddByIndex(index, value);

            Assert.AreEqual(expected, actual);

        }


        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, new int[] { int.MaxValue, int.MaxValue }, new int[] { int.MaxValue, int.MaxValue, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 10, 9 }, new int[] { 1, 2, 10, 9, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { -9, -10 }, new int[] { 1, 2, 3, 4, -9, -10, 5 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, 4, new int[] { -100, -200 }, new int[] { -1, -2, -3, -4, -100, -200, -5 })]
        [TestCase(new int[] { 1 }, 0, new int[] { 0, 1 }, new int[] { 0, 1, 1 })]
        [TestCase(new int[] { }, 0, new int[] { 0, 3 }, new int[] { 0, 3 })]
        public void AddByIndex(int[] array, int index, int[] arr, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual.AddByIndex(index, arr);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, int.MaxValue, new int[] { 1, 2, 3, 4, 5, int.MaxValue })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 10, new int[] { 1, 2, 3, 4, 5, 10 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, -9, new int[] { 1, 2, 3, 4, 5, -9 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, -100, new int[] { -1, -2, -3, -4, -5, -100 })]
        [TestCase(new int[] { 1 }, 0, new int[] { 1, 0 })]
        [TestCase(new int[] { }, 0, new int[] { 0 })]

        public void Add(int[] array, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual.Add(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { int.MaxValue, int.MaxValue }, new int[] { 1, 2, 3, 4, 5, int.MaxValue, int.MaxValue })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 10, 9 }, new int[] { 1, 2, 3, 4, 5, 10, 9 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { -9, -10 }, new int[] { 1, 2, 3, 4, 5, -9, -10, })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, new int[] { -100, -200 }, new int[] { -1, -2, -3, -4, -5, -100, -200, })]
        [TestCase(new int[] { 1 }, new int[] { 0, 1 }, new int[] { 1, 0, 1 })]
        [TestCase(new int[] { }, new int[] { 0, 3 }, new int[] { 0, 3 })]
        public void Add(int[] array, int[] arr, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual.Add(arr);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3, 4, 5 }, int.MaxValue, new int[] { int.MaxValue, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 10, new int[] { 10, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, -9, new int[] { -9, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, -100, new int[] { -100, -1, -2, -3, -4, -5 })]
        [TestCase(new int[] { 1 }, 0, new int[] { 0, 1 })]
        [TestCase(new int[] { }, 0, new int[] { 0 })]
        public void AddFirst(int[] array, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual.AddFirst(value);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { int.MaxValue, int.MaxValue }, new int[] { int.MaxValue, int.MaxValue, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 10, 9 }, new int[] { 10, 9, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { -9, -10 }, new int[] { -9, -10, 1, 2, 3, 4, 5, })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, new int[] { -100, -200 }, new int[] { -100, -200, -1, -2, -3, -4, -5 })]
        [TestCase(new int[] { 1 }, new int[] { 0, 1 }, new int[] { 0, 1, 1 })]
        [TestCase(new int[] { }, new int[] { 0, 3 }, new int[] { 0, 3 })]
        public void AddFirst(int[] array, int[] arr, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual.AddFirst(arr);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, new int[] { 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, 4, new int[] { -1, -2, -3, -4 })]
        [TestCase(new int[] { 1 }, 0, new int[] { })]
        public void DeleteByIndex(int[] array, int index, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual.DeleteByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, new int[] { -1, -2, -3, -4 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void DeleteLast(int[] array, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual.DeleteLast();

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, new int[] { -2, -3, -4, -5 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void DeleteFirst(int[] array, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual.DeleteFirst();

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1, new int[] { 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { 1, 2, 3, 5 })]
        [TestCase(new int[] { -1, -4, -3, -4, -5 }, -4, new int[] { -1, -3, -4, -5 })]
        [TestCase(new int[] { 1 }, 1, new int[] { })]
        public void DeleteFirstByValue(int[] array, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual.DeleteFirstByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 1, 1, 1, 1, 1 }, 1, new int[] { 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { 1, 2, 3, 5 })]
        [TestCase(new int[] { -1, -4, -3, -4, -5 }, -4, new int[] { -1, -3, -5 })]
        [TestCase(new int[] { 7 }, 7, new int[] { })]
        public void DeleteAllByValue(int[] array, int value, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual.DeleteAllByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 3, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 2, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, 1, new int[] { -1, -2, -3, -4 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, 4, new int[] { -1 })]
        public void DeleteLastElements(int[] array, int number, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual.DeleteLastElements(number);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 3, new int[] { 4, 5, 6, 7, 8 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 2, new int[] { 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, 1, new int[] { -2, -3, -4, -5 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, 4, new int[] { -5 })]
        public void DeleteFirstElements(int[] array, int number, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual.DeleteFirstElements(number);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, 1, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 3, 5, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 2, 3, new int[] { 1, 2, 6, 7 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, 1, 4, new int[] { -1, })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, 0, 4, new int[] { -5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 2, 7, new int[] { 1, 2, 10, 11 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 3, 7, new int[] { 1, 2, 3, 11 })]

        public void DeleteElementsByIndex(int[] array, int index, int number, int[] expArray)
        {
            LinkedList expected = new LinkedList(expArray);
            LinkedList actual = new LinkedList(array);
            actual.DeleteElementsByIndex(index, number);

            Assert.AreEqual(expected, actual);
        }

        public int GetElement(int index)
        { return 0; }

        public int GetIndex(int element)
        { return 0; }
        public void ChangeElement(int index, int element)
        { }

        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 })]
        public void Reverse(int[] arr)
        {
            LinkedList expected = new LinkedList(OrderOperations.ReverseTheArray(arr));
            LinkedList actual = new LinkedList(arr);
            actual.Reverse();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 })]
        public void FindIndexOfMaxElement(int[] arr)
        {
            LinkedList ll = new LinkedList(arr);
            int expected = MathOperations.FindIndexOfMaxElementOfTheArray(arr);
            int actual = ll.FindIndexOfMaxElement();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 })]
        public void FindIndexOfMinElement(int[] arr)
        {
            LinkedList ll = new LinkedList(arr);
            int expected = MathOperations.FindIndexOfMinElementOfTheArray(arr);
            int actual = ll.FindIndexOfMinElement();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 })]
        public void FindMinElementOfTheArray(int[] arr)
        {
            LinkedList ll = new LinkedList(arr);
            int expected = MathOperations.FindMinElementOfTheArray(arr);
            int actual = ll.FindMinElement();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 })]
        public void FindMaxElementOfTheArray(int[] arr)
        {
            LinkedList ll = new LinkedList(arr);
            int expected = MathOperations.FindMaxElementOfTheArray(arr);
            int actual = ll.FindMaxElement();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, -1)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, -2)]
        [TestCase(new int[] { 3 }, -3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, -4)]
        public void GetElementNegativeTest(int[] arr, int index)
        {
            LinkedList actual = new LinkedList(arr);
            Assert.Throws<IndexOutOfRangeException>(() => actual[index] = 0);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 })]
        [TestCase(new int[] { 1, 3, 0, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 })]
        public void SortDesc(int[] arr)
        {
            LinkedList actual = new LinkedList(arr);
            LinkedList expected = new LinkedList(OrderOperations.BubbleSortTheArrayDesc(arr));
            actual.SortDesc();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 })]
        [TestCase(new int[] { 1, 3, 0, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 })]
        public void SortAsc(int[] arr)
        {
            LinkedList actual = new LinkedList(arr);
            LinkedList expected = new LinkedList(OrderOperations.InsertSortTheArrayAsc(arr));
            actual.SortAsc();
            Assert.AreEqual(expected, actual);
        }
    }
}