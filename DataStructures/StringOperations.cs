using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
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

        public static String GetStringRepresantationOfTwoDigitInteger(int a)
        {
            string numb;
            numb = a.ToString();

            string prevtext = " ";
            string addtext = "надцать";
            if (numb[0].Equals('1'))
            {
                switch (numb[1])
                {
                    case '0':
                        prevtext = "десять";
                        break;
                    case '1':
                        prevtext = "один";
                        break;
                    case '2':
                        prevtext = "двен";
                        break;
                    case '3':
                        prevtext = "три";
                        break;
                    case '4':
                        prevtext = "четыр";
                        break;
                    case '5':
                        prevtext = "пят";
                        break;
                    case '6':
                        prevtext = "шест";
                        break;
                    case '7':
                        prevtext = "сем";
                        break;
                    case '8':
                        prevtext = "восем";
                        break;
                    case '9':
                        prevtext = "девят";
                        break;

                }

            }
            else
            {
                switch (numb[0])
                {
                    case '2':
                        prevtext = "двадцать";
                        break;
                    case '3':
                        prevtext = "тридцать";
                        break;
                    case '4':
                        prevtext = "сорок";
                        break;
                    case '5':
                        prevtext = "пятьдесят";
                        break;
                    case '6':
                        prevtext = "шестьдесят";
                        break;
                    case '7':
                        prevtext = "семьдесят";
                        break;
                    case '8':
                        prevtext = "восемьдесят";
                        break;
                    case '9':
                        prevtext = "девяносто";
                        break;
                }

                switch (numb[1])
                {
                    case '0':
                        addtext = " ";
                        break;
                    case '1':
                        addtext = "один";
                        break;
                    case '2':
                        addtext = "два";
                        break;
                    case '3':
                        addtext = "три";
                        break;
                    case '4':
                        addtext = "четыре";
                        break;
                    case '5':
                        addtext = "пять";
                        break;
                    case '6':
                        addtext = "шесть";
                        break;
                    case '7':
                        addtext = "семь";
                        break;
                    case '8':
                        addtext = "восемь";
                        break;
                    case '9':
                        addtext = "девять";
                        break;


                }
                addtext =  " " + addtext;

            }
            return prevtext + addtext;
        }
    }
}

