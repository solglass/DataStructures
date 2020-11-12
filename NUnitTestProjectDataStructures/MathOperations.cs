using NUnit.Framework;
using System;
using DataStructures;

namespace NUnitTestProjectDataStructures
{
    public class MathOperationsTests
    {

        [TestCase(0, 0, 1)]
        [TestCase(10, 2, 100)]
        [TestCase(2, 3, 8)]
        [TestCase(3, 3, 27)]
        [TestCase(1, 10, 1)]
        public void PowerAToBtest(int a, int b, int expected)
        {
            int actual = MathOperations.PowerAToB(a, b);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, 0)]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, 1)]
        [TestCase(new int[] { 50, 2, 34, 5, 7, 10 }, 2)]
        [TestCase(new int[] { 50, 75, 23, 5, 7, 10 }, 5)]
        public void FindMinElementOfTheArrayTest(int[] a, int expected)
        {
            int actual = MathOperations.FindMinElementOfTheArray(a);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, 10)]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, 50)]
        [TestCase(new int[] { 50, 2, 34, 5, 7, 10 }, 50)]
        [TestCase(new int[] { 50, 75, 23, 5, 7, 10 }, 75)]
        public void FindMaxElementOfTheArrayTest(int[] a, int expected)
        {
            int actual = MathOperations.FindMaxElementOfTheArray(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, 0)]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, 2)]
        [TestCase(new int[] { 50, 2, 34, 5, 7, 10 }, 1)]
        [TestCase(new int[] { 50, 75, 23, 5, 7, 10 }, 3)]
        public void FindIndexOfMinElementOfTheArrayTest(int[] a, int expected)
        {
            int actual = MathOperations.FindIndexOfMinElementOfTheArray(a);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, 5)]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, 0)]
        [TestCase(new int[] { 50, 2, 34, 5, 7, 10 }, 0)]
        [TestCase(new int[] { 50, 75, 23, 5, 7, 10 }, 1)]
        public void FindIndexOfMaxElementOfTheArrayTest(int[] a, int expected)
        {
            int actual = MathOperations.FindIndexOfMaxElementOfTheArray(a);

            Assert.AreEqual(expected, actual);
        }



        //2d array tests
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 1)]
        [TestCase(4, 1)]

        public void FindMinElementOfTheArrayTest(int arrayMockNumber, int expected)
        {

            int[,] a = GetArrayMock(arrayMockNumber);
            int actual = MathOperations.FindMinElementOfTheArray(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 6)]
        [TestCase(2, 8)]
        [TestCase(3, 9)]
        [TestCase(4, 1)]

        public void FindMaxElementOfTheArrayTest(int arrayMockNumber, int expected)
        {
            int[,] a = GetArrayMock(arrayMockNumber);
            int actual = MathOperations.FindMaxElementOfTheArray(a); ;
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]

        public void FindIndexOfMinElementOfTheArrayTest(int arrayMockNumber, int expectedMockNumber)
        {
            int[] expected = GetExpectedMockMinIndex(expectedMockNumber);
            int[,] a = GetArrayMock(arrayMockNumber);
            int[] actual = MathOperations.FindIndexOfMinElementOfTheArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]

        public void FindIndexOfMaxElementOfTheArrayTest(int arrayMockNumber, int expectedMockNumber)
        {
            int[] expected = GetExpectedMockMaxIndex(expectedMockNumber);
            int[,] a = GetArrayMock(arrayMockNumber);
            int[] actual = MathOperations.FindIndexOfMaxElementOfTheArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 1)]
        [TestCase(4, 0)]

        public void FindNumberOfElementsLargerThanAllNeighboursOfTheArrayTest(int arrayMockNumber, int expected)
        {

            int[,] a = GetArrayMock(arrayMockNumber);
            int actual = MathOperations.FindNumberOfElementsLargerThanAllNeighboursOfTheArray(a);
            Assert.AreEqual(expected, actual);
        }


        public int[] GetExpectedMockMaxIndex(int n)
        {
            switch (n)
            {
                case 1:
                    return new int[]
                    {2,1};
                case 2:
                    return new int[]
                    {3,1 };
                case 3:
                    return new int[]
                    {2,2 };
                case 4:
                    return new int[]
                    {0,0};
                default:
                    throw new Exception();
            }
        }

        public int[] GetExpectedMockMinIndex(int n)
        {
            switch (n)
            {
                case 1:
                    return new int[]
                    {0,0};
                case 2:
                    return new int[]
                    {0,0};
                case 3:
                    return new int[]
                    {0,0};
                case 4:
                    return new int[]
                    {0,0};
                default:
                    throw new Exception();
            }
        }


        public int[,] GetArrayMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new int[,]
                    {
                                {1, 4 },
                                {2, 5 },
                                {3, 6 }
                    };
                case 2:
                    return new int[,]
                    {
                                {1, 5 },
                                {2, 6 },
                                {3, 7 },
                                {4, 8 }
                    };
                case 3:
                    return new int[,]
                    {
                                {1, 4, 7},
                                {2, 5, 8},
                                {3, 6, 9}
                    };
                case 4:
                    return new int[,]
                    {
                                {1 },
                                {1 },
                                {1 },
                                {1 }
                    };

                default:
                    throw new Exception();
            }
        }


    }
}