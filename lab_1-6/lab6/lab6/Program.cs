using System;

namespace lab6
{
    class Program
    {
        static double Reverse(double a)
        {
            string s = a.ToString();
            char[] ar = s.ToCharArray();
            Array.Reverse(ar);
            s = new string(ar);
            a = Convert.ToInt32(s);
            
           
            return a;
        }
        static void Main(string[] args)
        {
            double t;
            t = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine(Reverse(t));
        }
    }
}
