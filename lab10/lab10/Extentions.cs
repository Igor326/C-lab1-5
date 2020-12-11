using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lab10
{
    static class Extentions
    {
        public static int Reverse(this int value)
        {
            int temp = 0;
            while (value > 0)
            {
                int remainded = value % 10;
                temp = (temp * 10) + remainded;
                value = value / 10;
            }
            return temp;
        }
        public static string Reverse(this string value)
        {
            string temp = string.Empty;
            for (int i = value.Length - 1; i >= 0; i--)
                temp += value[i];
            return temp;
        }
        public static string SplitReverse(this string value)
        {
            string temp = string.Empty;
            var strings = value.Split(',');

            for (int i = 0; i < strings.Length - 1; i++)
                temp += Reverse(strings[i]) + ',';

            temp += Reverse(strings[strings.Length - 1]);

            return temp;
        }
        public static double SplitReverse(this double value) =>
           Double.Parse(SplitReverse(value.ToString(CultureInfo.CurrentCulture)));
        public static T[] Reverse<T>(this T[] array)
        {
            T[] newArr = new T[array.Length];
            for (int i = 0, j = array.Length - 1;
                i < array.Length;
                i++, j--)
            {
                newArr[i] = array[j];
            }

            return newArr;
        }
        public static void SortDecsOrderArr(this int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
