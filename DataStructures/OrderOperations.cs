using System;

namespace DataStructures
{
    public class OrderOperations
    {
        public static int[,] ReverseTheArrayRelativeToItsMainDiagonal(int[,] test)
        {
            int[,] test2 = new int[test.GetLength(1), test.GetLength(0)];
            for (int i = 0; i < test.GetLength(0); i++)
            {
                for (int j = 0; j < test.GetLength(1); j++)
                {
                    test2[j, i] = test[i, j];

                }


            }
            return test2;
        }



        public static int[] ReverseTheArray(int[] test)
        {
            int[] test2 = new int[test.Length];
            for (int i = 0; i < test2.Length; i++)
            {
                test2[test2.Length - i - 1] = test[i];
            }
            return test2;
        }

        public static int[] InterchangeTheArrayByTheCentre(int[] test)
        {
            int n = test.Length;
            int[] swapped = new int[n];
            if (n % 2 == 0)
            {
                for (int i = 0; i < test.Length; i++)
                {
                    if (i < n / 2)
                    {
                        swapped[i] = test[n / 2 + i];
                    }
                    else
                        swapped[i] = test[i - n / 2];
                }


            }
            else


            {
                int m = n / 2;
                for (int i = 0; i < test.Length; i++)
                {
                    if (i < m)
                    {
                        swapped[i] = test[m + i + 1];
                    }
                    else if (i > m)
                    {
                        swapped[i] = test[i - m - 1];
                    }
                    else
                    {
                        swapped[i] = test[i];
                    }
                }


            }
            return swapped;
        }

        public static int[] InsertSortTheArrayAsc(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int swap = 0;
                for (int j = i; j > 0 && a[j - 1] > a[j]; j--)
                {
                    swap = a[j];
                    a[j] = a[j - 1];
                    a[j - 1] = swap;
                }


            }

            return a;
        }

        public static int[] BubbleSortTheArrayDesc(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int swap = 0;
                for (int j = i; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        swap = a[j];
                        a[j] = a[i];
                        a[i] = swap;
                    }
                }


            }

            return a;
        }


    }


}
