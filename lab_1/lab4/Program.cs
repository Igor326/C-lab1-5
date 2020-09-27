using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int c = 0;
            Console.WriteLine("Insert amount of elements");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Insert ");
                Console.Write(i + 1);
                Console.WriteLine(" element:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + arr[i] + " ");

            }
            Console.WriteLine();

            if (n==3 ) {
                if (arr[1] < arr[0] && arr[2] > arr[1])
                {
                    c++;
                }
               
                
            }
            else
            if(n==3)
            {
                Console.WriteLine(" There are no elements.");
            }
            if ( n > 3)
            {
                if (arr[1] < arr[0] && arr[2] > arr[1])
                {
                    c++;
                }
                if (arr[n - 2] < arr[n-1] && arr[n - 2] < arr[n - 3])
                {
                    c++;
                }

            }
            /*for (int i = 2; i < n-2 ; i++)
            {
               if(arr[i] < arr[i-1] && arr[i] < arr[i + 1])
                {
                    c++;
                }

            }*/
            Console.WriteLine(" There is/are ");
            Console.Write(c);
            Console.Write(" element/elements.");
        }
    }
}
