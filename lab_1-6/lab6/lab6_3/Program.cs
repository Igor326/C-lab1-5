using System;

namespace lab6_3
{
    class Program
    {

        static double ReverseDouble(double number)
        {
            char separator = ',';
            string str = number.ToString();
            int counter = str.IndexOf(separator);
            string strReversed = string.Empty;
            for (int i = counter - 1; i >= 0; i--)
            {
                strReversed += str[i];
            }
            if (strReversed == "") return number;
            strReversed += separator;
            for (int i = str.Length - 1; i > counter; i--)
            {
                strReversed += str[i];
            }
            return double.Parse(strReversed);
        }
            static void Main(string[] args)
                
                {
                    double t;
                    Console.WriteLine("Write some double value:");
                  t = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(ReverseDouble(t));
                }
            
        
    }
}

