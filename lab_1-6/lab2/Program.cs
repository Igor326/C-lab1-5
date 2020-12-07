using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)

        {
           double n=0;
           double k=0;
            double S=1;
            int c = 0;
            do
            {
                Console.WriteLine("Insert n value:(n>=0)");
                 n = Convert.ToDouble(Console.ReadLine());
                if (n < 0|| n%1!=0)
                {
                    Console.WriteLine("Wrong data was entered, try onother one");
                    continue;
                }
                Console.WriteLine("Insert k value:(k>=n)");
                k = Convert.ToDouble(Console.ReadLine());
                if (k < n || k%1!=0)
                {
                    Console.WriteLine("Wrong data was entered, try onother one");
                    continue;
                }
                break;
            } while (true);
            k = n * n;
            n = n * k;
            do
            {
                S = S* (Math.Pow(-1, k) * k * k + Math.Pow(-1, (k * k + 1)) * k) / (2 * k * k * k + 3);
               
                c++;
            } while (k > c);
            Console.WriteLine("Summary="+S);
        }
    }
}
