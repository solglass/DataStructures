using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
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
        public static int CalculateNumberOfSumOfEvensMoreThanSumOfOddsFromOneToN(int a)
        {
            int count = 0;
            int c = 0;
            int b = 0;
            int d = 0;
            for (int i = 0; i < a; i++)
            {
                string s = Convert.ToString(i);
                for (int j = 0; j < s.Length; j++)
                {

                    b = Convert.ToInt32(s[j]);
                    if (b % 2 == 0)
                    { c = c + b; }
                    else { d = d + b; }
                }
                if (c > d)
                {
                    count++;
                }
                c = 0;
                d = 0;

            }
            return count;
        }
        public static int[] CalculateTheArrayOfIntegersDivisibleByA(int a)
        {
            int[] Divisibles = new int[1000/a];
            int key = 0;
            for (int i = a; i <= 1000; i+=a)
            {
                    Divisibles[key] = i;
                    key++;
            }
            return Divisibles;

        }
        public static int CalculateTheNumberOfIntegersSquareOfEachIsLessThanA(int a)
        {
            int b = 0;
            int c = 0;
            for (int i = 1; i <= a; i++)
            {
                c = i * i;
                if (c < a)
                {
                    b++;
                }


            }
            return b;
        }

        public static int CalculateTheMaxCommonDivisorOfA(int a)
        {
            int b = 0;
            int c = 0;
            for (int i = 1; i < a; i++)
            {
                c = a % i;
                if (c == 0)
                {
                    b =i;
                }



            }
            return b;
        }
        public static int CalculateTheNthFibbonacciNumber(int a)
        {
            int b = 1;
            int c = 1;
            int d = 0;

            if (a == 1)
            {
                d = 1;
            }
            else if (a == 2)
            {
                d = 2;
            }
            else
            {
                for (int i = 1; i < a; i++)

                {
                    if (i == 1)
                    {
                        b = 0;
                        c = 1;
                        d = 1;
                    }
                    else if (i == 2)
                    {
                        b = 1;
                        d = c + b;
                        c = 2;
                    }
                    else
                    {
                        d = c + b;
                        b = c;
                        c = d;
                    }
                }
            }
            return d;
        }
        public static int CalculateMaxCommonDivisorByEuclidiusAlgorithm(int a, int b)
        {

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }


                else if (a < b)

                {
                    b = b - a;
                }

            }

            return a;

        }
        public static int CalculateTheNFromCubeByHalfDivisionAlgorithm(int acube)
        {
            double b = acube;
            double a = 0;
            while (Math.Abs(a * a * a - acube) > 0.01)
            {
                if (a * a * a < acube)
                { a = (a + b) / 2; }
                else if (a * a * a > acube)
                {
                    b = a;
                    a = (0 + a) / 2;
                }

            }
            return (int)Math.Round(a);

        }

        public static int CalculateTheNumberOfOddsOfANumber(string a)
        {
            int c = 0;
            int b = 0;
            for (int i = 0; i < a.Length; i++)
            {
                b = Convert.ToInt32(a[i]);
                if (b % 2 != 0)
                { c++; }
            }
            return c;
        }


        public static int CalculateSum(int a, int b)
        {
            int c;
            c = a + b;
            return c;
        }

        public static int CalculateMultiplication(int a, int b)
        {
            int c;
            c = a * b;
            return c;
        }

        public static int CalculateDifference(int a, int b)
        {
            int c;
            c = a - b;
            return c;
        }

        public static double[] SolveQudraticEquation(double a, double b, double c)
        {
            double d;
            double[] Solutions = new double[2] { 0, 0 };
            d = (Math.Pow(b, 2) - 4 * a * c) ;
            if (d > 0)
            {
                Solutions[0] = (-b + Math.Sqrt(d)) / (2 * a);
                Solutions[1] = (-b - Math.Sqrt(d)) / (2 * a);
            }

            else
            {
                throw new Exception("D is less than 0. No real solutions");

            }
            return Solutions;
        }
        public static int DetermineTheQudrantOfACoordinate(int x, int y)
        {
            int quadrant = 0;
            if (x > 0 && y > 0)
            {
                quadrant = 1;
            }
            else if (x < 0 && y > 0)
            {
                quadrant = 2;
            }
            else if (x < 0 && y < 0)
            {
                quadrant = 3;
            }
            else if (x > 0 && y < 0)
            {
                quadrant = 4;
            }
            else
            {
                quadrant = 0;
            }
            return quadrant;
        }

        public static int[] SortThreeIntegers(int a, int b, int c)
        {
            int[] SortedIntegers = new int[3];

            if (a >= b && a >= c)
            {
                if (b >= c)
                {
                    SortedIntegers[0] = c;
                    SortedIntegers[1] = b;
                    SortedIntegers[2] = a;

                }
                else
                {
                    SortedIntegers[0] = b;
                    SortedIntegers[1] = c;
                    SortedIntegers[2] = a;

                }
            }
            else if (a >= b && a < c)
            {
                SortedIntegers[0] = b;
                SortedIntegers[1] = a;
                SortedIntegers[2] = c;
            }
            else if (a < b && a < c)
            {
                if (b >= c)
                {
                    SortedIntegers[0] = a;
                    SortedIntegers[1] = c;
                    SortedIntegers[2] = b;
                }
                else
                {
                    SortedIntegers[0] = a;
                    SortedIntegers[1] = b;
                    SortedIntegers[2] = c;
                }
            }

            return SortedIntegers;
        }
    }
}
