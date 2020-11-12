
using NUnit.Framework;
using System;
using DataStructures;

namespace NUnitTestProjectDataStructures
{
    public class OrderOperationsTests
    {


        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, new int[] { 10, 7, 5, 1, 2, 0 })]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, new int[] { 10, 7, 5, 1, 2, 50 })]
        [TestCase(new int[] { 50, 2, 34, 5, 7, 10 }, new int[] { 10, 7, 5, 34, 2, 50 })]
        [TestCase(new int[] { 50, 75, 23, 5, 7, 10 }, new int[] { 10, 7, 5, 23, 75, 50 })]
        public void ReverseTheArrayTest(int[] a, int[] expected)
        {
            int[] actual = OrderOperations.ReverseTheArray(a);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, new int[] { 5, 7, 10, 0, 2, 1 })]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, new int[] { 5, 7, 10, 50, 2, 1 })]
        [TestCase(new int[] { 50, 2, 1, 2, 5, 7, 10 }, new int[] { 5, 7, 10, 2, 50, 2, 1 })]
        [TestCase(new int[] { 50, 75, 1, 3, 5, 7, 10 }, new int[] { 5, 7, 10, 3, 50, 75, 1 })]
        public void InterchangeTheArrayByTheCentreTest(int[] a, int[] expected)
        {
            int[] actual = OrderOperations.InterchangeTheArrayByTheCentre(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, new int[] { 0, 1, 2, 5, 7, 10 })]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, new int[] { 1, 2, 5, 7, 10, 50 })]
        [TestCase(new int[] { 50, 2, 1, 2, 5, 7, 10 }, new int[] { 1, 2, 2, 5, 7, 10, 50 })]
        [TestCase(new int[] { 50, 75, 1, 3, 5, 7, 10 }, new int[] { 1, 3, 5, 7, 10, 50, 75 })]
        public void InsertSortTheArrayAscTest(int[] a, int[] expected)
        {
            int[] actual = OrderOperations.InsertSortTheArrayAsc(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 0, 2, 1, 5, 7, 10 }, new int[] { 10, 7, 5, 2, 1, 0 })]
        [TestCase(new int[] { 50, 2, 1, 5, 7, 10 }, new int[] { 50, 10, 7, 5, 2, 1 })]
        [TestCase(new int[] { 50, 2, 1, 2, 5, 7, 10 }, new int[] { 50, 10, 7, 5, 2, 2, 1 })]
        [TestCase(new int[] { 50, 75, 1, 3, 5, 7, 10 }, new int[] { 75, 50, 10, 7, 5, 3, 1 })]
        public void BubbleSortTheArrayDescTest(int[] a, int[] expected)
        {
            int[] actual = OrderOperations.BubbleSortTheArrayDesc(a);

            Assert.AreEqual(expected, actual);
        }



        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        
        public void ReverseTheArrayRelativeToItsMainDiagonalTest(int arrayMockNumber, int expectedMockNumber)
        {
            int[,] expected = GetExpectedMockTranspose(expectedMockNumber);
            int[,] a = GetArrayMock(arrayMockNumber);
            int[,] actual = OrderOperations.ReverseTheArrayRelativeToItsMainDiagonal(a);
            Assert.AreEqual(expected, actual);
        }

        public int[,] GetExpectedMockTranspose(int n)
        {
            switch (n)
            {
                case 1:
                    return new int[,]
                    {
                        { 1, 2, 3 },
                        { 4, 5, 6 }
                    };
                case 2:
                    return new int[,]
                    {
                        { 1, 2, 3, 4 },
                        { 5, 6, 7, 8 }
                    };
                case 3:
                    return new int[,]
                    {
                        { 1, 2, 3 },
                        { 4, 5, 6 },
                        { 7, 8, 9 }
                    };
                case 4:
                    return new int[,]
                    {
                        { 1,1,1,1},
       
                    };
                default:
                    throw new Exception();
            }
        }




        public int[,] GetArrayMock(int n)
        { switch (n)
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