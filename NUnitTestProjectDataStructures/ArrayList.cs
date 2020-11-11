using NUnit.Framework;
using NUnitTestProjectDataStructures;
using DataStructures;
using System;
using Homework;

namespace NUnitTestProjectDataStructures
{
    public class Tests
    {
        public class ArrayList
        {


            public void GetLenght(int[] a, int expected)
            {
                DataStructures.ArrayList arrayListTest = new DataStructures.ArrayList();
                int actual = arrayListTest.GetLenght();

                Assert.AreEqual(expected, actual);
            }



            [TestCase(1)]
            [TestCase(2)]
            [TestCase(3)]
            [TestCase(4)]

            public void SortArrayDesc(int arrayMockNumber)
            {
                int[] a = GetArrayMock(arrayMockNumber);
                DataStructures.ArrayList expected = new DataStructures.ArrayList(OrderOperations.BubbleSortTheArrayDesc(a));
                DataStructures.ArrayList arrayListTest = new DataStructures.ArrayList(a);
                arrayListTest.SortArrayDesc();
                Assert.AreEqual(expected, arrayListTest);
            }

            [TestCase(1)]
            [TestCase(2)]
            [TestCase(3)]
            [TestCase(4)]
            public void SortArrayAsc(int arrayMockNumber)
            {
                int[] a = GetArrayMock(arrayMockNumber);
                DataStructures.ArrayList expected = new DataStructures.ArrayList(OrderOperations.InsertSortTheArrayAsc(a));
                DataStructures.ArrayList arrayListTest = new DataStructures.ArrayList(a);
                arrayListTest.SortArrayAsc();
                Assert.AreEqual(expected, arrayListTest);
            }

            [TestCase(1)]
            [TestCase(2)]
            [TestCase(3)]
            [TestCase(4)]
            public void Reverse(int arrayMockNumber)
            {
                int[] a = GetArrayMock(arrayMockNumber);
                DataStructures.ArrayList expected = new DataStructures.ArrayList(OrderOperations.ReverseTheArray(a));
                DataStructures.ArrayList arrayListTest = new DataStructures.ArrayList(a);
                arrayListTest.Reverse();
                Assert.AreEqual(expected, arrayListTest);
            }
            [TestCase(1)]
            [TestCase(2)]
            [TestCase(3)]
            [TestCase(4)]
            public void FindIndexOfMaxElementOfTheArray(int arrayMockNumber)
            {
                int[] a = GetArrayMock(arrayMockNumber);
                int expected = MathOperations.FindIndexOfMaxElementOfTheArray(a);
                DataStructures.ArrayList arrayListTest = new DataStructures.ArrayList(a);
                int actual = arrayListTest.FindIndexOfMaxElementOfTheArray();
                Assert.AreEqual(expected, actual);
            }
            [TestCase(1)]
            [TestCase(2)]
            [TestCase(3)]
            [TestCase(4)]
            public void FindIndexOfMinElementOfTheArray(int arrayMockNumber)
            {
                int[] a = GetArrayMock(arrayMockNumber);
                int expected = MathOperations.FindIndexOfMinElementOfTheArray(a);
                DataStructures.ArrayList arrayListTest = new DataStructures.ArrayList(a);
                int actual = arrayListTest.FindIndexOfMinElementOfTheArray();
                Assert.AreEqual(expected, actual);
            }

            [TestCase(1)]
            [TestCase(2)]
            [TestCase(3)]
            [TestCase(4)]
            public void FindMinElementOfTheArray(int arrayMockNumber)
            {
                int[] a = GetArrayMock(arrayMockNumber);
                int expected = MathOperations.FindMinElementOfTheArray(a);
                DataStructures.ArrayList arrayListTest = new DataStructures.ArrayList(a);
                int actual = arrayListTest.FindMinElementOfTheArray();
                Assert.AreEqual(expected, actual);
            }
            [TestCase(1)]
            [TestCase(2)]
            [TestCase(3)]
            [TestCase(4)]
            public void FindMaxElementOfTheArray(int arrayMockNumber)
            {
                int[] a = GetArrayMock(arrayMockNumber);
                int expected = MathOperations.FindMaxElementOfTheArray(a);
                DataStructures.ArrayList arrayListTest = new DataStructures.ArrayList(a);
                int actual = arrayListTest.FindMaxElementOfTheArray();
                Assert.AreEqual(expected, actual);
            }


           /* public int[,] GetExpectedMockTranspose(int n)
            {
                switch (n)
                {
                    case 1:
                        return new 
                    case 2:
                        return new 
                    case 3:
                        return new 
                    case 4:
                        return new 
                    default:
                        throw new Exception();
                }
            }
           */



            public int[] GetArrayMock(int n)
            {
                switch (n)
                {
                    case 1:
                        return
                            new int[] { 0, 2, 1, 5, 7, 10 };
                    case 2:
                        return new int[] { 50, 2, 1, 5, 7, 10 };
                    case 3:
                        return
                            new int[] { 50, 2, 34, 5, 7, 10 };
                    case 4:
                        return new int[] { 50, 75, 23, 5, 7, 10 };

                    default:
                        throw new Exception();
                }
            }
        }
    }
}