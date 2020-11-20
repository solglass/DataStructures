using NUnit.Framework;
using NUnitTestProjectDataStructures;
using DataStructures;
using System;

namespace NUnitTestProjectDataStructures
{
    public class Tests
    {
        public class ArrayListTest
        {


            public void GetLenght(int[] a, int expected)
            {
                DataStructures.ArrayList arrayListTest = new ArrayList();
                int actual = arrayListTest.GetLenght();

                Assert.AreEqual(expected, actual);
            }

            [TestCase(1, 11)]
            [TestCase(2, 12)]
            [TestCase(3, 13)]
            [TestCase(4, 14)]
            public void AddTest(int arrayMockNumber, int elem)
            {
                int[] e = GetExpectedMockAdd(arrayMockNumber);
                int[] a = GetArrayMock(arrayMockNumber);

                DataStructures.ArrayList expected = new ArrayList(e);
                DataStructures.ArrayList actual = new ArrayList(a);
                actual.Add(elem);

                Assert.AreEqual(expected, actual);
            }


            [TestCase(1, 11)]
            [TestCase(2, 12)]
            [TestCase(3, 0)]
            [TestCase(4, -10)]
            public void AddFirstTest(int arrayMockNumber, int elem)
            {
                int[] e = GetExpectedMockAddFirst(arrayMockNumber);
                int[] a = GetArrayMock(arrayMockNumber);

                DataStructures.ArrayList expected = new ArrayList(e);

                DataStructures.ArrayList actual = new ArrayList(a);
                actual.AddFirst(elem);

                Assert.AreEqual(expected, actual);
            }

            [TestCase(1, 11, 0)]
            [TestCase(2, 12, 2)]
            [TestCase(3, 0, 3)]
            [TestCase(4, -10, 5)]
            public void AddByIndexTest(int arrayMockNumber, int elem, int position)
            {
                int[] e = GetExpectedMockAddAtPosition(arrayMockNumber);
                int[] a = GetArrayMock(arrayMockNumber);

                DataStructures.ArrayList expected = new ArrayList(e);

                DataStructures.ArrayList actual = new ArrayList(a);
                actual.AddByIndex(elem, position);

                Assert.AreEqual(expected, actual);
            }

            [TestCase(1)]
            [TestCase(2)]
            [TestCase(3)]
            [TestCase(4)]
            public void DeleteLastTest(int arrayMockNumber)
            {
                int[] e = GetExpectedMockDeleteLast(arrayMockNumber);
                int[] a = GetArrayMock(arrayMockNumber);

                DataStructures.ArrayList expected = new ArrayList(e);

                DataStructures.ArrayList actual = new ArrayList(a);
                actual.DeleteLast();

                Assert.AreEqual(expected, actual);
            }

            [TestCase(1)]
            [TestCase(2)]
            [TestCase(3)]
            [TestCase(4)]
            public void DeleteFirstTest(int arrayMockNumber)
            {
                int[] e = GetExpectedMockDeleteFirst(arrayMockNumber);
                int[] a = GetArrayMock(arrayMockNumber);

                DataStructures.ArrayList expected = new ArrayList(e);

                DataStructures.ArrayList actual = new ArrayList(a);
                actual.DeleteFirst();

                Assert.AreEqual(expected, actual);
            }


            [TestCase(1,5)]
            [TestCase(2,10)]
            [TestCase(3,2)]
            [TestCase(4,7)]
            public void DeleteAllByValueTest(int arrayMockNumber, int value)
            {
                int[] e = GetExpectedMockDeleteAllByValue(arrayMockNumber);
                int[] a = GetArrayMock(arrayMockNumber);

                DataStructures.ArrayList expected = new ArrayList(e);

                DataStructures.ArrayList actual = new ArrayList(a);
                actual.DeleteAllByValue(value);

                Assert.AreEqual(expected, actual);
            }



            [TestCase(1, 1)]
            [TestCase(2, 2)]
            [TestCase(3, 3)]
            [TestCase(4, 4)]
            public void DeleteLastElementsTest(int arrayMockNumber, int numberOfElems)
            {
                int[] e = GetExpectedMockDeleteLastElements(arrayMockNumber);
                int[] a = GetArrayMock(arrayMockNumber);

                DataStructures.ArrayList expected = new ArrayList(e);

                DataStructures.ArrayList actual = new ArrayList(a);
                actual.DeleteLastElements(numberOfElems);

                Assert.AreEqual(expected, actual);
            }

