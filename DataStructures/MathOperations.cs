using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class MathOperations
    {
        public static int FindMinElementOfTheArray(int[,] test)
        {
            int s = 0;
            for (int i = 0; i < test.GetLength(0); i++)
            {
                for (int j = 0; j < test.GetLength(1); j++)
                    if (s == 0)
                    {
                        s = test[i, j];
                    }
                    else if (s > test[i, j])
                    {
                        s = test[i, j];
                    }
            }
            return s;
        }

        public static int FindMaxElementOfTheArray(int[,] test)
        {
            int s = 0;
            for (int i = 0; i < test.GetLength(0); i++)
            {
                for (int j = 0; j < test.GetLength(1); j++)
                    if (s == 0)
                    {
                        s = test[i, j];
                    }
                    else if (s < test[i, j])
                    {
                        s = test[i, j];
                    }
            }
            return s;
        }

        public static int[] FindIndexOfMinElementOfTheArray(int[,] test)
        {
            int s = 0;
            int c = 0;
            int d = 0;
            int[] indexes = new int[2];
            for (int i = 0; i < test.GetLength(0); i++)
            {
                for (int j = 0; j < test.GetLength(1); j++)
                    if (i == 0 && j == 0)
                    {
                        c = i;
                        d = j;
                        s = test[i, j];

                    }
                    else if (s > test[i, j])
                    {
                        c = i;
                        d = j;
                        s = test[i, j];
                    }
            }
            indexes[0] = c;
            indexes[1] = d;
            return indexes;
        }



        public static int[] FindIndexOfMaxElementOfTheArray(int[,] test)
        {
            int s = 0;
            int c = 0;
            int d = 0;
            int[] indexes = new int[2];
            for (int i = 0; i < test.GetLength(0); i++)
            {
                for (int j = 0; j < test.GetLength(1); j++)
                    if (i == 0 && j == 0)
                    {
                        c = i;
                        d = j;
                        s = test[i, j];

                    }
                    else if (s < test[i, j])
                    {
                        c = i;
                        d = j;
                        s = test[i, j];
                    }
            }
            indexes[0] = c;
            indexes[1] = d;
            return indexes;
        }

        public static int FindNumberOfElementsLargerThanAllNeighboursOfTheArray(int[,] test)
        {
            int rows = test.GetLength(0);
            int columns = test.GetLength(1);
            int count = 0;
            int s = 0;
            for (int i = 0; i < test.GetLength(0); i++)
            {
                for (int j = 0; j < test.GetLength(1); j++)
                {
                    s = test[i, j];
                    if (((j != 0 && s > test[i, j - 1]) || j == 0) &&
                        ((j != columns - 1 && s > test[i, j + 1]) || (j == columns - 1)) &&
                        ((i != 0 && s > test[i - 1, j]) || (i == 0)) &&
                        ((i != rows - 1 && s > test[i + 1, j]) || (i == rows - 1))
                        )
                    {
                        count++;
                    }


                }

            }

            return count;
        }

        public static int FindMinElementOfTheArray(int[] test)
        {
            int min = 0;
            for (int i = 0; i < test.Length; i++)
            {
                if (i == 0 || test[i] < min)
                {
                    min = test[i];
                }
            }
            return min;
        }

        public static int FindMaxElementOfTheArray(int[] test)
        {
            int max = 0;
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] > max)
                {
                    max = test[i];
                }
            }
            return max;
        }

        public static int FindIndexOfMinElementOfTheArray(int[] test)
        {
            int min = -1;
            for (int i = 0; i < test.Length; i++)
            {
                if (min == -1 || test[i] < test[min])
                {
                    min = i;
                }
            }

            return min;
        }

        public static int FindIndexOfMaxElementOfTheArray(int[] test)
        {
            int max = -1;
            for (int i = 0; i < test.Length; i++)
            {
                if (max == -1 || test[i] > test[max])
                {
                    max = i;
                }
            }
            return max;
        }

        public static long FindSumOfElementsWithOddIndexesOfTheArray(int[] test)
        {
            long oddsum = 0;
            for (int i = 1; i < test.Length; i ++)
            {
                if (i % 2 != 0)
                {
                    oddsum += test[i];
                }
            }
            return oddsum;
        }

        public static int FindNumberOfOddElementsOfTheArray(int[] test)
        {
            int oddcount = 0;
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] % 2 != 0)
                {
                    oddcount++;
                }
            }
            return oddcount;
        }

        public static int PowerAToB(int a, int b)
        {
            int c = 1;
            for (int i = 0; i < b; i++)
            {
                c = c * a;
            }
            return c;
        }



    }
}
