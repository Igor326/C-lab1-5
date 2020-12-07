using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool answer;
            int a;
            int b;
            int c;
            while (true)
            {
                Console.WriteLine("Insert your value:(100-999)");
                number= Convert.ToInt32(Console.ReadLine());
                if (number<100 || number>999|| number%1!=0)
                {
                    Console.WriteLine("Wrong data was entered, try onother one");
                    continue;
                }
                break;
            }
            c = number % 10;
            number /= 10;
            b = number % 10;
            number /= 10;
            a = number % 10;
           
            
            
            if (b > a && c > b)
            {
                answer = true;
            }
            else answer = false;
            Console.WriteLine(answer);


        }
    }
}
