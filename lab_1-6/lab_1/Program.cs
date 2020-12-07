using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {

            double t;
            
            Console.WriteLine("Insert v1 value");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(v1);
            Console.WriteLine("Insert v2 value");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(v2);
            Console.WriteLine("Insert a1 value");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a1);
            Console.WriteLine("Insert a2 value");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a2);
            Console.WriteLine("Insert S value");
            double S = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(S);
             t =S/((v1+v2)/(a1+a2));
            Console.Write("Time is ");
            Console.Write(t);
            Console.WriteLine("Seconds");




        }
    }
}
