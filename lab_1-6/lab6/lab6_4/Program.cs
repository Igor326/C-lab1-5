using System;

namespace lab6_4
{
    class Program
    {
        static string usualReverse(string str)
        {
            string reversedStr = string.Empty;
            for (int i = str.Length; i > 0; i--)
            {
                reversedStr += str[i - 1];
            }
            return reversedStr;
        }
        static string StringReverse(string str, string separator)
        {
            string reversedStr = string.Empty;
            var str_arr = str.Split(separator);

            reversedStr += usualReverse(str_arr[0])  + separator  + usualReverse(str_arr[1]);
            return reversedStr;
        }
        static void Main(string[] args)
        {
            string t;
            Console.WriteLine("Type something with separation sign:");
            t = Convert.ToString(Console.ReadLine());
            Console.WriteLine(StringReverse(t,","));
        }
    }
}
