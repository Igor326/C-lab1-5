using System;

namespace lab6_5
{
    class Program
    {
        static int RecursiveReverse(int number, int reversedNumber = 0)
        {
            if (number == 0)
            {
                return reversedNumber;
            }

            reversedNumber = (reversedNumber * 10) + (number % 10);
            return RecursiveReverse(number / 10, reversedNumber);
        }
        static string RecursiveReverse(string str, string reversedStr = "", int counter = 1)
        {
            if (str.Length == counter - 1) return reversedStr;
            reversedStr += str[str.Length - counter];
            return RecursiveReverse(str, reversedStr, ++counter);
        }
        static double RecursiveReverse(double number, char separator = ',')
        {
            string strNumber = number.ToString();
            string reversedNumber = string.Empty;
            var str_arr = strNumber.Split(separator);

            reversedNumber += RecursiveReverse(str_arr[0]);
            if (str_arr.Length > 1)
            {
                reversedNumber += separator;
                reversedNumber += RecursiveReverse(str_arr[1]);
            }
            return double.Parse(reversedNumber);
        }
        static string RecursiveReverse(string str, string separator)
        {
            string reversedStr = string.Empty;
            var str_arr = str.Split(separator);

            reversedStr += RecursiveReverse(str_arr[0]) + '-' + separator + '-' + RecursiveReverse(str_arr[1]);
            return reversedStr;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