            [TestCase(1, 1)]
            [TestCase(2, 2)]
            [TestCase(3, 3)]
            [TestCase(4, 4)]
            public void DeleteFirstElementsTest(int arrayMockNumber, int numberOfElems)
            {
                int[] e = GetExpectedMockDeleteFirstElements(arrayMockNumber);
                int[] a = GetArrayMock(arrayMockNumber);

                DataStructures.ArrayList expected = new ArrayList(e);

                DataStructures.ArrayList actual = new ArrayList(a);
                actual.DeleteFirstElements(numberOfElems);

                Assert.AreEqual(expected, actual);
            }

            [TestCase(1, 1, 4)]
            [TestCase(2, 2, 3)]
            [TestCase(3, 3, 2)]
            [TestCase(4, 4, 1)]
            public void DeleteElementsAtPositionTest(int arrayMockNumber, int numberOfElems, int index)
            {
                int[] e = GetExpectedMockDeleteElementsAtPosition(arrayMockNumber);
                int[] a = GetArrayMock(arrayMockNumber);

                DataStructures.ArrayList expected = new ArrayList(e);

                DataStructures.ArrayList actual = new ArrayList(a);
                actual.DeleteElementsAtPosition(index, numberOfElems);

                Assert.AreEqual(expected, actual);
            }

            [TestCase(1, 5)]
            [TestCase(2, 10)]
            [TestCase(3, 2)]
            [TestCase(4, 7)]
            public void DeleteFirstByValueTest(int arrayMockNumber, int value)
            {
                int[] e = GetExpectedMockDeleteFirstByValue(arrayMockNumber);
                int[] a = GetArrayMock(arrayMockNumber);

                DataStructures.ArrayList expected = new ArrayList(e);

                DataStructures.ArrayList actual = new ArrayList(a);
                actual.DeleteFirstByValue(value);

                Assert.AreEqual(expected, actual);
            }





            [TestCase(1)]
            [TestCase(2)]
            [TestCase(3)]
            [TestCase(4)]

            public void SortArrayDesc(int arrayMockNumber)
            {
                int[] a = GetArrayMock(arrayMockNumber);
                DataStructures.ArrayList expected = new ArrayList(OrderOperations.BubbleSortTheArrayDesc(a));
                DataStructures.ArrayList arrayListTest = new ArrayList(a);
                arrayListTest.SortDesc();
                Assert.AreEqual(expected, arrayListTest);
            }

            [TestCase(1)]
            [TestCase(2)]
            [TestCase(3)]
            [TestCase(4)]
            public void SortArrayAsc(int arrayMockNumber)
            {
                int[] a = GetArrayMock(arrayMockNumber);
                DataStructures.ArrayList expected = new ArrayList(OrderOperations.InsertSortTheArrayAsc(a));
                DataStructures.ArrayList arrayListTest = new ArrayList(a);
                arrayListTest.SortAsc();
                Assert.AreEqual(expected, arrayListTest);
            }

            [TestCase(1)]
            [TestCase(2)]
            [TestCase(3)]
            [TestCase(4)]
            public void Reverse(int arrayMockNumber)
            {
                int[] a = GetArrayMock(arrayMockNumber);
                DataStructures.ArrayList expected = new ArrayList(OrderOperations.ReverseTheArray(a));
                DataStructures.ArrayList arrayListTest = new ArrayList(a);
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
                DataStructures.ArrayList arrayListTest = new ArrayList(a);
                int actual = arrayListTest.FindIndexOfMaxElement();
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
                DataStructures.ArrayList arrayListTest = new ArrayList(a);
                int actual = arrayListTest.FindIndexOfMinElement();
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
                DataStructures.ArrayList arrayListTest = new ArrayList(a);
                int actual = arrayListTest.FindMinElement();
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
                DataStructures.ArrayList arrayListTest = new ArrayList(a);
                int actual = arrayListTest.FindMaxElement();
                Assert.AreEqual(expected, actual);
            }

            [TestCase(1,-1)]
            [TestCase(2,-2)]
            [TestCase(3,-3)]
            [TestCase(4,-4)]
            public void GetElementNegativeTest(int arrayMockNumber, int index)
            {
                int[] a = GetArrayMock(arrayMockNumber);
                DataStructures.ArrayList actual = new ArrayList(a);
                Assert.Throws<IndexOutOfRangeException>(() => actual[index] = 0);
            }


            public int[] GetExpectedMockAdd(int n)
            {
                switch (n)
                {
                    case 1:
                        return new int[] { 0, 2, 1, 5, 7, 10, 11 };
                    case 2:
                        return new int[] { 50, 2, 1, 5, 7, 10, 12 };
                    case 3:
                        return new int[] { 50, 2, 34, 5, 7, 10, 13 };
                    case 4:
                        return new int[] { 50, 75, 23, 5, 7, 10, 14 };
                    default:
                        throw new Exception();
                }
            }

