using System;

namespace lab6_2
{
    class Program
    {
        static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Write something:");
            str = Convert.ToString(Console.ReadLine());
            Console.WriteLine(ReverseString(str));

        }
    }
}
