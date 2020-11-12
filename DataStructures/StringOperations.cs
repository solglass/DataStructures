using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class StringOperations
    {
        public static string  ReverseAStringNumber (string a)
        {
            string b = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                b += a[i];
            }
            return b;
        }
        public static bool DetermineIfTwoNumbersHaveEqualDigits(string a, string b)
        {
            bool isOneSymbolEqual = false;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {

                    if (a[i] == b[j])
                    { isOneSymbolEqual = true; }

                    if (isOneSymbolEqual)
                    { break; }
                }
                if (isOneSymbolEqual)
                {
                    break;
                }
            }
            return isOneSymbolEqual;
        }

    }
}