            public int[] GetExpectedMockAddFirst(int n)
            {
                switch (n)
                {
                    case 1:
                        return new int[] {11, 0, 2, 1, 5, 7, 10};
                    case 2:
                        return new int[] {12, 50, 2, 1, 5, 7, 10};
                    case 3:
                        return new int[] {0, 50, 2, 34, 5, 7, 10 };
                    case 4:
                        return new int[] {-10, 50, 75, 23, 5, 7, 10};
                    default:
                        throw new Exception();
                }
            }



            public int[] GetExpectedMockAddAtPosition(int n)
            {
                switch (n)
                {
                    case 1:
                        return new int[] { 11, 0, 2, 1, 5, 7, 10 };
                    case 2:
                        return new int[] {50, 2, 12, 1, 5, 7, 10 };
                    case 3:
                        return new int[] { 50, 2, 34, 0, 5, 7, 10 };
                    case 4:
                        return new int[] {  50, 75, 23, 5, 7, -10, 10};
                    default:
                        throw new Exception();
                }
            }


            public int[] GetExpectedMockDeleteFirst(int n)
            {
                switch (n)
                {
                    case 1:
                        return
                            new int[] {  2, 1, 5, 7, 10 };
                    case 2:
                        return new int[] {  2, 1, 5, 7, 10 };
                    case 3:
                        return
                            new int[] {  2, 34, 5, 7, 10 };
                    case 4:
                        return new int[] {  75, 23, 5, 7, 10 };

                    default:
                        throw new Exception();
                }
            }


            public int[] GetExpectedMockDeleteLast(int n)
            {
                switch (n)
                {
                    case 1:
                        return
                            new int[] { 0, 2, 1, 5, 7 };
                    case 2:
                        return new int[] { 50, 2, 1, 5, 7 };
                    case 3:
                        return
                            new int[] { 50, 2, 34, 5, 7};
                    case 4:
                        return new int[] { 50, 75, 23, 5, 7};

                    default:
                        throw new Exception();
                }
            }

            public int[] GetExpectedMockDeleteLastElements(int n)
            {
                switch (n)
                {
                    case 1:
                        return
                            new int[] { 0, 2, 1, 5, 7};
                    case 2:
                        return new int[] { 50, 2, 1, 5};
                    case 3:
                        return
                            new int[] { 50, 2, 34};
                    case 4:
                        return new int[] { 50, 75};

                    default:
                        throw new Exception();
                }
            }

            public int[] GetExpectedMockDeleteFirstElements(int n)
            {
                switch (n)
                {
                    case 1:
                        return
                            new int[] { 2, 1, 5, 7, 10 };
                    case 2:
                        return new int[] {  1, 5, 7, 10 };
                    case 3:
                        return
                            new int[] {  5, 7, 10 };
                    case 4:
                        return new int[] { 7, 10 };

                    default:
                        throw new Exception();
                }
            }

            public int[] GetExpectedMockDeleteElementsAtPosition (int n)
            {
                switch (n)
                {
                    case 1:
                        return
                            new int[] { 0, 2, 1, 5,  10 };
                    case 2:
                        return new int[] { 50, 2, 1,  10 };
                    case 3:
                        return
                            new int[] { 50, 2,  10 };
                    case 4:
                        return new int[] { 50,  10 };

                    default:
                        throw new Exception();
                }
            }

            public int[] GetExpectedMockDeleteAllByValue(int n)
            {
                switch (n)
                {
                    case 1:
                        return
                            new int[] { 0, 2, 1,  7, 10 };
                    case 2:
                        return new int[] { 50, 2, 1, 5, 7 };
                    case 3:
                        return
                            new int[] { 50,  34, 5, 7, 10 };
                    case 4:
                        return new int[] { 50, 75, 23, 5,  10 };

                    default:
                        throw new Exception();
                }
            }

            public int[] GetExpectedMockDeleteFirstByValue(int n)
            {
                switch (n)
                {
                    case 1:
                        return
                            new int[] { 0, 2, 1, 7, 10 };
                    case 2:
                        return new int[] { 50, 2, 1, 5, 7 };
                    case 3:
                        return
                            new int[] { 50, 34, 5, 7, 10 };
                    case 4:
                        return new int[] { 50, 75, 23, 5, 10 };

                    default:
                        throw new Exception();
                }
            }

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